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
    public partial class PlanillaPersonal : Form
    {
        NegocioPersonal negocio = new NegocioPersonal();
        public PlanillaPersonal()
        {
            InitializeComponent();
        }

        private void ConsultaPersonal_Load(object sender, EventArgs e)
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




        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                int? codigoBombero = string.IsNullOrEmpty(txtCodigoBombero.Text) ? (int?)null : Convert.ToInt32(txtCodigoBombero.Text);
                string jerarquia = cbxJerarquia.Text;
                string sexo = cmbSexo.Text;
                string telefono = txtTelefono.Text;
                string direccion = txtDireccion.Text;
                string estado = cbxEstado.Text;
                string email = txtEmail.Text;

                DataTable dt = negocio.BuscarPersonal(nombre, apellido, codigoBombero, jerarquia, sexo, telefono, direccion, estado, email);
                dtgvPersonal.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda: " + ex.Message);
            }
        }

        private void txtCodigoBombero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dtgvPersonal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que el índice de la fila seleccionada sea válido
            if (e.RowIndex >= 0)
            {
                // Obtén la fila seleccionada
                DataGridViewRow row = dtgvPersonal.Rows[e.RowIndex];

                // Asigna los valores de la fila a los TextBox y ComboBox correspondientes
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtApellido.Text = row.Cells["Apellido"].Value.ToString();
                cmbSexo.SelectedItem = row.Cells["Sexo"].Value.ToString();
                cbxJerarquia.SelectedItem = row.Cells["Jerarquia"].Value.ToString();
                txtCodigoBombero.Text = row.Cells["CodigoPersona"].Value.ToString();
                txtTelefono.Text = row.Cells["Telefono"].Value.ToString();
                txtDireccion.Text = row.Cells["Direccion"].Value.ToString();
                cbxEstado.SelectedItem = row.Cells["Estado"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            cmbSexo.SelectedIndex= -1;
            cbxJerarquia.SelectedIndex = -1;
            txtCodigoBombero.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            cbxEstado.SelectedIndex = -1;
            txtEmail.Clear();
        }
    }
}
