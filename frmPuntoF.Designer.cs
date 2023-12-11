namespace MetodosUIVer3
{
    partial class frmPuntoF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPuntoF));
            label2 = new Label();
            txtFuncion = new TextBox();
            txtAproxInicial = new TextBox();
            txtNumeroIteraciones = new TextBox();
            btnCalcular = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            labelMenu2 = new Label();
            panelAbout = new Panel();
            panelMain = new Panel();
            webView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelAbout.SuspendLayout();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Oswald Medium", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(385, 26);
            label2.Name = "label2";
            label2.Size = new Size(413, 80);
            label2.TabIndex = 6;
            label2.Text = "Método de Punto Fijo";
            // 
            // txtFuncion
            // 
            txtFuncion.Anchor = AnchorStyles.Top;
            txtFuncion.Location = new Point(366, 89);
            txtFuncion.Multiline = true;
            txtFuncion.Name = "txtFuncion";
            txtFuncion.Size = new Size(125, 27);
            txtFuncion.TabIndex = 7;
            txtFuncion.TextChanged += txtFuncion_TextChanged;
            // 
            // txtAproxInicial
            // 
            txtAproxInicial.Anchor = AnchorStyles.Top;
            txtAproxInicial.Location = new Point(526, 88);
            txtAproxInicial.Multiline = true;
            txtAproxInicial.Name = "txtAproxInicial";
            txtAproxInicial.Size = new Size(125, 27);
            txtAproxInicial.TabIndex = 8;
            txtAproxInicial.TextChanged += txtAproxInicial_TextChanged;
            // 
            // txtNumeroIteraciones
            // 
            txtNumeroIteraciones.Anchor = AnchorStyles.Top;
            txtNumeroIteraciones.Location = new Point(686, 89);
            txtNumeroIteraciones.Multiline = true;
            txtNumeroIteraciones.Name = "txtNumeroIteraciones";
            txtNumeroIteraciones.Size = new Size(125, 27);
            txtNumeroIteraciones.TabIndex = 9;
            txtNumeroIteraciones.TextChanged += txtNumeroIteraciones_TextChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.Anchor = AnchorStyles.Top;
            btnCalcular.Font = new Font("Oswald ExtraLight", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalcular.Location = new Point(542, 166);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(99, 41);
            btnCalcular.TabIndex = 10;
            btnCalcular.Text = "Calcular!";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Oswald ExtraLight", 12.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(367, 20);
            label1.Name = "label1";
            label1.Size = new Size(122, 37);
            label1.TabIndex = 11;
            label1.Text = "Función: g(x)";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Oswald ExtraLight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(541, 20);
            label3.Name = "label3";
            label3.Size = new Size(105, 35);
            label3.TabIndex = 12;
            label3.Text = "Valor Incial:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Oswald ExtraLight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(698, 22);
            label4.Name = "label4";
            label4.Size = new Size(99, 35);
            label4.TabIndex = 13;
            label4.Text = "Iteraciones";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1182, 125);
            panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(32, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Oswald Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(411, 424);
            label5.Name = "label5";
            label5.Size = new Size(361, 70);
            label5.TabIndex = 15;
            label5.Text = "Nota: Usar operador de raíz cuadrada como: \"sqrt()\"\r\nFracciones: (x+y)/z";
            // 
            // labelMenu2
            // 
            labelMenu2.Anchor = AnchorStyles.None;
            labelMenu2.AutoSize = true;
            labelMenu2.BackColor = Color.White;
            labelMenu2.FlatStyle = FlatStyle.Flat;
            labelMenu2.Font = new Font("Oswald Light", 12.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            labelMenu2.ForeColor = Color.Black;
            labelMenu2.Location = new Point(183, 20);
            labelMenu2.Name = "labelMenu2";
            labelMenu2.Size = new Size(817, 74);
            labelMenu2.TabIndex = 16;
            labelMenu2.Text = "El método de punto fijo es un algoritmo iterativo utilizado para encontrar soluciones a ecuaciones de la forma:\r\nx=g(x), donde g(x), es una función dada.";
            labelMenu2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelAbout
            // 
            panelAbout.BackColor = Color.White;
            panelAbout.Controls.Add(labelMenu2);
            panelAbout.Dock = DockStyle.Top;
            panelAbout.Location = new Point(0, 125);
            panelAbout.Name = "panelAbout";
            panelAbout.Size = new Size(1182, 125);
            panelAbout.TabIndex = 17;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(webView2);
            panelMain.Controls.Add(label4);
            panelMain.Controls.Add(btnCalcular);
            panelMain.Controls.Add(txtNumeroIteraciones);
            panelMain.Controls.Add(label5);
            panelMain.Controls.Add(txtFuncion);
            panelMain.Controls.Add(label1);
            panelMain.Controls.Add(label3);
            panelMain.Controls.Add(txtAproxInicial);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 250);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1182, 503);
            panelMain.TabIndex = 18;
            panelMain.Paint += panelMain_Paint;
            // 
            // webView2
            // 
            webView2.AllowExternalDrop = true;
            webView2.Anchor = AnchorStyles.None;
            webView2.CreationProperties = null;
            webView2.DefaultBackgroundColor = Color.White;
            webView2.Location = new Point(276, 261);
            webView2.Name = "webView2";
            webView2.Size = new Size(630, 155);
            webView2.TabIndex = 16;
            webView2.ZoomFactor = 1D;
            // 
            // frmPuntoF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1182, 753);
            Controls.Add(panelMain);
            Controls.Add(panelAbout);
            Controls.Add(panel1);
            Name = "frmPuntoF";
            Text = "frmPuntoF";
            Load += frmPuntoF_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelAbout.ResumeLayout(false);
            panelAbout.PerformLayout();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)webView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private TextBox txtFuncion;
        private TextBox txtAproxInicial;
        private TextBox txtNumeroIteraciones;
        private Button btnCalcular;
        private Label label1;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Label label5;
        private PictureBox pictureBox1;
        private Label labelMenu2;
        private Panel panelAbout;
        private Panel panelMain;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView2;
    }
}