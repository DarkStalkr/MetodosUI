using MathNet.Symbolics;
using Microsoft.Web.WebView2.Core;

namespace MetodosUIVer3
{
    public partial class frmNR : Form
    {
        private List<double> errores = new List<double>();

        public frmNR()
        {
            Load += frmNR_Load;
            InitializeComponent();
            btnCalcular.Click += btnCalcular_Click;
            txtEstimacionInicial.TextChanged += txtEstimacionInicial_TextChanged;
            txtNumeroIteraciones.TextChanged += txtNumeroIteraciones_TextChanged;
        }

        private void frmNR_Load(object sender, EventArgs e)
        {
            // Puedes realizar alguna inicialización adicional si es necesario
        }

        private void txtEstimacionInicial_TextChanged(object sender, EventArgs e)
        {
            // Puedes agregar lógica adicional si es necesario
        }

        private void txtNumeroIteraciones_TextChanged(object sender, EventArgs e)
        {
            // Puedes agregar lógica adicional si es necesario
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la función, valor inicial y número de iteraciones del usuario
                string strFuncion = txtFuncion.Text;
                double x0 = Convert.ToDouble(txtEstimacionInicial.Text);

                // Limpiar la lista de errores antes de realizar nuevos cálculos
                errores.Clear();

                // Calcular la raíz usando el método de Newton-Raphson
                double resultado = NewtonRaphson(strFuncion, x0);

                // Mostrar el resultado
                MessageBox.Show($"La raíz aproximada es: {resultado}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Mostrar los errores en algún lugar de tu interfaz de usuario (puedes ajustar esto según tus necesidades)
                MostrarErrores();

                // Mostrar los errores en el WebView
                MostrarErroresWebView(errores, resultado);
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

        private double NewtonRaphson(string funcion, double x0)
        {
            int iteracion = 0;
            double xi = x0;
            double error;

            do
            {
                // Calcular f(xi)
                double fx = EvaluarFuncion(funcion, xi);

                // Calcular f'(xi)
                double fpx = CalcularDerivada(funcion, xi);

                // Evitar la división por cero
                if (fpx == 0)
                {
                    throw new Exception("La derivada de la función en el punto es cero. No se puede continuar.");
                }

                // Calcular el nuevo valor según la fórmula de Newton-Raphson
                double xi1 = xi - fx / fpx;

                // Calcular el error en cada iteración
                error = Math.Abs(xi1 - xi);
                errores.Add(error);

                // Actualizar el valor para la siguiente iteración
                xi = xi1;

                // Incrementar el contador de iteraciones
                iteracion++;

            } while (error > 0.0001 && iteracion < 1000); // Definir el criterio de parada y un límite máximo de iteraciones

            return xi;
        }

        // Método para mostrar los errores en algún lugar de tu interfaz de usuario
        private void MostrarErrores()
        {
            // Puedes ajustar esto según la forma en que deseas mostrar los errores en tu interfaz de usuario
            string erroresString = string.Join(", ", errores);
            MessageBox.Show($"Errores en cada iteración: {erroresString}", "Errores", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private double EvaluarFuncion(string funcion, double x)
        {
            try
            {
                // Parsear la función
                var parsedFunction = SymbolicExpression.Parse(funcion);

                // Crear un diccionario de variables con el valor de x
                var variables = new Dictionary<string, FloatingPoint> { { "x", x } };

                // Evaluar la función en el punto x
                var result = parsedFunction.Evaluate(variables);

                // Verificar si el resultado es un número real y devolverlo
                if (result.IsReal)
                {
                    return result.RealValue;
                }
                else
                {
                    throw new Exception($"La evaluación de la función no produjo un valor real en x = {x}.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al evaluar la función: {ex.Message}");
                throw;
            }
        }

        private double CalcularDerivada(string funcion, double x)
        {
            try
            {
                // Ajusta el valor de h según sea necesario
                double h = 1e-6;

                // Calcular la derivada numérica usando la diferencia finita centrada
                double derivadaEnX = (EvaluarFuncion(funcion, x + h) - EvaluarFuncion(funcion, x - h)) / (2 * h);

                return derivadaEnX;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al calcular la derivada: {ex.Message}");
            }
        }

        private void txtFuncion_TextChanged(object sender, EventArgs e)
        {
            // Puedes agregar lógica adicional si es necesario
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
