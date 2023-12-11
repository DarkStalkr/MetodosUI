namespace MetodosUIVer3
{
    partial class Form1
    {

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            pictureBox4 = new PictureBox();
            panelCalcSubMenu = new Panel();
            buttonCalc6 = new Button();
            buttonCalc2 = new Button();
            buttonCalc5 = new Button();
            buttonCalc1 = new Button();
            buttonCalc4 = new Button();
            buttonCalc3 = new Button();
            buttonCalc = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            buttonMenu = new Button();
            buttonAbout = new Button();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panelTitleBar = new Panel();
            lblTitle = new Label();
            PnlFormLoader = new Panel();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panelCalcSubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(31, 13, 28);
            panelMenu.Controls.Add(pictureBox4);
            panelMenu.Controls.Add(panelCalcSubMenu);
            panelMenu.Controls.Add(buttonCalc);
            panelMenu.Controls.Add(pictureBox3);
            panelMenu.Controls.Add(pictureBox2);
            panelMenu.Controls.Add(buttonMenu);
            panelMenu.Controls.Add(buttonAbout);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(224, 753);
            panelMenu.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox4.Image = Properties.Resources.calculator;
            pictureBox4.Location = new Point(3, 239);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 45);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // panelCalcSubMenu
            // 
            panelCalcSubMenu.BackColor = Color.FromArgb(71, 31, 65);
            panelCalcSubMenu.Controls.Add(buttonCalc6);
            panelCalcSubMenu.Controls.Add(buttonCalc2);
            panelCalcSubMenu.Controls.Add(buttonCalc5);
            panelCalcSubMenu.Controls.Add(buttonCalc1);
            panelCalcSubMenu.Controls.Add(buttonCalc4);
            panelCalcSubMenu.Controls.Add(buttonCalc3);
            panelCalcSubMenu.Dock = DockStyle.Top;
            panelCalcSubMenu.Location = new Point(0, 305);
            panelCalcSubMenu.Name = "panelCalcSubMenu";
            panelCalcSubMenu.Size = new Size(224, 326);
            panelCalcSubMenu.TabIndex = 5;
            panelCalcSubMenu.Paint += panel2_Paint_1;
            // 
            // buttonCalc6
            // 
            buttonCalc6.BackColor = Color.FromArgb(56, 24, 51);
            buttonCalc6.FlatAppearance.BorderSize = 0;
            buttonCalc6.FlatStyle = FlatStyle.Flat;
            buttonCalc6.Font = new Font("Oswald Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCalc6.ForeColor = Color.White;
            buttonCalc6.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCalc6.Location = new Point(0, 272);
            buttonCalc6.Name = "buttonCalc6";
            buttonCalc6.Size = new Size(224, 41);
            buttonCalc6.TabIndex = 10;
            buttonCalc6.Text = "Polinomio de LaGrange";
            buttonCalc6.UseVisualStyleBackColor = false;
            buttonCalc6.Click += buttonCalc6_Click;
            // 
            // buttonCalc2
            // 
            buttonCalc2.BackColor = Color.FromArgb(56, 24, 51);
            buttonCalc2.FlatAppearance.BorderSize = 0;
            buttonCalc2.FlatStyle = FlatStyle.Flat;
            buttonCalc2.Font = new Font("Oswald Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCalc2.ForeColor = Color.White;
            buttonCalc2.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCalc2.Location = new Point(0, 50);
            buttonCalc2.Name = "buttonCalc2";
            buttonCalc2.Size = new Size(224, 41);
            buttonCalc2.TabIndex = 6;
            buttonCalc2.Text = "Punto Fijo";
            buttonCalc2.UseVisualStyleBackColor = false;
            buttonCalc2.Click += buttonCalc2_Click;
            // 
            // buttonCalc5
            // 
            buttonCalc5.BackColor = Color.FromArgb(56, 24, 51);
            buttonCalc5.FlatAppearance.BorderSize = 0;
            buttonCalc5.FlatStyle = FlatStyle.Flat;
            buttonCalc5.Font = new Font("Oswald Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCalc5.ForeColor = Color.White;
            buttonCalc5.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCalc5.Location = new Point(0, 225);
            buttonCalc5.Name = "buttonCalc5";
            buttonCalc5.Size = new Size(224, 41);
            buttonCalc5.TabIndex = 9;
            buttonCalc5.Text = "Interpolación Cuadrática";
            buttonCalc5.UseVisualStyleBackColor = false;
            buttonCalc5.Click += buttonCalc5_Click;
            // 
            // buttonCalc1
            // 
            buttonCalc1.BackColor = Color.FromArgb(56, 24, 51);
            buttonCalc1.FlatAppearance.BorderSize = 0;
            buttonCalc1.FlatStyle = FlatStyle.Flat;
            buttonCalc1.Font = new Font("Oswald Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCalc1.ForeColor = Color.White;
            buttonCalc1.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCalc1.Location = new Point(0, 3);
            buttonCalc1.Name = "buttonCalc1";
            buttonCalc1.Size = new Size(224, 41);
            buttonCalc1.TabIndex = 5;
            buttonCalc1.Text = "Bisección";
            buttonCalc1.UseVisualStyleBackColor = false;
            buttonCalc1.Click += buttonCalc1_Click;
            // 
            // buttonCalc4
            // 
            buttonCalc4.BackColor = Color.FromArgb(56, 24, 51);
            buttonCalc4.FlatAppearance.BorderSize = 0;
            buttonCalc4.FlatStyle = FlatStyle.Flat;
            buttonCalc4.Font = new Font("Oswald Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCalc4.ForeColor = Color.White;
            buttonCalc4.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCalc4.Location = new Point(0, 178);
            buttonCalc4.Name = "buttonCalc4";
            buttonCalc4.Size = new Size(224, 41);
            buttonCalc4.TabIndex = 8;
            buttonCalc4.Text = "Interpolación Lineal";
            buttonCalc4.UseVisualStyleBackColor = false;
            buttonCalc4.Click += buttonCalc4_Click;
            // 
            // buttonCalc3
            // 
            buttonCalc3.BackColor = Color.FromArgb(56, 24, 51);
            buttonCalc3.FlatAppearance.BorderSize = 0;
            buttonCalc3.FlatStyle = FlatStyle.Flat;
            buttonCalc3.Font = new Font("Oswald Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCalc3.ForeColor = Color.White;
            buttonCalc3.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCalc3.Location = new Point(0, 97);
            buttonCalc3.Name = "buttonCalc3";
            buttonCalc3.Size = new Size(224, 41);
            buttonCalc3.TabIndex = 7;
            buttonCalc3.Text = "Newton-Raphson";
            buttonCalc3.UseVisualStyleBackColor = false;
            buttonCalc3.Click += buttonCalc3_Click;
            // 
            // buttonCalc
            // 
            buttonCalc.Dock = DockStyle.Top;
            buttonCalc.FlatAppearance.BorderSize = 0;
            buttonCalc.FlatStyle = FlatStyle.Flat;
            buttonCalc.Font = new Font("Oswald", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCalc.ForeColor = Color.White;
            buttonCalc.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCalc.Location = new Point(0, 215);
            buttonCalc.Name = "buttonCalc";
            buttonCalc.Size = new Size(224, 90);
            buttonCalc.TabIndex = 2;
            buttonCalc.Text = "Calculadora";
            buttonCalc.UseVisualStyleBackColor = true;
            buttonCalc.Click += buttonCalc_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox3.Image = Properties.Resources.calculator;
            pictureBox3.Location = new Point(3, 239);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(47, 59);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox2.Image = Properties.Resources.hogar;
            pictureBox2.Location = new Point(3, 141);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(68, 65);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // buttonMenu
            // 
            buttonMenu.Dock = DockStyle.Top;
            buttonMenu.FlatAppearance.BorderSize = 0;
            buttonMenu.FlatStyle = FlatStyle.Flat;
            buttonMenu.Font = new Font("Oswald", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMenu.ForeColor = Color.White;
            buttonMenu.ImageAlign = ContentAlignment.MiddleLeft;
            buttonMenu.Location = new Point(0, 125);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Size = new Size(224, 90);
            buttonMenu.TabIndex = 2;
            buttonMenu.Text = "Menú";
            buttonMenu.UseVisualStyleBackColor = true;
            buttonMenu.Click += buttonMenu_Click_1;
            // 
            // buttonAbout
            // 
            buttonAbout.Dock = DockStyle.Bottom;
            buttonAbout.FlatAppearance.BorderSize = 0;
            buttonAbout.FlatStyle = FlatStyle.Flat;
            buttonAbout.Font = new Font("Oswald", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAbout.ForeColor = Color.White;
            buttonAbout.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAbout.Location = new Point(0, 663);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new Size(224, 90);
            buttonAbout.TabIndex = 2;
            buttonAbout.Text = "Acerca de:";
            buttonAbout.UseVisualStyleBackColor = true;
            buttonAbout.Click += buttonAbout_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(224, 125);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.Font = new Font("Oswald Light", 12.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(61, 77);
            label1.Name = "label1";
            label1.Size = new Size(97, 36);
            label1.TabIndex = 1;
            label1.Text = "Bienvenido!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.loginlogo;
            pictureBox1.Location = new Point(50, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(66, 18, 66);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(224, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1158, 74);
            panelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Oswald Light", 12.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(22, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(55, 36);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Menú";
            lblTitle.Click += lblTitle_Click;
            // 
            // PnlFormLoader
            // 
            PnlFormLoader.BackColor = Color.FromArgb(43, 0, 43);
            PnlFormLoader.Dock = DockStyle.Fill;
            PnlFormLoader.Location = new Point(224, 74);
            PnlFormLoader.Name = "PnlFormLoader";
            PnlFormLoader.Size = new Size(1158, 679);
            PnlFormLoader.TabIndex = 2;
            PnlFormLoader.Paint += panelDesktop_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(64, 0, 64);
            ClientSize = new Size(1382, 753);
            Controls.Add(PnlFormLoader);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            MinimumSize = new Size(1400, 800);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Metodos UI";
            Load += Form1_Load_1;
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panelCalcSubMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private Panel panelMenu;
        private Panel panelTitleBar;
        private Panel PnlFormLoader;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button buttonCalc;
        private Button buttonMenu;
        private Label lblTitle;
        private Button buttonAbout;
        private Button buttonCalc2;
        private Button buttonCalc1;
        private Button buttonCalc3;
        private Button buttonCalc6;
        private Button buttonCalc5;
        private Button buttonCalc4;
        private Panel panelCalcSubMenu;
        private PictureBox pictureBox4;
    }
}