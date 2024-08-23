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
    public partial class ModificarTareas : Form
    {
        private List<int> bomberosList = new List<int>();
        private NegocioTareas negocio = new NegocioTareas();
        public ModificarTareas()
        {
            InitializeComponent();
            LlenarDataGridView();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigoBomberoAcargo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarTarea_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvTareas.SelectedRows.Count > 0)
                {
                    int rowIndex = dgvTareas.CurrentCell.RowIndex;
                    int tareaId = Convert.ToInt32(dgvTareas.Rows[rowIndex].Cells["IdTarea"].Value);

                    string descripcion = txtDescripcion.Text;
                    string estado = cmbEstadoTarea.SelectedItem.ToString();
                    DateTime fechaAsignacion = dtpFechaAsignacion.Value;
                    DateTime? fechaFinalizacion = dtpFechaFinalizacion.Visible ? (DateTime?)dtpFechaFinalizacion.Value : null;

                    bool exito = negocio.ModificarTarea(tareaId, descripcion, estado, fechaAsignacion, fechaFinalizacion);

                    if (exito)
                    {
                        MessageBox.Show("Tarea modificada exitosamente.");
                        LlenarDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar la tarea.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una tarea para modificar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }


        private void LlenarDataGridView()
        {
            try
            {
                DataTable dtTareas = negocio.ObtenerTareas();

                if (dtTareas != null)
                {
                    dgvTareas.DataSource = dtTareas;
                }
                else
                {
                    MessageBox.Show("No se pudieron cargar las tareas.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar las tareas: " + ex.Message);
            }
        }



        private void btnAgregarBombero_Click(object sender, EventArgs e)
        {
            int bomberoID;

            if (int.TryParse(txtCodigoBombero.Text, out bomberoID))
            {
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

        private void txtCodigoBombero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
