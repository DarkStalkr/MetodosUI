namespace MetodosUIVer3
{
    public partial class frmInterpol : Form
    {
        private List<double> xValues = new List<double>();
        private List<double> yValues = new List<double>();
        public frmInterpol()
        {
            InitializeComponent();
            Load += frmInterpol_Load;
            btnCalcular.Click += btnCalcular_Click;
        }

        private void frmInterpol_Load(object sender, EventArgs e)
        {
            // Configuración inicial del DataGridView
            dgvPuntos2.ColumnCount = 2;
            dgvPuntos2.Columns[0].HeaderText = "X";
            dgvPuntos2.Columns[1].HeaderText = "Y";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Limpiar listas
            xValues.Clear();
            yValues.Clear();

            // Obtener datos del DataGridView
            for (int i = 0; i < dgvPuntos2.Rows.Count - 1; i++)
            {
                if (double.TryParse(dgvPuntos2.Rows[i].Cells[0].Value.ToString(), out double x) &&
                    double.TryParse(dgvPuntos2.Rows[i].Cells[1].Value.ToString(), out double y))
                {
                    xValues.Add(x);
                    yValues.Add(y);
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese valores numéricos en todas las celdas.");
                    return;
                }
            }

            // Preguntar al usuario qué valor de x desea interpolar/extrapolar
            if (double.TryParse(promptForX(), out double xInterpolar))
            {
                // Calcular la pendiente m y la ordenada al origen b
                double m, b;

                if (xInterpolar < xValues[0]) // Extrapolación usando el primer polo
                {
                    m = calcularPendienteExtrapolacion(0);
                    b = yValues[0] - m * xValues[0];
                }
                else if (xInterpolar > xValues[xValues.Count - 1]) // Extrapolación usando el último polo
                {
                    m = calcularPendienteExtrapolacion(xValues.Count - 1);
                    b = yValues[yValues.Count - 1] - m * xValues[xValues.Count - 1];
                }
                else // Interpolación
                {
                    m = calcularPendiente();
                    b = yValues[0] - m * xValues[0];
                }

                // Calcular y para el valor de x interpolar/extrapolar
                double yInterpolado = m * xInterpolar + b;

                // Mostrar el resultado
                MessageBox.Show($"Para x = {xInterpolar}, y = {yInterpolado}");
            }
        }

        private string promptForX()
        {
            return Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor de x para interpolar/extrapolar en el eje Y:", "Valor de x", "0", -1, -1);
        }

        private double calcularPendiente()
        {
            // Calcular la pendiente m entre el primer y segundo punto
            double m = (yValues[1] - yValues[0]) / (xValues[1] - xValues[0]);
            return m;
        }

        private double calcularPendienteExtrapolacion(int indice)
        {
            // Calcular la pendiente usando el primer o último punto para extrapolación
            double m = (yValues[indice] - yValues[0]) / (xValues[indice] - xValues[0]);
            return m;
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}




















