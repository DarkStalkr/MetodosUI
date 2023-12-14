using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;



namespace MetodosUIVer3
{
    public partial class frmBisec2 : Form
    {
        public frmBisec2()
        {
            InitializeComponent();



        }

        private async void btnCalcular_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtIntervaloA.Text);
            double b = double.Parse(txtIntervaloB.Text);
            string funcionTexto = txtFuncion.Text;
            int maxIteraciones = int.Parse(txtNumeroIteraciones1.Text); // Textbox

            double resultado = await BiseccionAsync(a, b, funcionTexto, maxIteraciones);

            MessageBox.Show($"La raíz aproximada es: {resultado}");
        }



        private async Task<double> BiseccionAsync(double a, double b, string funcionTexto, int maxIteraciones)
        {
            double c = 0, cAnterior = 0, error = 0;

            for (int i = 0; i < maxIteraciones; i++)
            {
                cAnterior = c;
                c = (a + b) / 2;
                double fc = await EvaluarFuncionAsync(funcionTexto, c);

                if (await EvaluarFuncionAsync(funcionTexto, a) * fc < 0)
                {
                    b = c;
                }
                else
                {
                    a = c;
                }

                if (i > 0)
                {
                    error = Math.Abs(c - cAnterior) / Math.Abs(c);
                    if (error < 0.0001)  // Puedes ajustar este valor de tolerancia según sea necesario
                        break;
                }
            }

            return c; // Devolver el valor aproximado de la raíz
        }




        public class Globals
        {
            public double X { get; set; }
        }

        private async Task<double> EvaluarFuncionAsync(string funcionTexto, double x)
        {
            // Reemplaza 'x' con 'X' y '^' con una llamada a Math.Pow
            string codigo = Regex.Replace(funcionTexto, @"(\w+)\s*\^\s*(\w+)", m => $"Math.Pow({m.Groups[1].Value}, {m.Groups[2].Value})");
            codigo = codigo.Replace("x", "X");

            var scriptOptions = ScriptOptions.Default
                .AddReferences(typeof(Math).Assembly)
                .AddImports("System"); // Asegúrate de incluir el espacio de nombres System

            var script = CSharpScript.Create<double>($"return {codigo};", scriptOptions, typeof(Globals));
            script.Compile(); // Compila el script para verificar errores
            var result = await script.RunAsync(new Globals { X = x });
            return result.ReturnValue;
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
