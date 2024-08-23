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
    public partial class Administracion : Form
    {
        private string jerarquia;
        public Administracion(string jerarquia)
        {
            InitializeComponent();
            diseño();
            this.jerarquia = jerarquia;
            ConfigurarMenuSegunJerarquia();
        }
        private void diseño()
        {
            panelClientes.Visible = false;
            panelLibroSubmenu.Visible = false;
            panelCapacitacion.Visible = false;
            panelRemito.Visible = false;
            panelRoperia.Visible = false;
            panelInventario.Visible = false;
            panelPersonal.Visible = false;
            panelBomberos.Visible = false;
        }
        public void SetJerarquia(string jerarquia)
        {
            this.jerarquia = jerarquia;
            ConfigurarMenuSegunJerarquia();
        }
        private void ConfigurarMenuSegunJerarquia()
        {
            if (jerarquia == "Jefe de Bomberos")
            {
                diseño(); // Mostrar todo
                hideSubMenu();
                
            }
            else if (jerarquia == "Teniente")
            {
                // Ocultar opciones de menú específicas para Suboficial
                panelPersonal.Visible = false;
                btnPersonal.Visible = false;
                btnCapacitaciones.Visible = false;
                panelCapacitacion.Visible = false;
            }
            else if (jerarquia == "Bombero Voluntario")
            {
                panelLibroSubmenu.Visible = false;
                panelCapacitacion.Visible = false;
                panelClientes.Visible = false;
                panelInventario.Visible= false;
                panelRemito.Visible = false;
                panelRoperia.Visible = false;
                btnEdificio.Visible = false;
                btnTaller.Visible = false;
                btnCapacitaciones.Visible = false;
                btnboleta.Visible = false;
                btnInventario.Visible = false;
                btnPersonal.Visible = false;
                btnRoperia.Visible = false;
            }
            // Añadir más condiciones para otras jerarquías si es necesario
        }
        private void hideSubMenu()
        {

            if (panelLibroSubmenu.Visible)
            {
                panelLibroSubmenu.Visible = false;
                btnEdificio.Image = Properties.Resources.apuntar_hacia_abajo; // Cambiar a flecha hacia abajo
            }
            if (panelCapacitacion.Visible)
            {
                panelCapacitacion.Visible = false;
                btnCapacitaciones.Image = Properties.Resources.apuntar_hacia_abajo; // Cambiar a flecha hacia abajo
            }
            if (panelRemito.Visible)
            {
                panelRemito.Visible = false;
                btnboleta.Image = Properties.Resources.apuntar_hacia_abajo; // Cambiar a flecha hacia abajo
            }
            if (panelClientes.Visible)
            {
                panelClientes.Visible = false;
                btnTaller.Image = Properties.Resources.apuntar_hacia_abajo; // Cambiar a flecha hacia abajo
            }
            if (panelRoperia.Visible)
            {
                panelRoperia.Visible = false;
                btnRoperia.Image = Properties.Resources.apuntar_hacia_abajo; // Cambiar a flecha hacia abajo
            }
            if (panelInventario.Visible)
            {
                panelInventario.Visible = false;
                btnInventario.Image = Properties.Resources.apuntar_hacia_abajo; // Cambiar a flecha hacia abajo
            }
            if (panelPersonal.Visible)
            {
                panelPersonal.Visible = false;
                btnPersonal.Image = Properties.Resources.apuntar_hacia_abajo; // Cambiar a flecha hacia abajo
            }
            if (panelBomberos.Visible)
            {
                panelBomberos.Visible = false;
                btnTareas.Image = Properties.Resources.apuntar_hacia_abajo; // Cambiar a flecha hacia abajo
            }

        }

        private void showSubMenu(Panel subMenu, Button button, Image upArrow, Image downArrow)
        {
            if (!subMenu.Visible)
            {
                hideSubMenu(); // Ocultar otros submenús si es necesario
                subMenu.Visible = true;
                button.Image = upArrow; // Cambiar a flecha hacia arriba
            }
            else
            {
                subMenu.Visible = false;
                button.Image = downArrow; // Cambiar a flecha hacia abajo
            }
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
        private void Administracion_Load(object sender, EventArgs e)
        {

        }
     
        private void btnLibros_Click(object sender, EventArgs e)
        {
            showSubMenu(panelLibroSubmenu, btnEdificio, Properties.Resources.punta_de_flecha_hacia_arriba, Properties.Resources.apuntar_hacia_abajo);
          
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelClientes, btnTaller, Properties.Resources.punta_de_flecha_hacia_arriba, Properties.Resources.apuntar_hacia_abajo);      
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCapacitacion, btnCapacitaciones, Properties.Resources.punta_de_flecha_hacia_arriba, Properties.Resources.apuntar_hacia_abajo);
        }

        private void btnboleta_Click(object sender, EventArgs e)
        {
            showSubMenu(panelRemito, btnboleta, Properties.Resources.punta_de_flecha_hacia_arriba, Properties.Resources.apuntar_hacia_abajo); 
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            showSubMenu(panelRoperia, btnRoperia, Properties.Resources.punta_de_flecha_hacia_arriba, Properties.Resources.apuntar_hacia_abajo);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
         
            
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

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
    
    private void btnConsultasEdificio_Click(object sender, EventArgs e)
        {
            openChildForm(new PlanillaAsistencia());
        }

        private void btnAltasEdificio_Click(object sender, EventArgs e)
        {
            openChildForm(new PlanillaVehiculos());
        }

        private void btnConsultarActas_Click(object sender, EventArgs e)
        {
            openChildForm(new PlanillaActas());
        }

        private void btnConsultaTareas_Click(object sender, EventArgs e)
        {
            openChildForm(new PlanillaTareas());
        }

        private void btnConsultaTaller_Click(object sender, EventArgs e)
        {
            openChildForm(new PlanillaVehiculos());
        }

        private void btnAgregarVehiculo_Click(object sender, EventArgs e)
        {
            openChildForm(new AltaVehiculos());
        }

        private void btnModificarVehiculo_Click(object sender, EventArgs e)
        {
            openChildForm(new ModificarVehiculo());
        }

        private void btnBajaVehiculo_Click(object sender, EventArgs e)
        {
            openChildForm(new BajaVehiculo());
        }

        private void btnConsulaPersonal_Click(object sender, EventArgs e)
        {
            openChildForm(new PlanillaPersonal());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new PlanillaInventario());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelInventario,btnInventario, Properties.Resources.punta_de_flecha_hacia_arriba, Properties.Resources.apuntar_hacia_abajo);

        }

        private void btnConsultaInventario_Click(object sender, EventArgs e)
        {
            openChildForm(new PlanillaInventario());
        }

        private void btnAgregarHerramienta_Click(object sender, EventArgs e)
        {
            openChildForm(new AltaHerramientas());
        }

        private void btnBajaHerramienta_Click(object sender, EventArgs e)
        {
            openChildForm(new BajaHerramienta());
        }

        private void btnModificarHerramienta_Click(object sender, EventArgs e)
        {
            openChildForm(new ModificarHerramientas());
        }

        private void btnReparacionVehiculo_Click(object sender, EventArgs e)
        {
            openChildForm(new ReparacionVehiculo());
        }

        private void btnConsultarPersonal_Click(object sender, EventArgs e)
        {
            openChildForm(new PlanillaPersonal());
        }

        private void btnAgregarPersonal_Click(object sender, EventArgs e)
        {
            openChildForm(new AltaPersonal());
        }

        private void btnBajaPersonal_Click(object sender, EventArgs e)
        {
            openChildForm(new BajaPersonal());
        }

        private void btnModificarPersonal_Click(object sender, EventArgs e)
        {
            openChildForm(new ModificarPersonal());
        }

        private void btnConsultaRopero_Click(object sender, EventArgs e)
        {
            openChildForm(new PlanillaRopero());
        }

        private void panelRoperia_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregarRopero_Click(object sender, EventArgs e)
        {
            openChildForm(new AltaPrenda());
        }

        private void btnModificarPrenda_Click(object sender, EventArgs e)
        {
            openChildForm(new ModificarRopero());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPersonal, btnPersonal, Properties.Resources.punta_de_flecha_hacia_arriba, Properties.Resources.apuntar_hacia_abajo);

        }

        private void btnConsultasRopero_Click(object sender, EventArgs e)
        {
            openChildForm(new PlanillaRopero());
        }

        private void btnBajaPrenda_Click(object sender, EventArgs e)
        {
            openChildForm(new BajaPrenda());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelForms_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void label1_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void btnAltaTareas_Click(object sender, EventArgs e)
        {
            openChildForm(new AltaTareas());
        }

        private void btnReporteIncidencias_Click(object sender, EventArgs e)
        {
            openChildForm(new AltaReportes());
        }

        private void BtnCalendario_Click(object sender, EventArgs e)
        {
            openChildForm(new Calendario());
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            showSubMenu(panelBomberos, btnTareas, Properties.Resources.punta_de_flecha_hacia_arriba, Properties.Resources.apuntar_hacia_abajo);
        }

        private void btnModificarTareas_Click(object sender, EventArgs e)
        {
            openChildForm(new ModificarTareas() );
        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            openChildForm(new ModificarTareas());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
