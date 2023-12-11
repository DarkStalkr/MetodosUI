using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MetodosUIVer3
{
    public partial class menuForm : Form
    {
        public menuForm()
        {
            InitializeComponent();
            this.Load += menuForm_Load;
            this.Resize += menuForm_Resize; // Suscribir al evento Resize
        }

        private void menuForm_Load(object sender, EventArgs e)
        {
            // Suscribir el evento Paint del panel al manejador pnlDegradadoMenu_Paint
            pnlDegradadoMenu.Paint += pnlDegradadoMenu_Paint;
            // Forzar un repintado del formulario y actualizar la interfaz gráfica
            this.Invalidate();
            this.Update();
        }

        private void pnlDegradadoMenu_Paint(object sender, PaintEventArgs e)
        {
            // Llamar al método que dibuja el degradado
            DibujarDegradado(e.Graphics, pnlDegradadoMenu.ClientRectangle);
        }

        private void menuForm_Resize(object sender, EventArgs e)
        {
            pnlDegradadoMenu.Invalidate(); // Vuelve a dibujar el panel
        }

        // Método para dibujar el degradado
        private void DibujarDegradado(Graphics g, Rectangle rect)
        {
            // Crear un degradado lineal
            LinearGradientBrush gradientBrush = new LinearGradientBrush(
                rect,
                Color.FromArgb(107, 1, 86), // Color inicial
                Color.FromArgb(13, 2, 33), // Color final
                LinearGradientMode.Horizontal // Cambiar orientacion a Vertical 
            );

            // Dibujar el degradado en el panel
            g.FillRectangle(gradientBrush, rect);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Código para el evento Click de pictureBox2
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Código para el evento Paint de panel1
        }
    }
}
