// using System;
using NCalc;
using Microsoft.Web.WebView2.Core;

namespace MetodosUIVer3
{
    public partial class frmBisec : Form
    {
        public frmBisec()
        {
            InitializeComponent();
            Load += frmBisec_Load;
            btnCalcular.Click += btnCalcular_Click;
        }

        private List<double> errores = new List<double>();

        private void frmBisec_Load(object sender, EventArgs e)
        {
            // Se puede Eliminar cualquier lógica relacionada con txtErrorPorcentual en el evento Load si es necesario
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la función y los intervalos a y b del usuario
                string strFuncion = txtFuncion.Text;
                double a = Convert.ToDouble(txtIntervaloA.Text);
                double b = Convert.ToDouble(txtIntervaloB.Text);

                // Nuevos parámetros
                int numeroIteraciones = Convert.ToInt32(txtNumeroIteraciones.Text);

                // Limpiar la lista de errores antes de realizar nuevos cálculos
                errores.Clear();

                // Calcular la raíz usando el método de bisección con los nuevos parámetros
                double resultado = Biseccion(strFuncion, a, b, numeroIteraciones);

                // Mostrar el resultado
                MessageBox.Show($"La raíz aproximada es: {resultado}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Mostrar los errores en el WebView
                MostrarErroresWebView(errores, resultado);



                // Mostrar los errores en algún lugar de tu interfaz de usuario (puedes ajustar esto según tus necesidades)
                MostrarErrores();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarErroresWebView(List<double> errores, double resultado)
        {
            // Construir la cadena de errores formateada para mostrar en el WebView
            string erroresString = string.Join(", ", errores);

            // Construir la página HTML con MathJax
            string html = $@"<!DOCTYPE html>
        <html>
        <head>
            <script type=""text/javascript"" async
                    src=""https://cdnjs.cloudflare.com/ajax/libs/mathjax/2.7.7/MathJax.js?config=TeX-MML-AM_CHTML"">
            </script>
        </head>
        <body>
            <p id=""math"">Errores en cada iteración: \( {erroresString} \)</p>
            <p id=""result"">Resultado final: {resultado}</p>
        </body>
        </html>";

            // Configurar el evento CoreWebView2InitializationCompleted
            webView2.CoreWebView2InitializationCompleted += (sender, e) =>
                WebView2_CoreWebView2InitializationCompleted(sender, e, html);

            // Iniciar la inicialización de CoreWebView2
            webView2.EnsureCoreWebView2Async(null);
        }




        private void WebView2_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e, string html)
        {
            if (e.IsSuccess)
            {
                // CoreWebView2 se ha inicializado correctamente, ahora podemos navegar a la cadena HTML
                if (sender is Microsoft.Web.WebView2.WinForms.WebView2 webView)
                {
                    webView.CoreWebView2.NavigateToString(html);
                }
            }
            else
            {
                // Manejar el error si la inicialización falla
                MessageBox.Show("La inicialización de CoreWebView2 ha fallado.");
            }
        }


        private double Biseccion(string funcion, double a, double b, int numeroIteraciones)
        {
            // Implementación del método de bisección con el cálculo específico del error
            int iteracion = 0;
            double c;

            
            {
                // Calcular el punto medio
                c = (a + b) / 2;

                // Evaluar la función en los extremos y en el punto medio
                double fa = EvaluarFuncion(funcion, a);
                double fb = EvaluarFuncion(funcion, b);
                double fc = EvaluarFuncion(funcion, c);

                // Actualizar el intervalo [a, b]
                if (fa * fc < 0)
                {
                    b = c;
                }
                else
                {
                    a = c;
                }

                // Calcular el error y almacenarlo en la lista
                double error = (b - a) / b;
                errores.Add(error);

                // Incrementar el contador de iteraciones
                iteracion++;

            } while (iteracion < numeroIteraciones);

            return (a + b) / 2; // Devolver el valor medio como aproximación de la raíz
        }

        // Método para mostrar los errores en algún lugar de tu interfaz de usuario
        private void MostrarErrores()
        {
            // Ajustar
            string erroresString = string.Join(", ", errores);
            MessageBox.Show($"Errores en cada iteración: {erroresString}", "Errores", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private double EvaluarFuncion(string funcion, double x)
        {
            Expression expresion = new Expression(funcion.Replace("x", x.ToString()));

            try
            {
                double resultado = Convert.ToDouble(expresion.Evaluate());
                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al evaluar la función: {ex.Message}");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Elimina cualquier lógica relacionada con txtErrorPorcentual en este evento si es necesario
        }

        private void txtErrorPorcentual_TextChanged(object sender, EventArgs e)
        {
            // Puedes eliminar este evento si no es necesario
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtIntervaloA_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtIntervaloB_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtFuncion_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNumeroIteraciones_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void pnlTitle1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void webView2_Click(object sender, EventArgs e)
        {

        }

        private void panelAbout_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
