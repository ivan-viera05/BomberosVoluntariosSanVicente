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
    public partial class SalidaCuartel : Form
    {
        private NegocioAsistencia negocio = new NegocioAsistencia();
        public SalidaCuartel()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            int codigoBombero;
            if (int.TryParse(txtCodigoBombero.Text, out codigoBombero))
            {
            
               
                txtCodigoBomberoSalida.Text = codigoBombero.ToString();
                lblFechaHoraSalida.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un código de bombero válido.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int codigoBombero;
            if (int.TryParse(txtCodigoBomberoSalida.Text, out codigoBombero))
            {
                negocio.RegistrarSalida(codigoBombero);
                MessageBox.Show("Salida registrada exitosamente.");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un código de bombero válido.");
            }
        }
    }
}
