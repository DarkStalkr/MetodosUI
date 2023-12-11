using System;
using MathNet.Numerics.LinearAlgebra;



namespace MetodosUIVer3
{
    public partial class frmInterCuadratica : Form
    {
        public frmInterCuadratica()
        {
            InitializeComponent();
            this.Load += frmInterCuadratica_Load;
            btnCalcular.Click += btnCalcular_Click;
        }

        private void frmInterCuadratica_Load(object sender, EventArgs e)
        {
            //Configuracion Tabla
            dgvPuntos.ColumnCount = 2;
            dgvPuntos.Columns[0].HeaderText = "X";
            dgvPuntos.Columns[1].HeaderText = "Y";


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            // Obtener datos del DataGridView
            double[] xValues = new double[3];
            double[] yValues = new double[3];

            for (int i = 0; i < 3; i++)
            {
                if (!double.TryParse(dgvPuntos.Rows[i].Cells[0].Value.ToString(), out xValues[i]) ||
                    !double.TryParse(dgvPuntos.Rows[i].Cells[1].Value.ToString(), out yValues[i]))
                {
                    MessageBox.Show("Por favor, ingrese valores numéricos en todas las celdas.");
                    return;
                }
            }

            // Construir el sistema de ecuaciones
            var coefficients = Matrix<double>.Build.DenseOfArray(new double[,]
            {
                { Math.Pow(xValues[0], 2), xValues[0], 1 },
                { Math.Pow(xValues[1], 2), xValues[1], 1 },
                { Math.Pow(xValues[2], 2), xValues[2], 1 }
            });

            var constants = Vector<double>.Build.Dense(yValues);

            // Resolver el sistema de ecuaciones
            var solution = coefficients.Solve(constants);

            // Mostrar resultados
            double a = solution[0];
            double b = solution[1];
            double c = solution[2];

            MessageBox.Show($"Resultados:\na = {a}\nb = {b}\nc = {c}\n\nFórmula: y = {a}x^2 + {b}x + {c}");
        }
    }


}


