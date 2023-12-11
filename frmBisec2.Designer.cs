namespace MetodosUIVer3
{
    partial class frmBisec2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBisec2));
            panel2 = new Panel();
            labelMenu2 = new Label();
            pnlMainBisec = new Panel();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            lblFuncion = new Label();
            btnCalcular = new Button();
            txtIntervaloA = new TextBox();
            txtIntervaloB = new TextBox();
            txtNumeroIteraciones = new TextBox();
            webView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            txtFuncion = new TextBox();
            panelTitle = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel2.SuspendLayout();
            pnlMainBisec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView2).BeginInit();
            panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(labelMenu2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 94);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1034, 94);
            panel2.TabIndex = 18;
            // 
            // labelMenu2
            // 
            labelMenu2.Anchor = AnchorStyles.None;
            labelMenu2.AutoSize = true;
            labelMenu2.BackColor = Color.White;
            labelMenu2.FlatStyle = FlatStyle.Flat;
            labelMenu2.Font = new Font("Microsoft Sans Serif", 12.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            labelMenu2.ForeColor = Color.Black;
            labelMenu2.Location = new Point(107, 14);
            labelMenu2.Name = "labelMenu2";
            labelMenu2.Size = new Size(1080, 44);
            labelMenu2.TabIndex = 14;
            labelMenu2.Text = resources.GetString("labelMenu2.Text");
            labelMenu2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlMainBisec
            // 
            pnlMainBisec.AutoSize = true;
            pnlMainBisec.BackColor = Color.White;
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
            pnlMainBisec.Location = new Point(0, 94);
            pnlMainBisec.Margin = new Padding(3, 2, 3, 2);
            pnlMainBisec.Name = "pnlMainBisec";
            pnlMainBisec.Size = new Size(1034, 621);
            pnlMainBisec.TabIndex = 16;
            pnlMainBisec.Paint += pnlMainBisec_Paint;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1150, 109);
            label4.Name = "label4";
            label4.Size = new Size(155, 17);
            label4.TabIndex = 17;
            label4.Text = "Numero de iteraciones:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(656, 108);
            label3.Name = "label3";
            label3.Size = new Size(78, 17);
            label3.TabIndex = 16;
            label3.Text = "Intervalo b:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(471, 108);
            label1.Name = "label1";
            label1.Size = new Size(78, 17);
            label1.TabIndex = 15;
            label1.Text = "Intervalo a:";
            // 
            // lblFuncion
            // 
            lblFuncion.Anchor = AnchorStyles.Top;
            lblFuncion.AutoSize = true;
            lblFuncion.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            lblFuncion.Location = new Point(279, 108);
            lblFuncion.Name = "lblFuncion";
            lblFuncion.Size = new Size(124, 17);
            lblFuncion.TabIndex = 14;
            lblFuncion.Text = "Ingrese la función:";
            // 
            // btnCalcular
            // 
            btnCalcular.Anchor = AnchorStyles.Top;
            btnCalcular.AutoSize = true;
            btnCalcular.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCalcular.DialogResult = DialogResult.OK;
            btnCalcular.Font = new Font("Microsoft Sans Serif", 12.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalcular.Location = new Point(478, 217);
            btnCalcular.Margin = new Padding(3, 2, 3, 2);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(86, 30);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular!";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtIntervaloA
            // 
            txtIntervaloA.Anchor = AnchorStyles.Top;
            txtIntervaloA.Location = new Point(431, 145);
            txtIntervaloA.Margin = new Padding(3, 2, 3, 2);
            txtIntervaloA.Multiline = true;
            txtIntervaloA.Name = "txtIntervaloA";
            txtIntervaloA.Size = new Size(148, 27);
            txtIntervaloA.TabIndex = 2;
            txtIntervaloA.TextChanged += txtIntervaloA_TextChanged;
            // 
            // txtIntervaloB
            // 
            txtIntervaloB.Anchor = AnchorStyles.Top;
            txtIntervaloB.Location = new Point(615, 145);
            txtIntervaloB.Margin = new Padding(3, 2, 3, 2);
            txtIntervaloB.Multiline = true;
            txtIntervaloB.Name = "txtIntervaloB";
            txtIntervaloB.Size = new Size(148, 27);
            txtIntervaloB.TabIndex = 3;
            // 
            // txtNumeroIteraciones
            // 
            txtNumeroIteraciones.Anchor = AnchorStyles.Top;
            txtNumeroIteraciones.Location = new Point(1140, 146);
            txtNumeroIteraciones.Margin = new Padding(3, 2, 3, 2);
            txtNumeroIteraciones.Multiline = true;
            txtNumeroIteraciones.Name = "txtNumeroIteraciones";
            txtNumeroIteraciones.Size = new Size(148, 27);
            txtNumeroIteraciones.TabIndex = 10;
            // 
            // webView2
            // 
            webView2.AllowExternalDrop = true;
            webView2.Anchor = AnchorStyles.Top;
            webView2.CreationProperties = null;
            webView2.DefaultBackgroundColor = Color.White;
            webView2.Location = new Point(321, 346);
            webView2.Margin = new Padding(3, 2, 3, 2);
            webView2.Name = "webView2";
            webView2.Size = new Size(393, 98);
            webView2.TabIndex = 13;
            webView2.ZoomFactor = 1D;
            // 
            // txtFuncion
            // 
            txtFuncion.Anchor = AnchorStyles.Top;
            txtFuncion.Location = new Point(257, 145);
            txtFuncion.Margin = new Padding(3, 2, 3, 2);
            txtFuncion.Multiline = true;
            txtFuncion.Name = "txtFuncion";
            txtFuncion.Size = new Size(148, 27);
            txtFuncion.TabIndex = 1;
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.White;
            panelTitle.Controls.Add(label2);
            panelTitle.Controls.Add(pictureBox2);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(0, 0);
            panelTitle.Margin = new Padding(3, 2, 3, 2);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(1034, 94);
            panelTitle.TabIndex = 17;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(353, 13);
            label2.Name = "label2";
            label2.Size = new Size(390, 44);
            label2.TabIndex = 5;
            label2.Text = "Método de Bisección\r\n";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(64, 16);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(104, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // frmBisec2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 715);
            Controls.Add(panel2);
            Controls.Add(pnlMainBisec);
            Controls.Add(panelTitle);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmBisec2";
            Text = "frmBisec2";
            Load += frmBisec2_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlMainBisec.ResumeLayout(false);
            pnlMainBisec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)webView2).EndInit();
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label labelMenu2;
        private Panel pnlMainBisec;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label lblFuncion;
        private Button btnCalcular;
        private TextBox txtIntervaloA;
        private TextBox txtIntervaloB;
        private TextBox txtNumeroIteraciones;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView2;
        private TextBox txtFuncion;
        private Panel panelTitle;
        private Label label2;
        private PictureBox pictureBox2;
    }
}