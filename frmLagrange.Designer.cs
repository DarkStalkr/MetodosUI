namespace MetodosUIVer3
{
    partial class frmLagrange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLagrange));
            label6 = new Label();
            panelTitle = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dgvPuntos = new DataGridView();
            btnCalcular = new Button();
            webView1 = new Microsoft.Web.WebView2.WinForms.WebView2();
            plotView1 = new OxyPlot.WindowsForms.PlotView();
            lblPuntos = new Label();
            panel1 = new Panel();
            panelMain = new Panel();
            panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPuntos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)webView1).BeginInit();
            panel1.SuspendLayout();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Oswald Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(84, 3);
            label6.Name = "label6";
            label6.Size = new Size(1215, 156);
            label6.TabIndex = 14;
            label6.Text = resources.GetString("label6.Text");
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTitle
            // 
            panelTitle.Controls.Add(pictureBox1);
            panelTitle.Controls.Add(label1);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(0, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(1382, 125);
            panelTitle.TabIndex = 13;
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
            label1.Size = new Size(681, 80);
            label1.TabIndex = 0;
            label1.Text = "Polinomio Interpolador de LaGrange";
            // 
            // dgvPuntos
            // 
            dgvPuntos.Anchor = AnchorStyles.Left;
            dgvPuntos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPuntos.Location = new Point(60, 100);
            dgvPuntos.Name = "dgvPuntos";
            dgvPuntos.RowHeadersWidth = 51;
            dgvPuntos.RowTemplate.Height = 29;
            dgvPuntos.Size = new Size(300, 188);
            dgvPuntos.TabIndex = 15;
            // 
            // btnCalcular
            // 
            btnCalcular.Anchor = AnchorStyles.Left;
            btnCalcular.Font = new Font("Oswald Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalcular.Location = new Point(138, 317);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(145, 37);
            btnCalcular.TabIndex = 16;
            btnCalcular.Text = "Calcular!";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // webView1
            // 
            webView1.AllowExternalDrop = true;
            webView1.Anchor = AnchorStyles.None;
            webView1.CreationProperties = null;
            webView1.DefaultBackgroundColor = Color.White;
            webView1.Location = new Point(433, 44);
            webView1.Name = "webView1";
            webView1.Size = new Size(866, 96);
            webView1.TabIndex = 18;
            webView1.ZoomFactor = 1D;
            // 
            // plotView1
            // 
            plotView1.Anchor = AnchorStyles.None;
            plotView1.BackColor = Color.White;
            plotView1.Location = new Point(590, 219);
            plotView1.Name = "plotView1";
            plotView1.PanCursor = Cursors.Hand;
            plotView1.Size = new Size(553, 332);
            plotView1.TabIndex = 19;
            plotView1.Text = "plotView1";
            plotView1.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView1.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView1.ZoomVerticalCursor = Cursors.SizeNS;
            plotView1.Click += plotView1_Click;
            // 
            // lblPuntos
            // 
            lblPuntos.Anchor = AnchorStyles.Left;
            lblPuntos.AutoSize = true;
            lblPuntos.Font = new Font("Oswald Light", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            lblPuntos.Location = new Point(138, 44);
            lblPuntos.Name = "lblPuntos";
            lblPuntos.Size = new Size(120, 29);
            lblPuntos.TabIndex = 20;
            lblPuntos.Text = "Ingrese los puntos:";
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 125);
            panel1.Name = "panel1";
            panel1.Size = new Size(1382, 177);
            panel1.TabIndex = 21;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(plotView1);
            panelMain.Controls.Add(btnCalcular);
            panelMain.Controls.Add(webView1);
            panelMain.Controls.Add(lblPuntos);
            panelMain.Controls.Add(dgvPuntos);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 302);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1382, 651);
            panelMain.TabIndex = 22;
            panelMain.Paint += panelMain_Paint;
            // 
            // frmLagrange
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1382, 953);
            Controls.Add(panelMain);
            Controls.Add(panel1);
            Controls.Add(panelTitle);
            Name = "frmLagrange";
            Text = "frmLagrange";
            Load += frmLagrange_Load;
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPuntos).EndInit();
            ((System.ComponentModel.ISupportInitialize)webView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label6;
        private Panel panelTitle;
        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dgvPuntos;
        private Button btnCalcular;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView1;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private Label lblPuntos;
        private Panel panel1;
        private Panel panelMain;
    }
}