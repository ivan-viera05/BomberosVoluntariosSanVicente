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
    public partial class PlanillaVehiculos : Form
    {
        private NegocioVehiculo negocio = new NegocioVehiculo();
        public PlanillaVehiculos()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PlanillaVehiculos_Load(object sender, EventArgs e)
        {
              DataTable dt = negocio.obtenerVehiculos();
               dataGridView1.DataSource = dt;
            
        }
    }
}
