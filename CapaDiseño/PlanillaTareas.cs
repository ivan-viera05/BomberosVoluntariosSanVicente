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
   
    public partial class PlanillaTareas : Form
    { NegocioTareas negocio = new NegocioTareas();
        public PlanillaTareas()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PlanillaTareas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource=negocio.ObtenerTareas();

        }
    }
}
