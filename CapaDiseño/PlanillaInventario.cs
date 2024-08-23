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
    public partial class PlanillaInventario : Form
    {
        private NegocioInventario negocio = new NegocioInventario();
        public PlanillaInventario()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PlanillaInventario_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource= negocio.ObtenerHerramientas();
        }
    }
}
