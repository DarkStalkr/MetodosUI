namespace MetodosUIVer3
{
    partial class frmInterCuadratica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInterCuadratica));
            label6 = new Label();
            panelTitle = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dgvPuntos = new DataGridView();
            btnCalcular = new Button();
            panelAbout = new Panel();
            panelMain = new Panel();
            panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPuntos).BeginInit();
            panelAbout.SuspendLayout();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Oswald Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(18, 23);
            label6.Name = "label6";
            label6.Size = new Size(1147, 78);
            label6.TabIndex = 12;
            label6.Text = resources.GetString("label6.Text");
            label6.TextAlign = ContentAlignment.TopCenter;
            label6.Click += label6_Click;
            // 
            // panelTitle
            // 
            panelTitle.Controls.Add(pictureBox1);
            panelTitle.Controls.Add(label1);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(0, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(1182, 125);
            panelTitle.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Oswald Medium", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(351, 26);
            label1.Name = "label1";
            label1.Size = new Size(480, 80);
            label1.TabIndex = 0;
            label1.Text = "Interpolación Cuadrática";
            // 
            // dgvPuntos
            // 
            dgvPuntos.AllowUserToOrderColumns = true;
            dgvPuntos.Anchor = AnchorStyles.None;
            dgvPuntos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPuntos.Location = new Point(408, 22);
            dgvPuntos.Name = "dgvPuntos";
            dgvPuntos.RowHeadersWidth = 51;
            dgvPuntos.RowTemplate.Height = 29;
            dgvPuntos.Size = new Size(366, 217);
            dgvPuntos.TabIndex = 13;
            // 
            // btnCalcular
            // 
            btnCalcular.Anchor = AnchorStyles.None;
            btnCalcular.Font = new Font("Oswald Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalcular.Location = new Point(529, 398);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(124, 38);
            btnCalcular.TabIndex = 14;
            btnCalcular.Text = "Calcular!";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // panelAbout
            // 
            panelAbout.Controls.Add(label6);
            panelAbout.Dock = DockStyle.Top;
            panelAbout.Location = new Point(0, 125);
            panelAbout.Name = "panelAbout";
            panelAbout.Size = new Size(1182, 125);
            panelAbout.TabIndex = 15;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(dgvPuntos);
            panelMain.Controls.Add(btnCalcular);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 250);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1182, 503);
            panelMain.TabIndex = 16;
            // 
            // frmInterCuadratica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1182, 753);
            Controls.Add(panelMain);
            Controls.Add(panelAbout);
            Controls.Add(panelTitle);
            Name = "frmInterCuadratica";
            Text = "frmInterCuadratica";
            Load += frmInterCuadratica_Load;
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPuntos).EndInit();
            panelAbout.ResumeLayout(false);
            panelAbout.PerformLayout();
            panelMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label6;
        private Panel panelTitle;
        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dgvPuntos;
        private Button btnCalcular;
        private Panel panelAbout;
        private Panel panelMain;
    }
}