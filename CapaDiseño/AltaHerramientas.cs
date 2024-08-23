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
    public partial class AltaHerramientas : Form
    {
        private NegocioInventario negocio = new NegocioInventario();
        public AltaHerramientas()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            // 1. Obtener los valores de los controles en el formulario
            string codigoHerramienta = txtCodigoHerramienta.Text;
            string nombreHerramienta = txtNombreHerramienta.Text;
            string categoria = cbxCategoria.SelectedItem.ToString();
            string ubicacion = txtUbicacion.Text;
            int cantidad = int.Parse(txtCantidad.Text);
            decimal costo = decimal.Parse(txtCosto.Text);
            DateTime fechaAdquisicion = dtpFechaAdquisicion.Value;
            string estado = cbxEstado.SelectedIndex.ToString();

            // 2. Llamar a la capa de negocios para realizar el alta
            bool isSuccess = negocio.AltaHerramienta(codigoHerramienta, nombreHerramienta, categoria, ubicacion, cantidad, costo, fechaAdquisicion, estado);

            if (isSuccess)
            {
                MessageBox.Show("Herramienta agregada exitosamente.");
                // Limpiar los controles si es necesario
            }
            else
            {
                MessageBox.Show("Hubo un problema al agregar la herramienta.");
            }
        }

        private void AltaHerramientas_Load(object sender, EventArgs e)
        {

        }
    }
}
