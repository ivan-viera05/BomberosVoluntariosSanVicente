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
    public partial class AltaPrenda : Form
    {
        private NegocioRopero negocio = new NegocioRopero();
        public AltaPrenda()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                string tipoPrenda = cbxTipoPrenda.SelectedIndex.ToString();
                string talla = cbTalla.SelectedItem.ToString();
                string estado = cbEstado.SelectedItem.ToString();
                string codigoPrenda = txtCodigoPrenda.Text;
                string codigoBombero = txtCodigoBombero.Text;
                string materialPrincipal = cbMaterialPrincipal.SelectedItem.ToString();
                bool resistenciaAlCalor = rbSi.Checked;
                DateTime fechaAdquisicion = dtpFechaAdquisicion.Value;
                string marca = txtMarca.Text;
                string modelo = txtModelo.Text;

                if (negocio.AgregarPrenda(nombre, tipoPrenda, talla, estado, codigoPrenda, codigoBombero, materialPrincipal, resistenciaAlCalor, fechaAdquisicion, marca, modelo))
                {
                    MessageBox.Show("Prenda agregada exitosamente.");
                }
                else
                {
                    MessageBox.Show("Error al agregar la prenda.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
