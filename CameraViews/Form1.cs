using System;
using System.Windows.Forms;

using Tao.OpenGl;
// для работы с библиотекой FreeGLUT 
using Tao.FreeGlut;
// для работы с элементом управления SimpleOpenGLControl 

namespace FigureRotate
{
    public partial class Form1 : Form
    {
        private double x = 0;
        private double y = 0;
        private double z = 1;

        private double r;
        private double phi;
        private double theta;

        private bool isNegativeX = false;
        private bool isNegativeY = false;
        private bool isNegativeZ = false;

        private bool isDecart = true;

        public Form1()
        {
            InitializeComponent();
            AnT.InitializeContexts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Controls.Add(groupBox3);
            groupBox3.Location = groupBox1.Location;

            SetInitialPosition();

            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);

            // отчистка окна 
            Gl.glClearColor(255, 255, 255, 1);

            // установка порта вывода в соответствии с размерами элемента anT 
            Gl.glViewport(0, 0, AnT.Width, AnT.Height);


            // настройка проекции 
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(45, (float)AnT.Width / (float)AnT.Height, 0.1, 200);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();

            // настройка параметров OpenGL для визуализации 
            Gl.glEnable(Gl.GL_DEPTH_TEST);
        }

        private void AnT_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);

            Gl.glLoadIdentity();

            //установка камеры (камера находится в точке (xx,yy,zz), смотрит в точку (0,0,0)
            Glu.gluLookAt(x, y, z, 0, 0, 0, 0, 1, 0);

            //рисование координатных осей и треугольника
            //OX - красная
            //OY - зеленая
            //OZ - синяя
            Gl.glPushMatrix();
            Gl.glColor3f(1.0f, 0.0f, 0.0f);
            DrawAxes();
            DrawTriangle(0.5f);
            Gl.glPopMatrix();

            //вывод нарисованного
            Gl.glFlush();
        }

        /// <summary>
        /// корректировка значений сферических координат в зависимости от вводимых декартовых (по четвертям)
        /// </summary>
        private void CorrectPolarValues()
        {
            //установка значений в критическом случае, если камера - в точке (0,0,0)
            if (Math.Abs(x) <= 0.01 && Math.Abs(y) <= 0.01 && Math.Abs(z) <= 0.01)
            {
                phi = r = theta = 0;
                return;
            }

            //установка зенитного радиуса phi
            if (isNegativeX && isNegativeZ)
                phi += Math.PI;

            if (isNegativeZ && !isNegativeX)
                phi += Math.PI;

            if (isNegativeX && !isNegativeZ)
                phi += 2 * Math.PI;

            if (Math.Abs(z) <= 0.01)
            {
                if (!isNegativeX)
                    phi = Math.PI / 2d;
                else phi = 3 * Math.PI / 2;
            }

            if (Math.Abs(phi) <= 0.01)
                phi = 0;
            
            phi *= 180 / Math.PI;

            //установка азимутального радиуса theta
            if (isNegativeY)
                theta += Math.PI;
            else
                theta = Math.Abs(theta);

            theta *= 180 / Math.PI;
        }

        private bool isFix = false;

        /// <summary>
        /// первоначальная установка значений на форме
        /// </summary>
        private void SetInitialPosition()
        {
            x = y = z = 1;

            isFix = false;

            updownX.Value = Convert.ToDecimal(x);
            updownY.Value = Convert.ToDecimal(y);
            updownZ.Value = Convert.ToDecimal(z);

            lblXP.Text = Math.Round(x, 2).ToString();
            lblYP.Text = Math.Round(y, 2).ToString();
            lblZP.Text = Math.Round(z, 2).ToString();

            DecartToPolar();
            CorrectPolarValues();
            
            updownRo.Value = Convert.ToDecimal(r);
            updownPhi.Value = Convert.ToDecimal(phi);
            updownTheta.Value = Convert.ToDecimal(theta);

            lblRo.Text = Math.Round(r, 2).ToString();
            lblPhi.Text = Math.Round(phi).ToString();
            lblTheta.Text = Math.Round(theta).ToString();

            AnT.Invalidate();
            isFix = true;
        }

        /// <summary>
        /// Установка на форме значений декартовых координат в соответствии с полярными и наоборот
        /// </summary>
        private void SetValuesOnForm()
        {
            x = String.IsNullOrEmpty(updownX.Text)? 0 : Convert.ToDouble(updownX.Value);
            y = String.IsNullOrEmpty(updownY.Text)? 0 : Convert.ToDouble(updownY.Value);
            z = String.IsNullOrEmpty(updownZ.Text)? 0 : Convert.ToDouble(updownZ.Value);

            r = String.IsNullOrEmpty(updownRo.Text)? 0 : Convert.ToDouble(updownRo.Value);
            phi = String.IsNullOrEmpty(updownPhi.Text)? 0 : Convert.ToDouble(updownPhi.Value);
            theta = String.IsNullOrEmpty(updownTheta.Text)? 0 : Convert.ToDouble(updownTheta.Value);

            if (isDecart)
            {
                DecartToPolar();
                CorrectPolarValues();

                lblRo.Text = Math.Round(r, 2).ToString();
                lblPhi.Text = Math.Round(phi).ToString();
                lblTheta.Text = Math.Round(theta).ToString();

                AnT.Invalidate();
            }
            else if (!isDecart)
            {
                PolarToDecart();
                CorrectPolarValues();
                AnT.Invalidate();

                lblXP.Text = Math.Round(x,2).ToString();
                lblYP.Text = Math.Round(y, 2).ToString();
                lblZP.Text = Math.Round(z, 2).ToString();

            }
        }

        //события на изменение значений на панели декартовых координат
        private void updownX_ValueChanged(object sender, EventArgs e)
        {
            x = (double)updownX.Value;
            isNegativeX = Math.Sign(x) == -1;
            if(isFix)
            SetValuesOnForm();
            AnT.Invalidate();
        }

        private void updownY_ValueChanged(object sender, EventArgs e)
        {
            y = (double)updownY.Value;
            isNegativeY = Math.Sign(y) == -1;
            if (isFix) SetValuesOnForm();
            AnT.Invalidate();
        }

        private void updownZ_ValueChanged(object sender, EventArgs e)
        {
            z = (double)updownZ.Value;
            isNegativeZ = Math.Sign(z) == -1;
            if (isFix) SetValuesOnForm();
            AnT.Invalidate();
        }

        //изменение значений на панели сферических координат
        private void updownRo_ValueChanged(object sender, EventArgs e)
        {
            r = (double)updownRo.Value;
            SetValuesOnForm();
            AnT.Invalidate();
        }

        private void updownPhi_ValueChanged(object sender, EventArgs e)
        {
            phi = (double)updownPhi.Value;
            SetValuesOnForm();
            AnT.Invalidate();
        }

        private void updownTheta_ValueChanged(object sender, EventArgs e)
        {
            theta = (double)updownTheta.Value;
            SetValuesOnForm();
            AnT.Invalidate();
        }

        /// <summary>
        /// Функция отрисовки координатных осей
        /// </summary>
        private void DrawAxes()
        {
            Gl.glLineWidth(2);
            Gl.glBegin(Gl.GL_LINES);

            Gl.glColor3f(1.0f, 0.0f, 0.0f);
            Gl.glVertex3f(0f, 0f, 0f);
            Gl.glVertex3f(20f, 0f, 0f);

            Gl.glColor3f(0.0f, 1.0f, 0.0f);
            Gl.glVertex3f(0f, 0f, 0f);
            Gl.glVertex3f(0f, 20f, 0f);

            Gl.glColor3f(0.0f, 0.0f, 1.0f);
            Gl.glVertex3f(0f, 0f, 0f);
            Gl.glVertex3f(0f, 0f, 20f);

            Gl.glEnd();

            // Пунктирные линии - продолжения осей в отрицательные области
            Gl.glEnable(Gl.GL_LINE_STIPPLE);
            Gl.glLineStipple(1, 0x0101);
            Gl.glBegin(Gl.GL_LINES);

            Gl.glColor3f(1.0f, 0.0f, 0.0f);
            Gl.glVertex3f(-20f, 0f, 0f);
            Gl.glVertex3f(0f, 0f, 0f);
            Gl.glColor3f(0.0f, 1.0f, 0.0f);
            Gl.glVertex3f(0f, 0f, 0f);
            Gl.glVertex3f(0f, -20f, 0f);
            Gl.glColor3f(0.0f, 0.0f, 1.0f);
            Gl.glVertex3f(0f, 0f, 0f);
            Gl.glVertex3f(0f, 0f, -20f);

            Gl.glEnd();
            Gl.glDisable(Gl.GL_LINE_STIPPLE);
        }

        /// <summary>
        /// функция рисования равнобедренного прямоугольного треугольника
        /// </summary>
        /// <param name="size">длина катета</param>
        private void DrawTriangle(float size)
        {
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor3f(1.0f, 1.0f, 0.0f);

            Gl.glVertex3f(0f, 0f, 0f);
            Gl.glVertex3f(size, 0f, 0f);
            Gl.glVertex3f(0f, size, 0f);

            Gl.glEnd();
        }

        /// <summary>
        /// Функция перевода полярных (сферических) координат в декартовые
        /// </summary>
        private void PolarToDecart()
        {
            phi *= Math.PI/180;
            theta *= Math.PI/180;

            x = r * Math.Sin(phi) * Math.Sin(theta);
            y = r * Math.Cos(theta);
            z = r * Math.Cos(phi) * Math.Sin(theta);
        }

        /// <summary>
        /// Функция перевода декартовых координат в полярные (сферические)
        /// </summary>
        private void DecartToPolar()
        {
            r = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
            phi = Math.Atan(x / z);
            theta = Math.Atan(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(z, 2)) / y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isDecart = !isDecart;

            SetInitialPosition();

            if (isDecart)
            {
                groupBox1.Visible = true;
                groupBox3.Visible = false;
                groupBox1.BringToFront();
            }
            else
            {
                groupBox3.Visible = true;
                groupBox1.Visible = false;
                groupBox3.BringToFront();
            }
        }

    }
}
