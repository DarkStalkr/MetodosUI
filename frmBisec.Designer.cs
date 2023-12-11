namespace MetodosUIVer3
{
    partial class frmBisec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBisec));
            label2 = new Label();
            pictureBox2 = new PictureBox();
            txtFuncion = new TextBox();
            txtIntervaloB = new TextBox();
            txtIntervaloA = new TextBox();
            txtNumeroIteraciones = new TextBox();
            btnCalcular = new Button();
            webView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            labelMenu2 = new Label();
            pnlMainBisec = new Panel();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            lblFuncion = new Label();
            panelTitle = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)webView2).BeginInit();
            pnlMainBisec.SuspendLayout();
            panelTitle.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Oswald Medium", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(388, 22);
            label2.Name = "label2";
            label2.Size = new Size(407, 80);
            label2.TabIndex = 5;
            label2.Text = "Método de Bisección\r\n";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(73, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(119, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // txtFuncion
            // 
            txtFuncion.Anchor = AnchorStyles.Top;
            txtFuncion.Location = new Point(205, 194);
            txtFuncion.Multiline = true;
            txtFuncion.Name = "txtFuncion";
            txtFuncion.Size = new Size(168, 35);
            txtFuncion.TabIndex = 1;
            txtFuncion.TextChanged += txtFuncion_TextChanged;
            // 
            // txtIntervaloB
            // 
            txtIntervaloB.Anchor = AnchorStyles.Top;
            txtIntervaloB.Location = new Point(614, 194);
            txtIntervaloB.Multiline = true;
            txtIntervaloB.Name = "txtIntervaloB";
            txtIntervaloB.Size = new Size(168, 35);
            txtIntervaloB.TabIndex = 3;
            txtIntervaloB.TextChanged += txtIntervaloB_TextChanged;
            // 
            // txtIntervaloA
            // 
            txtIntervaloA.Anchor = AnchorStyles.Top;
            txtIntervaloA.Location = new Point(403, 194);
            txtIntervaloA.Multiline = true;
            txtIntervaloA.Name = "txtIntervaloA";
            txtIntervaloA.Size = new Size(168, 35);
            txtIntervaloA.TabIndex = 2;
            txtIntervaloA.TextChanged += txtIntervaloA_TextChanged;
            // 
            // txtNumeroIteraciones
            // 
            txtNumeroIteraciones.Anchor = AnchorStyles.Top;
            txtNumeroIteraciones.Location = new Point(825, 194);
            txtNumeroIteraciones.Multiline = true;
            txtNumeroIteraciones.Name = "txtNumeroIteraciones";
            txtNumeroIteraciones.Size = new Size(168, 35);
            txtNumeroIteraciones.TabIndex = 10;
            txtNumeroIteraciones.TextChanged += txtNumeroIteraciones_TextChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.Anchor = AnchorStyles.Top;
            btnCalcular.AutoSize = true;
            btnCalcular.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCalcular.DialogResult = DialogResult.OK;
            btnCalcular.Font = new Font("Oswald ExtraLight", 12.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalcular.Location = new Point(544, 278);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 46);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular!";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click_1;
            // 
            // webView2
            // 
            webView2.AllowExternalDrop = true;
            webView2.Anchor = AnchorStyles.Top;
            webView2.CreationProperties = null;
            webView2.DefaultBackgroundColor = Color.White;
            webView2.Location = new Point(365, 446);
            webView2.Name = "webView2";
            webView2.Size = new Size(449, 130);
            webView2.TabIndex = 13;
            webView2.ZoomFactor = 1D;
            webView2.Click += webView2_Click;
            // 
            // labelMenu2
            // 
            labelMenu2.Anchor = AnchorStyles.None;
            labelMenu2.AutoSize = true;
            labelMenu2.BackColor = Color.White;
            labelMenu2.FlatStyle = FlatStyle.Flat;
            labelMenu2.Font = new Font("Oswald Light", 12.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            labelMenu2.ForeColor = Color.Black;
            labelMenu2.Location = new Point(98, 23);
            labelMenu2.Name = "labelMenu2";
            labelMenu2.Size = new Size(986, 74);
            labelMenu2.TabIndex = 14;
            labelMenu2.Text = resources.GetString("labelMenu2.Text");
            labelMenu2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlMainBisec
            // 
            pnlMainBisec.AutoSize = true;
            pnlMainBisec.Controls.Add(label4);
            pnlMainBisec.Controls.Add(label3);
            pnlMainBisec.Controls.Add(label1);
            pnlMainBisec.Controls.Add(lblFuncion);
            pnlMainBisec.Controls.Add(btnCalcular);
            pnlMainBisec.Controls.Add(txtIntervaloA);
            pnlMainBisec.Controls.Add(txtIntervaloB);
            pnlMainBisec.Controls.Add(txtNumeroIteraciones);
            pnlMainBisec.Controls.Add(webView2);
            pnlMainBisec.Controls.Add(txtFuncion);
            pnlMainBisec.Dock = DockStyle.Fill;
            pnlMainBisec.Location = new Point(0, 125);
            pnlMainBisec.Name = "pnlMainBisec";
            pnlMainBisec.Size = new Size(1182, 628);
            pnlMainBisec.TabIndex = 13;
            pnlMainBisec.Paint += panel2_Paint;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Oswald Light", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(836, 145);
            label4.Name = "label4";
            label4.Size = new Size(146, 29);
            label4.TabIndex = 17;
            label4.Text = "Numero de iteraciones:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Oswald Light", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(660, 145);
            label3.Name = "label3";
            label3.Size = new Size(77, 29);
            label3.TabIndex = 16;
            label3.Text = "Intervalo b:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Oswald Light", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(449, 145);
            label1.Name = "label1";
            label1.Size = new Size(77, 29);
            label1.TabIndex = 15;
            label1.Text = "Intervalo a:";
            // 
            // lblFuncion
            // 
            lblFuncion.Anchor = AnchorStyles.Top;
            lblFuncion.AutoSize = true;
            lblFuncion.Font = new Font("Oswald Light", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            lblFuncion.Location = new Point(230, 145);
            lblFuncion.Name = "lblFuncion";
            lblFuncion.Size = new Size(118, 29);
            lblFuncion.TabIndex = 14;
            lblFuncion.Text = "Ingrese la función:";
            // 
            // panelTitle
            // 
            panelTitle.Controls.Add(label2);
            panelTitle.Controls.Add(pictureBox2);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(0, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(1182, 125);
            panelTitle.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelMenu2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(1182, 125);
            panel2.TabIndex = 15;
            // 
            // frmBisec
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1182, 753);
            Controls.Add(panel2);
            Controls.Add(pnlMainBisec);
            Controls.Add(panelTitle);
            MinimumSize = new Size(1200, 800);
            Name = "frmBisec";
            Text = "frmBisec";
            Load += frmBisec_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)webView2).EndInit();
            pnlMainBisec.ResumeLayout(false);
            pnlMainBisec.PerformLayout();
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private PictureBox pictureBox2;
        private TextBox txtFuncion;
        private TextBox txtIntervaloB;
        private TextBox txtIntervaloA;
        private TextBox txtNumeroIteraciones;
        private Button btnCalcular;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView2;
        private Label labelMenu2;
        private Panel pnlMainBisec;
        private Panel panelTitle;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label lblFuncion;
    }
}