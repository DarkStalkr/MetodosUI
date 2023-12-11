namespace MetodosUIVer3
{
    partial class menuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuForm));
            labelMenu1 = new Label();
            pictureMenu1 = new PictureBox();
            pictureMenu2 = new PictureBox();
            labelMenu2 = new Label();
            labelMenu3 = new Label();
            pnlDegradadoMenu = new Panel();
            panelMain = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureMenu1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureMenu2).BeginInit();
            pnlDegradadoMenu.SuspendLayout();
            panelMain.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelMenu1
            // 
            labelMenu1.Anchor = AnchorStyles.Top;
            labelMenu1.AutoSize = true;
            labelMenu1.BackColor = Color.FromArgb(0, 0, 0, 0);
            labelMenu1.Font = new Font("Oswald Medium", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelMenu1.ForeColor = Color.White;
            labelMenu1.Location = new Point(310, 20);
            labelMenu1.Name = "labelMenu1";
            labelMenu1.Size = new Size(563, 80);
            labelMenu1.TabIndex = 0;
            labelMenu1.Text = "Proyecto Métodos Numéricos";
            // 
            // pictureMenu1
            // 
            pictureMenu1.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureMenu1.Image = Properties.Resources._683px_Escudo_UNAM_escalable_svg;
            pictureMenu1.Location = new Point(24, 20);
            pictureMenu1.Name = "pictureMenu1";
            pictureMenu1.Size = new Size(163, 139);
            pictureMenu1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureMenu1.TabIndex = 1;
            pictureMenu1.TabStop = false;
            // 
            // pictureMenu2
            // 
            pictureMenu2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureMenu2.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureMenu2.Image = (Image)resources.GetObject("pictureMenu2.Image");
            pictureMenu2.Location = new Point(997, 20);
            pictureMenu2.Name = "pictureMenu2";
            pictureMenu2.Size = new Size(163, 139);
            pictureMenu2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureMenu2.TabIndex = 2;
            pictureMenu2.TabStop = false;
            pictureMenu2.Click += pictureBox2_Click;
            // 
            // labelMenu2
            // 
            labelMenu2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            labelMenu2.AutoSize = true;
            labelMenu2.BackColor = Color.FromArgb(0, 0, 0, 0);
            labelMenu2.FlatStyle = FlatStyle.Flat;
            labelMenu2.Font = new Font("Oswald Light", 12.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            labelMenu2.ForeColor = Color.White;
            labelMenu2.Location = new Point(179, 115);
            labelMenu2.Name = "labelMenu2";
            labelMenu2.Size = new Size(824, 111);
            labelMenu2.TabIndex = 3;
            labelMenu2.Text = "Esta calculadora está diseñada para abordar problemas matemáticos mediante métodos numéricos avanzados. \r\nAlgunas de las capacidades clave incluyen:\r\n\r\n";
            // 
            // labelMenu3
            // 
            labelMenu3.Anchor = AnchorStyles.Top;
            labelMenu3.AutoSize = true;
            labelMenu3.BackColor = Color.FromArgb(0, 0, 0, 0);
            labelMenu3.Font = new Font("Oswald ExtraLight", 14.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelMenu3.ForeColor = Color.White;
            labelMenu3.Location = new Point(51, 87);
            labelMenu3.Name = "labelMenu3";
            labelMenu3.Size = new Size(1081, 246);
            labelMenu3.TabIndex = 4;
            labelMenu3.Text = resources.GetString("labelMenu3.Text");
            // 
            // pnlDegradadoMenu
            // 
            pnlDegradadoMenu.AutoSize = true;
            pnlDegradadoMenu.Controls.Add(panelMain);
            pnlDegradadoMenu.Controls.Add(panel1);
            pnlDegradadoMenu.Dock = DockStyle.Fill;
            pnlDegradadoMenu.Location = new Point(0, 0);
            pnlDegradadoMenu.Name = "pnlDegradadoMenu";
            pnlDegradadoMenu.Size = new Size(1182, 753);
            pnlDegradadoMenu.TabIndex = 5;
            pnlDegradadoMenu.Paint += panel1_Paint;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(0, 0, 0, 0);
            panelMain.Controls.Add(labelMenu3);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 230);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1182, 523);
            panelMain.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 0, 0);
            panel1.Controls.Add(labelMenu2);
            panel1.Controls.Add(pictureMenu2);
            panel1.Controls.Add(labelMenu1);
            panel1.Controls.Add(pictureMenu1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1182, 230);
            panel1.TabIndex = 5;
            // 
            // menuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 0, 43);
            ClientSize = new Size(1182, 753);
            Controls.Add(pnlDegradadoMenu);
            Name = "menuForm";
            Text = "menuFrm";
            Load += menuForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureMenu1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureMenu2).EndInit();
            pnlDegradadoMenu.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMenu1;
        private PictureBox pictureMenu1;
        private PictureBox pictureMenu2;
        private Label labelMenu2;
        private Label labelMenu3;
        private Panel pnlDegradadoMenu;
        private Panel panel1;
        private Panel panelMain;
    }
}