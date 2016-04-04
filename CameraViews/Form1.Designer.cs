namespace FigureRotate
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AnT = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.lblX = new System.Windows.Forms.Label();
            this.lblZ = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.updownX = new System.Windows.Forms.NumericUpDown();
            this.updownZ = new System.Windows.Forms.NumericUpDown();
            this.updownY = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblZP = new System.Windows.Forms.Label();
            this.lblYP = new System.Windows.Forms.Label();
            this.lblXP = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.updownTheta = new System.Windows.Forms.NumericUpDown();
            this.updownPhi = new System.Windows.Forms.NumericUpDown();
            this.updownRo = new System.Windows.Forms.NumericUpDown();
            this.lblPhi = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblTheta = new System.Windows.Forms.Label();
            this.lblRo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.updownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownY)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownTheta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownRo)).BeginInit();
            this.SuspendLayout();
            // 
            // AnT
            // 
            this.AnT.AccumBits = ((byte)(0));
            this.AnT.AutoCheckErrors = false;
            this.AnT.AutoFinish = false;
            this.AnT.AutoMakeCurrent = true;
            this.AnT.AutoSwapBuffers = true;
            this.AnT.BackColor = System.Drawing.Color.White;
            this.AnT.ColorBits = ((byte)(32));
            this.AnT.DepthBits = ((byte)(16));
            this.AnT.Dock = System.Windows.Forms.DockStyle.Left;
            this.AnT.Location = new System.Drawing.Point(0, 0);
            this.AnT.Name = "AnT";
            this.AnT.Size = new System.Drawing.Size(436, 378);
            this.AnT.StencilBits = ((byte)(0));
            this.AnT.TabIndex = 0;
            this.AnT.Paint += new System.Windows.Forms.PaintEventHandler(this.AnT_Paint);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.ForeColor = System.Drawing.Color.Red;
            this.lblX.Location = new System.Drawing.Point(6, 27);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 13);
            this.lblX.TabIndex = 5;
            this.lblX.Text = "X";
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.ForeColor = System.Drawing.Color.Blue;
            this.lblZ.Location = new System.Drawing.Point(6, 96);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(14, 13);
            this.lblZ.TabIndex = 6;
            this.lblZ.Text = "Z";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.ForeColor = System.Drawing.Color.Lime;
            this.lblY.Location = new System.Drawing.Point(6, 60);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(14, 13);
            this.lblY.TabIndex = 7;
            this.lblY.Text = "Y";
            // 
            // updownX
            // 
            this.updownX.DecimalPlaces = 1;
            this.updownX.Location = new System.Drawing.Point(26, 25);
            this.updownX.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.updownX.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.updownX.Name = "updownX";
            this.updownX.Size = new System.Drawing.Size(55, 20);
            this.updownX.TabIndex = 8;
            this.updownX.ValueChanged += new System.EventHandler(this.updownX_ValueChanged);
            // 
            // updownZ
            // 
            this.updownZ.DecimalPlaces = 1;
            this.updownZ.Location = new System.Drawing.Point(26, 94);
            this.updownZ.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.updownZ.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.updownZ.Name = "updownZ";
            this.updownZ.Size = new System.Drawing.Size(55, 20);
            this.updownZ.TabIndex = 9;
            this.updownZ.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updownZ.ValueChanged += new System.EventHandler(this.updownZ_ValueChanged);
            // 
            // updownY
            // 
            this.updownY.DecimalPlaces = 1;
            this.updownY.Location = new System.Drawing.Point(26, 58);
            this.updownY.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.updownY.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.updownY.Name = "updownY";
            this.updownY.Size = new System.Drawing.Size(55, 20);
            this.updownY.TabIndex = 10;
            this.updownY.ValueChanged += new System.EventHandler(this.updownY_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.lblPhi);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.lblTheta);
            this.groupBox1.Controls.Add(this.lblRo);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblX);
            this.groupBox1.Controls.Add(this.lblZ);
            this.groupBox1.Controls.Add(this.lblY);
            this.groupBox1.Controls.Add(this.updownZ);
            this.groupBox1.Controls.Add(this.updownY);
            this.groupBox1.Controls.Add(this.updownX);
            this.groupBox1.Location = new System.Drawing.Point(442, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 132);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Декартовы координаты";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.lblZP);
            this.groupBox3.Controls.Add(this.lblYP);
            this.groupBox3.Controls.Add(this.lblXP);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.updownTheta);
            this.groupBox3.Controls.Add(this.updownPhi);
            this.groupBox3.Controls.Add(this.updownRo);
            this.groupBox3.Location = new System.Drawing.Point(451, 234);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 132);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Полярные координаты";
            this.groupBox3.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(120, 94);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(13, 13);
            this.label21.TabIndex = 25;
            this.label21.Text = "=";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(120, 60);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(13, 13);
            this.label20.TabIndex = 24;
            this.label20.Text = "=";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(120, 23);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(13, 13);
            this.label19.TabIndex = 23;
            this.label19.Text = "=";
            // 
            // lblZP
            // 
            this.lblZP.AutoSize = true;
            this.lblZP.Location = new System.Drawing.Point(139, 94);
            this.lblZP.Name = "lblZP";
            this.lblZP.Size = new System.Drawing.Size(13, 13);
            this.lblZP.TabIndex = 22;
            this.lblZP.Text = "0";
            // 
            // lblYP
            // 
            this.lblYP.AutoSize = true;
            this.lblYP.Location = new System.Drawing.Point(139, 60);
            this.lblYP.Name = "lblYP";
            this.lblYP.Size = new System.Drawing.Size(13, 13);
            this.lblYP.TabIndex = 21;
            this.lblYP.Text = "0";
            // 
            // lblXP
            // 
            this.lblXP.AutoSize = true;
            this.lblXP.Location = new System.Drawing.Point(139, 23);
            this.lblXP.Name = "lblXP";
            this.lblXP.Size = new System.Drawing.Size(13, 13);
            this.lblXP.TabIndex = 20;
            this.lblXP.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(105, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "Z";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(104, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Y";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(105, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "°";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "°";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "ρ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "θ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "φ";
            // 
            // updownTheta
            // 
            this.updownTheta.Location = new System.Drawing.Point(26, 94);
            this.updownTheta.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.updownTheta.Name = "updownTheta";
            this.updownTheta.Size = new System.Drawing.Size(55, 20);
            this.updownTheta.TabIndex = 9;
            this.updownTheta.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.updownTheta.ValueChanged += new System.EventHandler(this.updownTheta_ValueChanged);
            // 
            // updownPhi
            // 
            this.updownPhi.Location = new System.Drawing.Point(26, 58);
            this.updownPhi.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.updownPhi.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.updownPhi.Name = "updownPhi";
            this.updownPhi.Size = new System.Drawing.Size(55, 20);
            this.updownPhi.TabIndex = 10;
            this.updownPhi.ValueChanged += new System.EventHandler(this.updownPhi_ValueChanged);
            // 
            // updownRo
            // 
            this.updownRo.DecimalPlaces = 1;
            this.updownRo.Location = new System.Drawing.Point(26, 23);
            this.updownRo.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.updownRo.Name = "updownRo";
            this.updownRo.Size = new System.Drawing.Size(55, 20);
            this.updownRo.TabIndex = 8;
            this.updownRo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updownRo.ValueChanged += new System.EventHandler(this.updownRo_ValueChanged);
            // 
            // lblPhi
            // 
            this.lblPhi.AutoSize = true;
            this.lblPhi.Location = new System.Drawing.Point(139, 60);
            this.lblPhi.Name = "lblPhi";
            this.lblPhi.Size = new System.Drawing.Size(13, 13);
            this.lblPhi.TabIndex = 23;
            this.lblPhi.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(120, 96);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(13, 13);
            this.label18.TabIndex = 22;
            this.label18.Text = "=";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(120, 60);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "=";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(120, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "=";
            // 
            // lblTheta
            // 
            this.lblTheta.AutoSize = true;
            this.lblTheta.Location = new System.Drawing.Point(139, 96);
            this.lblTheta.Name = "lblTheta";
            this.lblTheta.Size = new System.Drawing.Size(13, 13);
            this.lblTheta.TabIndex = 19;
            this.lblTheta.Text = "0";
            // 
            // lblRo
            // 
            this.lblRo.AutoSize = true;
            this.lblRo.Location = new System.Drawing.Point(139, 27);
            this.lblRo.Name = "lblRo";
            this.lblRo.Size = new System.Drawing.Size(13, 13);
            this.lblRo.TabIndex = 17;
            this.lblRo.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(171, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "°";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(171, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "°";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(105, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "θ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(103, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "φ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(105, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "ρ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(442, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "Перейти в другую систему";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 378);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AnT);
            this.Name = "Form1";
            this.Text = "Движение камеры вокруг объекта";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownY)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownTheta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownRo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl AnT;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.NumericUpDown updownX;
        private System.Windows.Forms.NumericUpDown updownZ;
        private System.Windows.Forms.NumericUpDown updownY;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown updownTheta;
        private System.Windows.Forms.NumericUpDown updownPhi;
        private System.Windows.Forms.NumericUpDown updownRo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTheta;
        private System.Windows.Forms.Label lblRo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblZP;
        private System.Windows.Forms.Label lblYP;
        private System.Windows.Forms.Label lblXP;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblPhi;
        private System.Windows.Forms.Button button1;
    }
}

