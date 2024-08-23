using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDiseño
{
    public partial class EntradaCuartel : Form
    {

        private NegocioAsistencia asistenciaNegocio = new NegocioAsistencia();
        public EntradaCuartel()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EntradaCuartel_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000; // Actualiza cada segundo      
            timer1.Start(); // Inicia el Timer
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"); // Muestra la fecha y hora actual
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            int codigoBombero;
            if (int.TryParse(txtCodigoBombero.Text, out codigoBombero))
            {
                
                txtCodigoBomberoIngreso.Text = codigoBombero.ToString();
                lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un código de bombero válido.");
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int codigoBombero;
            if (int.TryParse(txtCodigoBomberoIngreso.Text, out codigoBombero))
            {
                asistenciaNegocio.RegistrarEntrada(codigoBombero);
                MessageBox.Show("Entrada registrada exitosamente.");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un código de bombero válido.");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
