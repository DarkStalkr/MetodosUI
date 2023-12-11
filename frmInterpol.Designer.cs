namespace MetodosUIVer3
{
    partial class frmInterpol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInterpol));
            btnCalcular = new Button();
            labelMenu2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panelTitle = new Panel();
            pnlAbout = new Panel();
            dgvPuntos2 = new DataGridView();
            panelMain = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTitle.SuspendLayout();
            pnlAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPuntos2).BeginInit();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Anchor = AnchorStyles.None;
            btnCalcular.AutoSize = true;
            btnCalcular.Font = new Font("Oswald Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalcular.Location = new Point(529, 398);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(124, 38);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular!";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // labelMenu2
            // 
            labelMenu2.Anchor = AnchorStyles.None;
            labelMenu2.AutoSize = true;
            labelMenu2.BackColor = Color.White;
            labelMenu2.FlatStyle = FlatStyle.Flat;
            labelMenu2.Font = new Font("Oswald Light", 12.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            labelMenu2.ForeColor = Color.Black;
            labelMenu2.Location = new Point(126, 27);
            labelMenu2.Name = "labelMenu2";
            labelMenu2.Size = new Size(931, 74);
            labelMenu2.TabIndex = 15;
            labelMenu2.Text = resources.GetString("labelMenu2.Text");
            labelMenu2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Oswald Medium", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(395, 26);
            label1.Name = "label1";
            label1.Size = new Size(392, 80);
            label1.TabIndex = 0;
            label1.Text = "Interpolación Lineal";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.axis;
            pictureBox1.Location = new Point(30, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // panelTitle
            // 
            panelTitle.Controls.Add(pictureBox1);
            panelTitle.Controls.Add(label1);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(0, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(1182, 125);
            panelTitle.TabIndex = 10;
            // 
            // pnlAbout
            // 
            pnlAbout.Controls.Add(labelMenu2);
            pnlAbout.Dock = DockStyle.Top;
            pnlAbout.Location = new Point(0, 125);
            pnlAbout.Name = "pnlAbout";
            pnlAbout.Size = new Size(1182, 125);
            pnlAbout.TabIndex = 16;
            // 
            // dgvPuntos2
            // 
            dgvPuntos2.Anchor = AnchorStyles.None;
            dgvPuntos2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPuntos2.Location = new Point(408, 22);
            dgvPuntos2.Name = "dgvPuntos2";
            dgvPuntos2.RowHeadersWidth = 51;
            dgvPuntos2.RowTemplate.Height = 29;
            dgvPuntos2.Size = new Size(366, 217);
            dgvPuntos2.TabIndex = 12;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(dgvPuntos2);
            panelMain.Controls.Add(btnCalcular);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 250);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1182, 503);
            panelMain.TabIndex = 17;
            panelMain.Paint += panelMain_Paint;
            // 
            // frmInterpol
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1182, 753);
            Controls.Add(panelMain);
            Controls.Add(pnlAbout);
            Controls.Add(panelTitle);
            Name = "frmInterpol";
            Text = "frmInterpol";
            Load += frmInterpol_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            pnlAbout.ResumeLayout(false);
            pnlAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPuntos2).EndInit();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnCalcular;
        private Label labelMenu2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panelTitle;
        private Panel pnlAbout;
        private DataGridView dgvPuntos2;
        private Panel panelMain;
    }
}