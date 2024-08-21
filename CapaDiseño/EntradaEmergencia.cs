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
    public partial class EntradaEmergencia : Form
    {
        private NegocioEmergencia Emergencia = new NegocioEmergencia();
        private List<int> bomberosList = new List<int>();
        public EntradaEmergencia()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EntradaEmergencia_Load(object sender, EventArgs e)
        {

        }

        private void btnIdentificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores directamente de los controles del formulario
                int CodigoBomberoAcargo = int.Parse(txtCodigoBomberoAcargo.Text);
                string tipoEmergencia = cbTipoEmergencia.Text;
                string vehiculosAsignados = cbVehiculosAsignados.Text;
                string direccionHecho = txtDireccionHecho.Text;
                DateTime fechaHoraIngreso = dtpFechaHoraIngreso.Value;
                DateTime fechaHoraSalida = dtpFechaHoraSalida.Value;
                string descripcionHecho = txtDescripcionHecho.Text;
                string accionesTomadas = txtAccionesTomadas.Text;
                string observaciones = txtObservaciones.Text;

                // Llamar al método de negocio pasando los valores directamente
                Emergencia.GuardarEmergencia(CodigoBomberoAcargo, tipoEmergencia, vehiculosAsignados, direccionHecho,
                                               fechaHoraIngreso, fechaHoraSalida, descripcionHecho, accionesTomadas, observaciones, bomberosList);

                MessageBox.Show("Emergencia registrada exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al registrar la emergencia: {ex.Message}");
            }
        }

        private void btnAgregarBombero_Click(object sender, EventArgs e)
        {
            int bomberoID;

            if (int.TryParse(txtCodigoBombero.Text, out bomberoID))
            {
                // Validar que el bombero existe en la base de datos
                if (Emergencia.ValidarExistenciaBombero(bomberoID))
                {
                    if (!bomberosList.Contains(bomberoID))
                    {
                        bomberosList.Add(bomberoID);
                        listBoxBomberos.Items.Add(bomberoID.ToString());
                    }
                    else
                    {
                        MessageBox.Show("El bombero ya ha sido añadido.");
                    }
                }
                else
                {
                    MessageBox.Show("El código de bombero no existe en la base de datos.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un código de bombero válido.");
            }

            txtCodigoBombero.Clear();
        }

        private void listBoxBomberos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
