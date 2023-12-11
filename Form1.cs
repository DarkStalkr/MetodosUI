using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace MetodosUIVer3
{
    public partial class Form1 : Form
    {


        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);



        public Form1()
        {
            InitializeComponent();
            customizeDesign();
            this.StartPosition = FormStartPosition.CenterScreen;




            lblTitle.Text = "Menú";
            this.PnlFormLoader.Controls.Clear();
            menuForm menuForm = new menuForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            menuForm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(menuForm);
            menuForm.Show();




        }


        private void customizeDesign()
        {
            panelCalcSubMenu.Visible = false;



        }


        private void hideSubMenu()
        {
            if (panelCalcSubMenu.Visible == true)
                panelCalcSubMenu.Visible = false;



        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;

            }
            else
                subMenu.Visible = false;


        }



        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCalcSubMenu);
            //lblTitle.Text = "Calculadora";
            //this.PnlFormLoader.Controls.Clear();
            //frmCalc menuForm = new frmCalc() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //menuForm.FormBorderStyle = FormBorderStyle.None;
            //this.PnlFormLoader.Controls.Add(menuForm);
            //menuForm.Show();

        }

        private void buttonMenu_Click_1(object sender, EventArgs e)
        {

            lblTitle.Text = "Menú";
            this.PnlFormLoader.Controls.Clear();
            menuForm menuForm = new menuForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            menuForm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(menuForm);
            menuForm.Show();

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Acerca de:";
            this.PnlFormLoader.Controls.Clear();
            frmAbout menuForm = new frmAbout() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            menuForm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(menuForm);
            menuForm.Show();

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            AplicarDegradado();
        }

        private void AplicarDegradado()
        {
            Color colorInicio = Color.FromArgb(87, 1, 61); // Color inicial del degradado
            Color colorFin = Color.FromArgb(39, 0, 79);   // Color final del degradado

            using (LinearGradientBrush brush = new LinearGradientBrush(
                PnlFormLoader.ClientRectangle,
                colorInicio,
                colorFin,
                LinearGradientMode.Vertical))
            {
                PnlFormLoader.BackgroundImage = new Bitmap(PnlFormLoader.Width, PnlFormLoader.Height);
                using (Graphics g = Graphics.FromImage(PnlFormLoader.BackgroundImage))
                {
                    g.FillRectangle(brush, PnlFormLoader.ClientRectangle);
                }
            }
        }

        private void buttonCalc2_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Punto Fijo";
            this.PnlFormLoader.Controls.Clear();
            frmPuntoF menuForm = new frmPuntoF() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            menuForm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(menuForm);
            menuForm.Show();
            hideSubMenu();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void buttonCalc1_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Bisección";
            this.PnlFormLoader.Controls.Clear();
            frmBisec menuForm = new frmBisec() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            menuForm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(menuForm);
            menuForm.Show();

            hideSubMenu();
        }

        private void buttonCalc3_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Newton-Raphson";
            this.PnlFormLoader.Controls.Clear();
            frmNR menuForm = new frmNR() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            menuForm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(menuForm);
            menuForm.Show();
            hideSubMenu();
        }

        private void buttonCalc4_Click(object sender, EventArgs e)
        {

            lblTitle.Text = "Interpolación Lineal";
            this.PnlFormLoader.Controls.Clear();
            frmInterpol menuForm = new frmInterpol() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            menuForm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(menuForm);
            menuForm.Show();
            hideSubMenu();
        }

        private void buttonCalc5_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Interpolación Cuadrática";
            this.PnlFormLoader.Controls.Clear();
            frmInterCuadratica menuForm = new frmInterCuadratica() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            menuForm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(menuForm);
            menuForm.Show();
            hideSubMenu();

        }

        private void buttonCalc6_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Polinomio Interpolador de LaGrange";
            this.PnlFormLoader.Controls.Clear();
            frmLagrange menuForm = new frmLagrange() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            menuForm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(menuForm);
            menuForm.Show();
            hideSubMenu();
        }
    }
}