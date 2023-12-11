using Microsoft.Web.WebView2.Core;
using org.mariuszgromada.math.mxparser;

namespace MetodosUIVer3
{
    public partial class frmPuntoF : Form
    {
        private List<double> errores = new List<double>();

        public frmPuntoF()
        {
            Load += frmPuntoF_Load;
            InitializeComponent();
            btnCalcular.Click += btnCalcular_Click;
        }

        private void frmPuntoF_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la función, valor inicial y número de iteraciones del usuario
                string strFuncion = txtFuncion.Text;
                double x0 = Convert.ToDouble(txtAproxInicial.Text);

                // Nuevo parámetro
                int numeroIteraciones = Convert.ToInt32(txtNumeroIteraciones.Text);

                // Limpiar la lista de errores antes de realizar nuevos cálculos
                errores.Clear();

                // Calcular la raíz usando el método de punto fijo con los nuevos parámetros
                double resultado = PuntoFijo(strFuncion, x0, numeroIteraciones);

                // Mostrar el resultado y los errores en un solo cuadro de alerta
                MostrarResultadoYErrores(resultado);

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





        // Método para mostrar el resultado y los errores en un solo cuadro de alerta
        private void MostrarResultadoYErrores(double resultado)
        {
            // Puedes ajustar esto según la forma en que deseas mostrar los errores en tu interfaz de usuario
            string erroresString = string.Join(", ", errores);
            string mensaje = $"La raíz aproximada es: {resultado}\n\nErrores en cada iteración: {erroresString}";

            MessageBox.Show(mensaje, "Resultado y Errores", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private double PuntoFijo(string funcion, double x0, int numeroIteraciones)
        {
            // Implementación del método de punto fijo
            int iteracion = 0;
            double xi = x0;

            do
            {
                // Calcular el nuevo valor según la iteración de punto fijo
                double xi1 = EvaluarFuncion(funcion, xi);

                // Calcular y almacenar el error en la lista
                double error = Math.Abs((xi1 - xi) / xi1);
                errores.Add(error);

                // Actualizar el valor para la siguiente iteración
                xi = xi1;

                // Incrementar el contador de iteraciones
                iteracion++;

            } while (iteracion < numeroIteraciones);

            return xi; // Devolver el último valor calculado como aproximación de la raíz
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
                // Reemplaza la notación /sqr() por sqrt()
                Function f = new Function($"g(x) = {funcion.Replace("/sqr(", "sqrt(")}");
                Argument arg = new Argument("x = " + x);
                Expression exp = new Expression("g(x)", f, arg);

                double resultado = exp.calculate();

                Console.WriteLine($"Evaluando función: g(x) = {funcion}, x = {x}, Resultado = {resultado}");

                return resultado;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al evaluar la función: {ex.Message}");
                return double.NaN; // Devuelve NaN en caso de error
            }
        }

        private void txtFuncion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAproxInicial_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumeroIteraciones_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
