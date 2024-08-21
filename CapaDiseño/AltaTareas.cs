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
    public partial class AltaTareas : Form
    {
        private List<int> bomberosList = new List<int>();
        private NegocioTareas negocio = new NegocioTareas();
        public AltaTareas()
        {
            InitializeComponent();
        }
        NegocioEmergencia Emergencia = new NegocioEmergencia();
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarBombero_Click(object sender, EventArgs e)
        {
            int bomberoID;

            if (int.TryParse(txtCodigoBombero.Text, out bomberoID))
            {
                // Validar que el bombero existe en la base de datos
                if (negocio.ValidarExistenciaBombero(bomberoID))
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

        private void txtDescripcionHecho_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            try
            {
                int codigoBomberoAcargo;
                if (!int.TryParse(txtCodigoBomberoAcargo.Text, out codigoBomberoAcargo))
                {
                    MessageBox.Show("Por favor, ingrese un código de bombero a cargo válido.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!negocio.ValidarExistenciaBombero(codigoBomberoAcargo))
                {
                    MessageBox.Show("El código de bombero a cargo no existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string bomberosParticipantes = string.Join(",", bomberosList);
                string descripcionHecho = txtDescripcionHecho.Text;
                string estadoTarea = cmbEstadoTarea.SelectedItem?.ToString();
                DateTime fechaAsignacion = dtpFechaAsignacion.Value;
                DateTime fechaFinalizacion = dtpFechaFinalizacion.Value;

                negocio.AgregarTarea(codigoBomberoAcargo, bomberosParticipantes, descripcionHecho, estadoTarea, fechaAsignacion, fechaFinalizacion);

                MessageBox.Show("Tarea agregada con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al agregar la tarea. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbEstadoTarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Comprueba si el primer o segundo ítem está seleccionado
            if (cmbEstadoTarea.SelectedIndex == 0 || cmbEstadoTarea.SelectedIndex == 1)
            {
                dtpFechaFinalizacion.Visible = false;  // Oculta la fecha de finalización
                label7.Visible = false;
            }
            else
            {
                dtpFechaFinalizacion.Visible = true;  // Muestra la fecha de finalización
            }
        }
    }
}
