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
    public partial class AltaPersonal : Form
    {
        private NegocioPersonal negocio = new NegocioPersonal();
        public AltaPersonal()
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
                // Llamar al método de la capa de negocio con los parámetros individuales
                bool resultado = negocio.AgregarPersonal(
                    txtNombre.Text,
                    txtApellido.Text,
                    cmbSexo.SelectedItem.ToString(),
                    cmbJerarquia.SelectedItem.ToString(),
                    int.Parse(txtCodigoBombero.Text),
                    int.Parse(txtTelefono.Text),
                    txtDireccion.Text,
                    cmbEstado.SelectedItem.ToString(),
                    txtEmail.Text,
                    txtEspecialidad.Text,
                    txtDNI.Text
                );

                if (resultado)
                {
                    MessageBox.Show("Personal agregado exitosamente");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al agregar el personal");
                }
            }
            catch (Exception ex)
            {
                // Mostrar el mensaje de error completo
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            cmbSexo.SelectedIndex = -1;
            cmbJerarquia.SelectedIndex = -1;
            txtCodigoBombero.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            cmbEstado.SelectedIndex = -1;
            txtEmail.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void AltaPersonal_Load(object sender, EventArgs e)
        {

        }
    }
}
