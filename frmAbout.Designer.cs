namespace MetodosUIVer3
{
    partial class frmAbout
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
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Oswald Light", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(266, 37);
            label1.Name = "label1";
            label1.Size = new Size(238, 48);
            label1.TabIndex = 0;
            label1.Text = "Proyecto realizado por:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Oswald Light", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(228, 96);
            label2.Name = "label2";
            label2.Size = new Size(331, 336);
            label2.TabIndex = 1;
            label2.Text = "Correa Silva Diego Domingo\r\nRodríguez Hernández Adrian Jayr\r\nGarces Pérez Jesus Alan\r\nNavarro Melo Christian Eduardo\r\nMoctezuma López Brayan Daniel\r\n\r\n\r\n";
            // 
            // frmAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAbout";
            Text = "frmAbout";
            Load += frmAbout_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
    }
}