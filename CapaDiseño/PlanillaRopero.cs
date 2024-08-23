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
    public partial class PlanillaRopero : Form
    {
        private NegocioRopero negocio = new NegocioRopero();
        public PlanillaRopero()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PlanillaRopero_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = negocio.ObtenerPendas();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string tipoPrenda = cmbTipoPrenda.SelectedItem?.ToString();
            string codigoPrenda = txtCodigoPrenda.Text.Trim();
            string talla = cmbTalla.SelectedItem?.ToString();
            string estado = cmbEstado.SelectedItem?.ToString();
            string codigoBombero = txtCodigoBombero.Text.Trim();
            string materialPrincipal = cmbMaterialPrincipal.SelectedItem?.ToString();
            bool? resistenciaAlCalor = rbtnSi.Checked ? true : rbtnNo.Checked ? (bool?)false : null;
            DateTime? fechaAdquisicion = dtpFechaAdquisicion.Value != DateTime.MinValue ? (DateTime?)dtpFechaAdquisicion.Value : null;
            string marca = txtMarca.Text.Trim();
            string modelo = txtModelo.Text.Trim();

            DataTable dtPrendas = negocio.BuscarPrendas(nombre, tipoPrenda, codigoPrenda, talla, estado, codigoBombero, materialPrincipal, resistenciaAlCalor, fechaAdquisicion, marca, modelo);

            dataGridView1.DataSource = dtPrendas;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
