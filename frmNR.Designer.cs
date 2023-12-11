namespace MetodosUIVer3
{
    partial class frmNR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNR));
            label2 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtEstimacionInicial = new TextBox();
            txtNumeroIteraciones = new TextBox();
            btnCalcular = new Button();
            txtFuncion = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
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
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Oswald Light", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(792, 19);
            label2.Name = "label2";
            label2.Size = new Size(365, 62);
            label2.TabIndex = 5;
            label2.Text = "Nota: Introducir operador '*' entre el coeficiente y variable.\r\ne.g: 2x = 2*x\r\n";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1182, 125);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
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
            label1.Location = new Point(424, 26);
            label1.Name = "label1";
            label1.Size = new Size(335, 80);
            label1.TabIndex = 0;
            label1.Text = "Newton-Raphson";
            label1.Click += label1_Click;
            // 
            // txtEstimacionInicial
            // 
            txtEstimacionInicial.Anchor = AnchorStyles.Top;
            txtEstimacionInicial.Location = new Point(496, 138);
            txtEstimacionInicial.Multiline = true;
            txtEstimacionInicial.Name = "txtEstimacionInicial";
            txtEstimacionInicial.Size = new Size(190, 35);
            txtEstimacionInicial.TabIndex = 1;
            txtEstimacionInicial.TextChanged += txtEstimacionInicial_TextChanged;
            // 
            // txtNumeroIteraciones
            // 
            txtNumeroIteraciones.Anchor = AnchorStyles.Top;
            txtNumeroIteraciones.Location = new Point(496, 226);
            txtNumeroIteraciones.Multiline = true;
            txtNumeroIteraciones.Name = "txtNumeroIteraciones";
            txtNumeroIteraciones.Size = new Size(190, 35);
            txtNumeroIteraciones.TabIndex = 2;
            txtNumeroIteraciones.TextChanged += txtNumeroIteraciones_TextChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.Anchor = AnchorStyles.Top;
            btnCalcular.Font = new Font("Oswald ExtraLight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalcular.Location = new Point(496, 285);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(190, 45);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular!";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtFuncion
            // 
            txtFuncion.Anchor = AnchorStyles.Top;
            txtFuncion.Location = new Point(496, 46);
            txtFuncion.Multiline = true;
            txtFuncion.Name = "txtFuncion";
            txtFuncion.Size = new Size(190, 35);
            txtFuncion.TabIndex = 4;
            txtFuncion.TextChanged += txtFuncion_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Oswald Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(522, 9);
            label3.Name = "label3";
            label3.Size = new Size(138, 35);
            label3.TabIndex = 6;
            label3.Text = "Ingresa la función:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Oswald Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(542, 99);
            label4.Name = "label4";
            label4.Size = new Size(98, 35);
            label4.TabIndex = 7;
            label4.Text = "Valor inicial:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Oswald Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(506, 189);
            label5.Name = "label5";
            label5.Size = new Size(171, 35);
            label5.TabIndex = 8;
            label5.Text = "Número de Iteraciones:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Oswald Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(230, 23);
            label6.Name = "label6";
            label6.Size = new Size(723, 78);
            label6.TabIndex = 10;
            label6.Text = "El método de Newton-Raphson, también conocido como método de Newton, \r\nes un algoritmo iterativo utilizado para encontrar raíces de funciones reales diferenciables. ";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelAbout
            // 
            panelAbout.Controls.Add(label6);
            panelAbout.Dock = DockStyle.Top;
            panelAbout.Location = new Point(0, 125);
            panelAbout.Name = "panelAbout";
            panelAbout.Size = new Size(1182, 125);
            panelAbout.TabIndex = 10;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(webView2);
            panelMain.Controls.Add(txtNumeroIteraciones);
            panelMain.Controls.Add(label2);
            panelMain.Controls.Add(label5);
            panelMain.Controls.Add(btnCalcular);
            panelMain.Controls.Add(txtEstimacionInicial);
            panelMain.Controls.Add(label4);
            panelMain.Controls.Add(txtFuncion);
            panelMain.Controls.Add(label3);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 250);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1182, 503);
            panelMain.TabIndex = 11;
            panelMain.Paint += panelMain_Paint;
            // 
            // webView2
            // 
            webView2.AllowExternalDrop = true;
            webView2.Anchor = AnchorStyles.None;
            webView2.CreationProperties = null;
            webView2.DefaultBackgroundColor = Color.White;
            webView2.Location = new Point(346, 336);
            webView2.Name = "webView2";
            webView2.Size = new Size(477, 129);
            webView2.TabIndex = 9;
            webView2.ZoomFactor = 1D;
            // 
            // frmNR
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1182, 753);
            Controls.Add(panelMain);
            Controls.Add(panelAbout);
            Controls.Add(panel1);
            Name = "frmNR";
            Text = "frmNR";
            Load += frmNR_Load;
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
        private EventHandler frmNR_TextChanged;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private TextBox txtEstimacionInicial;
        private TextBox txtNumeroIteraciones;
        private Button btnCalcular;
        private TextBox txtFuncion;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label6;
        private Panel panelAbout;
        private Panel panelMain;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView2;
    }
}