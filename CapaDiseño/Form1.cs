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
    public partial class Form1 : Form
    {


        private Image normalImage;
        private Image hoverImage;
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            normalImage = Image.FromFile("C:\\BomberosSanVicente\\BomberosSanVicente\\CapaDiseño\\Resources\\png-transparent-car-fire-engine-firefighter-camiones-de-bomberos-car-firefighter-truck-car3.png");
            hoverImage = Image.FromFile("C:\\BomberosSanVicente\\BomberosSanVicente\\CapaDiseño\\Resources\\png-transparent-car-fire-engine-firefighter-camiones-de-bomberos-car-firefighter-truck-car3a.png");

            pictureBox2.Image = normalImage; // Establecer la imagen normal inicialmente
        }
        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelForms.Controls.Add(childForm);
            panelForms.Tag = childForm;
            childForm.BringToFront();
            activeForm.Show();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
        int posY = 0;
        int posX = 0;
      
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnMaximizar.Location = new Point(this.ClientSize.Width - btnMaximizar.Width - 10, 10);
            btnMinimizar.Location = new Point(this.ClientSize.Width - btnMinimizar.Width - 10, 10);
            btnClose.Location = new Point(this.ClientSize.Width - btnClose.Width - 10, 10);
            timer1.Interval = 1000; // Actualiza cada segundo
            timer1.Start(); // Inicia el Timer
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"); // Muestra la fecha y hora actual
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelForms_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            openChildForm(new EntradaCuartel());
        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            string jerarquiaUsuario = "Jefe"; // O la jerarquía correspondiente según el usuario actual
            openChildForm(new Administracion(jerarquiaUsuario));
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            openChildForm(new SalidaCuartel());
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
           openChildForm(new EntradaEmergencia());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Login());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Resize(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                btnMaximizar.Visible = false;
                btnRestaurar.Visible = true;

                // Reposicionar botones manualmente si es necesario
                btnRestaurar.Location = new Point(this.ClientSize.Width - btnRestaurar.Width - 10, 10);
                btnMinimizar.Location = new Point(this.ClientSize.Width - btnMinimizar.Width - 10, 10);
                btnClose.Location = new Point(this.ClientSize.Width - btnClose.Width - 10, 10);
            }
            else
            {
                btnMaximizar.Visible = true;
                btnRestaurar.Visible = false;
            }
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {

            pictureBox2.Image = normalImage;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = hoverImage;
        }
    }
}
