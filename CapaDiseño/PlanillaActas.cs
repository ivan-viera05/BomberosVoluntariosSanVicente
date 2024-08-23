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
    public partial class PlanillaActas : Form
    {
        NegocioEmergencia negocio = new NegocioEmergencia();
        public PlanillaActas()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PlanillaActas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = negocio.ObtenerEmergencias();
        }
    }
}
