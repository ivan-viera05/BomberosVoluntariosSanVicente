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
    public partial class BajaPersonal : Form
    {
        NegocioPersonal negocio = new NegocioPersonal();
        public BajaPersonal()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BajaPersonal_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = negocio.ObtenerTodosLosPersonales();
                dtgvPersonal.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }
        private void CargarPersonas()
        {
            DataTable personas = negocio.ObtenerTodosLosPersonales();
            dtgvPersonal.DataSource = personas;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCodigoBombero.Text, out int codigoPersona))
            {
                bool resultado = negocio.EliminarPersona(codigoPersona);

                if (resultado)
                {
                    MessageBox.Show("Persona eliminada correctamente.");
                    CargarPersonas();
                    txtCodigoBombero.Clear();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la persona.");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un código válido.");
            }
        }

        private void dtgvPersonal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvPersonal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvPersonal.Rows[e.RowIndex];
                txtCodigoBombero.Text = row.Cells["CodigoPersona"].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCodigoBombero.Clear();
        }
    }
}
