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
            labelMenu2 = new Label();
            labelMenu3 = new Label();
            pnlDegradadoMenu = new Panel();
            panelMain = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pnlDegradadoMenu.SuspendLayout();
            panelMain.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelMenu1
            // 
            labelMenu1.Anchor = AnchorStyles.Top;
            labelMenu1.AutoSize = true;
            labelMenu1.BackColor = Color.FromArgb(0, 0, 0, 0);
            labelMenu1.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelMenu1.ForeColor = Color.White;
            labelMenu1.Location = new Point(271, 15);
            labelMenu1.Name = "labelMenu1";
            labelMenu1.Size = new Size(544, 44);
            labelMenu1.TabIndex = 0;
            labelMenu1.Text = "Proyecto Métodos Numéricos";
            // 
            // labelMenu2
            // 
            labelMenu2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            labelMenu2.AutoSize = true;
            labelMenu2.BackColor = Color.FromArgb(0, 0, 0, 0);
            labelMenu2.FlatStyle = FlatStyle.Flat;
            labelMenu2.Font = new Font("Microsoft Sans Serif", 12.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            labelMenu2.ForeColor = Color.White;
            labelMenu2.Location = new Point(157, 86);
            labelMenu2.Name = "labelMenu2";
            labelMenu2.Size = new Size(900, 66);
            labelMenu2.TabIndex = 3;
            labelMenu2.Text = "Esta calculadora está diseñada para abordar problemas matemáticos mediante métodos numéricos avanzados. \r\nAlgunas de las capacidades clave incluyen:\r\n\r\n";
            // 
            // labelMenu3
            // 
            labelMenu3.Anchor = AnchorStyles.Top;
            labelMenu3.AutoSize = true;
            labelMenu3.BackColor = Color.FromArgb(0, 0, 0, 0);
            labelMenu3.Font = new Font("Microsoft Sans Serif", 14.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelMenu3.ForeColor = Color.White;
            labelMenu3.Location = new Point(45, 65);
            labelMenu3.Name = "labelMenu3";
            labelMenu3.Size = new Size(1023, 144);
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
            pnlDegradadoMenu.Margin = new Padding(3, 2, 3, 2);
            pnlDegradadoMenu.Name = "pnlDegradadoMenu";
            pnlDegradadoMenu.Size = new Size(1034, 565);
            pnlDegradadoMenu.TabIndex = 5;
            pnlDegradadoMenu.Paint += panel1_Paint;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(0, 0, 0, 0);
            panelMain.Controls.Add(labelMenu3);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 172);
            panelMain.Margin = new Padding(3, 2, 3, 2);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1034, 393);
            panelMain.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 0, 0);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(labelMenu2);
            panel1.Controls.Add(labelMenu1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1034, 172);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pngegg;
            pictureBox1.Location = new Point(45, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // menuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 0, 43);
            ClientSize = new Size(1034, 565);
            Controls.Add(pnlDegradadoMenu);
            Margin = new Padding(3, 2, 3, 2);
            Name = "menuForm";
            Text = "menuFrm";
            Load += menuForm_Load;
            pnlDegradadoMenu.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMenu1;
        private Label labelMenu2;
        private Label labelMenu3;
        private Panel pnlDegradadoMenu;
        private Panel panel1;
        private Panel panelMain;
        private PictureBox pictureBox1;
    }
}