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
    public partial class ModificarPersonal : Form
    {
        private NegocioPersonal negocio = new NegocioPersonal();
        public ModificarPersonal()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModificarPersonal_Load(object sender, EventArgs e)
        {
            CargarPersonas();
        }
        private void CargarPersonas()
        {
            DataTable personas = negocio.ObtenerTodosLosPersonales();
            dataGridView1.DataSource = personas;
        }
        private void btnIngreso_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCodigoBombero.Text, out int codigoPersona))
            {
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string sexo = comboBoxSexo.SelectedItem.ToString();
                string jerarquia = comboBoxJerarquia.SelectedItem.ToString();
                string telefono = txtTelefono.Text;
                string direccion = txtDireccion.Text;
                string email = txtEmail.Text;
                string estado = comboBoxEstado.SelectedItem.ToString();

                bool resultado = negocio.ModificarPersona(codigoPersona, nombre, apellido, sexo, jerarquia, telefono, direccion, email, estado);

                if (resultado)
                {
                    MessageBox.Show("Persona modificada correctamente.");
                    // Puedes agregar lógica para refrescar el DataGridView si es necesario
                    CargarPersonas();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar la persona.");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un código válido.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCodigoBombero.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtEmail.Clear();
            comboBoxSexo.SelectedIndex = -1;
            comboBoxJerarquia.SelectedIndex = -1;
            comboBoxEstado.SelectedIndex = -1;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtCodigoBombero.Text = row.Cells["CodigoPersona"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtApellido.Text = row.Cells["Apellido"].Value.ToString();
                string sexo= row.Cells["Sexo"].Value.ToString();
                switch (sexo)
                {
                    case "Masculino":
                        comboBoxSexo.SelectedItem = "Masculino";
                        break;
                    case "Femenino":
                        comboBoxSexo.SelectedItem = "Femenino";
                        break;
                    default:
                        comboBoxSexo.SelectedItem = null;
                        break;

                }

                string jerarquia = row.Cells["jerarquia"].Value.ToString();
                switch (jerarquia)
                {
                    case "Jefe de Bomberos":
                        comboBoxJerarquia.SelectedItem = "Jefe de Bomberos";
                        break;
                    case "Teniente":
                        comboBoxJerarquia.SelectedItem = "Teniente";
                        break;
                    case "Subteniente":
                        comboBoxJerarquia.SelectedItem = "Subteniente";
                        break;
                    case "Sargento":
                        comboBoxJerarquia.SelectedItem = "Sargento";
                        break;
                    case "Cabo":
                        comboBoxJerarquia.SelectedItem = "Cabo";
                        break;
                    case "Bombero de Primera":
                        comboBoxJerarquia.SelectedItem = "Bombero de Primera";
                        break;
                    case "Bombero Voluntario":
                        comboBoxJerarquia.SelectedItem = "Bombero Voluntario";
                        break;
                    default:
                        comboBoxJerarquia.SelectedItem = null;
                        break;
                }

                        txtTelefono.Text = row.Cells["Telefono"].Value.ToString();
                txtDireccion.Text = row.Cells["Direccion"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
               string  estado = row.Cells["Estado"].Value.ToString();
                switch (estado)
                {
                    case "Activo":
                        comboBoxEstado.SelectedItem = "Activo";
                        break;
                    case "Inactivo":
                        comboBoxEstado.SelectedItem = "Inactivo";
                        break;
                    default:
                        comboBoxEstado.SelectedItem = "Activo";
                        break;
                }
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
