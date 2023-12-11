using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MathNet.Numerics;
using MathNet.Symbolics;
using Microsoft.Web.WebView2.Core;
using OxyPlot;
using OxyPlot.Series;


namespace MetodosUIVer3
{
    public partial class frmLagrange : Form
    {
        private List<BigRational> xValues = new List<BigRational>();
        private List<BigRational> yValues = new List<BigRational>();
        private List<DataPoint> puntosGrafica = new List<DataPoint>();

        public frmLagrange()
        {
            InitializeComponent();
            Load += frmLagrange_Load;
            btnCalcular.Click += btnCalcular_Click;
        }

        private void frmLagrange_Load(object sender, EventArgs e)
        {
            // Configuración inicial del DataGridView
            dgvPuntos.ColumnCount = 2;
            dgvPuntos.Columns[0].HeaderText = "X";
            dgvPuntos.Columns[1].HeaderText = "Y";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Limpiar listas
            xValues.Clear();
            yValues.Clear();

            // Obtener datos del DataGridView
            for (int i = 0; i < dgvPuntos.Rows.Count - 1; i++)
            {
                try
                {
                    var x = BigRational.Parse(dgvPuntos.Rows[i].Cells[0].Value.ToString());
                    var y = BigRational.Parse(dgvPuntos.Rows[i].Cells[1].Value.ToString());

                    xValues.Add(x);
                    yValues.Add(y);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Por favor, ingrese valores numéricos en todas las celdas.");
                    return;
                }
            }

            // Calcular el polinomio interpolador de Lagrange
            var polinomio = CalcularPolinomioLagrange();


            // Generar puntos para la gráfica
            GenerarPuntosGrafica(polinomio);




            // Mostrar el resultado en el WebView con MathJax
            MostrarResultadoWebView(polinomio);


            // Actualizar la gráfica
            ActualizarGrafica();
        }


        private void GenerarPuntosGrafica(SymbolicExpression polinomio)
        {
            puntosGrafica.Clear();

            // Agregar puntos al polinomio para la gráfica
            for (double x = -10; x <= 10; x += 0.1)
            {
                double y = polinomio.Evaluate(new Dictionary<string, FloatingPoint> { { "x", x } }).RealValue;

                puntosGrafica.Add(new DataPoint(x, y));
            }
        }


        private void ActualizarGrafica()
        {
            // Crear la gráfica y la serie
            var plotModel = new PlotModel();
            var lineSeries = new LineSeries();
            lineSeries.Points.AddRange(puntosGrafica);

            // Agregar la serie a la gráfica
            plotModel.Series.Add(lineSeries);

            // Asignar la gráfica al PlotView
            plotView1.Model = plotModel;
        }

        private SymbolicExpression CalcularPolinomioLagrange()
        {
            int n = xValues.Count;
            var polinomio = SymbolicExpression.Zero;

            for (int i = 0; i < n; i++)
            {
                var termino = new SymbolicExpression(yValues[i]);

                for (int j = 0; j < n; j++)
                {
                    if (j != i)
                    {
                        var denominador = xValues[i] - xValues[j];
                        termino *= (SymbolicExpression.Variable("x") - xValues[j]) / denominador;
                    }
                }

                polinomio += termino;
            }

            return polinomio;
        }

        private void MostrarResultadoWebView(SymbolicExpression polinomio)
        {
            // Obtener la cadena de la expresión simbólica
            var formattedPolinomio = FormatearFracciones(polinomio.ToString());

            // Construir la página HTML con MathJax
            string html = $@"<!DOCTYPE html>
    <html>
    <head>
        <script type=""text/javascript"" async
                src=""https://cdnjs.cloudflare.com/ajax/libs/mathjax/2.7.7/MathJax.js?config=TeX-MML-AM_CHTML"">
        </script>
    </head>
    <body>
        <p id=""math"">\( {formattedPolinomio} \)</p>
    </body>
    </html>";

            // Configurar el evento CoreWebView2InitializationCompleted
            webView1.CoreWebView2InitializationCompleted += (sender, e) => WebView1_CoreWebView2InitializationCompleted(sender, e, html);

            // Iniciar la inicialización de CoreWebView2
            webView1.EnsureCoreWebView2Async(null);
        }



        private string FormatearFracciones(string expresion)
        {
            // Reemplazar el formato a/(b*c) con \frac{a}{b*c}
            expresion = expresion.Replace("(", "{").Replace(")", "}");
            expresion = System.Text.RegularExpressions.Regex.Replace(expresion, @"(\d+)/(\d+)", "\\frac{$1}{$2}");

            return expresion;
        }


        private void WebView1_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e, string html)
        {
            if (e.IsSuccess)
            {
                // CoreWebView2 se ha inicializado correctamente, ahora podemos navegar a la cadena HTML
                webView1.NavigateToString(html);
            }
            else
            {
                // Manejar el error si la inicialización falla
                MessageBox.Show("La inicialización de CoreWebView2 ha fallado.");
            }
        }

        private void plotView1_Click(object sender, EventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
