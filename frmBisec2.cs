using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MetodosUIVer3
{
    public partial class frmBisec2 : Form
    {
        public frmBisec2()
        {
            InitializeComponent();



        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Obtener los valores de a y b desde los cuadros de texto
            double a = double.Parse(txtIntervaloA.Text);
            double b = double.Parse(txtIntervaloB.Text);

            // Llamar a la función que implementa el método de bisección
            double resultado = Biseccion(a, b);

            // Mostrar el resultado en un cuadro de texto o en un mensaje
            MessageBox.Show($"La raíz aproximada es: {resultado}");
        }

        private double Biseccion(double a, double b)
        {
            double errorTolerado = 0.0001; // Establecer la tolerancia de error deseada
            double c = 0; // Inicializar el valor de c

            do
            {
                // Calcular el punto medio c
                c = (a + b) / 2;

                // Calcular el valor de la función en c
                double fc = Funcion(c);

                // Verificar el signo de f(a) y f(c)
                if (Funcion(a) * fc < 0)
                {
                    b = c; // La raíz está en el intervalo [a, c]
                }
                else
                {
                    a = c; // La raíz está en el intervalo [c, b]
                }

                // Calcular el error
                double error = Math.Abs(c - ((a + b) / 2)) / c;

                // Verificar si el error es menor que la tolerancia deseada
                if (error < errorTolerado)
                {
                    break;
                }

            } while (true);

            return c; // Devolver el valor de c como la raíz aproximada
        }
        private double Funcion(double x)
        {
            // Definir la función f(x) aquí
            return Math.Pow(x, 3) + x - 1;
        }











        private void pnlMainBisec_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtIntervaloA_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmBisec2_Load(object sender, EventArgs e)
        {

        }
    }
}
