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
    public partial class AltaReportes : Form
    {
        private NegocioReportes negocio = new NegocioReportes();
        public AltaReportes()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AltaReportes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int codigobombero = Convert.ToInt32(txtCodigoBombero.Text);
                string tipoReporte = txtTipoReporte.Text;
                string descripcion = txtDescripcion.Text;
                DateTime fechaReporte = dtpFechaReporte.Value;
                string observaciones = txtObservaciones.Text;

                negocio.AgregarReporte(codigobombero, tipoReporte, descripcion, fechaReporte, observaciones);

                MessageBox.Show("Reporte agregado exitosamente.");
                this.Close(); // Cerrar el formulario después de agregar el reporte
            }
            catch (Exception ex)
            {
                // Mostrar el mensaje de error al usuario
                if (ex.Message.Contains("El bombero con el código proporcionado no existe"))
                {
                    MessageBox.Show("El código del bombero ingresado no existe. Por favor, verifíquelo e intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtDescripcionHecho_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
