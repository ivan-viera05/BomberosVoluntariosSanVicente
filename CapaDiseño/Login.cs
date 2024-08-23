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
    public partial class Login : Form
    {
        private NegocioPersonal negocio = new NegocioPersonal();
      
        public Login()
        {
            InitializeComponent();
         
        }
        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                panel1.Visible = true; // Mostrar panel1 al cerrar el formulario hijo
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelForms.Controls.Add(childForm);
            panelForms.Tag = childForm;
            childForm.BringToFront();
            activeForm.Show();
            if (childForm is Administracion)
            {
                panel1.Visible = false; // Ocultar panel1 si se abre el formulario de administración
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text;
            string codigoPersona = txtCodigo.Text;

            if (negocio.Login(dni, codigoPersona))
            {
                MessageBox.Show("Login exitoso.");

                // Supongamos que la jerarquía se obtiene correctamente aquí después del login
                string jerarquia = negocio.ObtenerJerarquia(dni); // Método que deberías implementar para obtener la jerarquía

                Administracion adminForm = new Administracion(jerarquia);
                adminForm.FormClosed += (s, args) => panel1.Visible = true; // Mostrar panel1 cuando se cierre el formulario
                openChildForm(adminForm);

                panel1.Visible = false;
            }
            else
            {
                MessageBox.Show("DNI o Código Persona incorrectos.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
           
                this.Close();
            

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtDNI.Clear();
        }

        private void panelForms_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }
        private void CenterControls()
        {

            // Panel a centrar
            int panelWidth = panel1.Width;
            int panelHeight = panel1.Height;

            // Tamaño del formulario
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            // Calcula la posición centrada
            panel1.Left = (formWidth - panelWidth) / 2;

           
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
