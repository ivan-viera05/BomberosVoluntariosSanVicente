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
using PdfSharp.Drawing;
using PdfSharp.Pdf;

using System.IO;



namespace CapaDiseño
{
    public partial class PlanillaAsistencia : Form
    {
      
        NegocioAsistencia negocio = new NegocioAsistencia();
        private System.Drawing.Image logo;
        private string logoPath = @"C:\BomberosSanVicente\BomberosSanVicente\CapaDiseño\Resources\LogoBomberos.png";


        public PlanillaAsistencia()
        {
            InitializeComponent();
            if (System.IO.File.Exists(logoPath))
            {
                logo = System.Drawing.Image.FromFile(logoPath);
            }
        }
     
        private void PlanillaAsistencia_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = negocio.obtenerDatos();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void ExportarDataGridViewAPDF(DataGridView dtgv, string nombreArchivo, DateTimePicker dateTimePicker)
        {
            PdfDocument pdf = new PdfDocument();
            pdf.Info.Title = "Asistencia Diaria";

            PdfPage pdfPage = pdf.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(pdfPage);

            XFont titleFont = new XFont("Verdana", 10);
            XFont headerFont = new XFont("Verdana", 8);
            XFont contentFont = new XFont("Verdana", 8);

            XUnit margin = XUnit.FromPoint(80);
            XUnit yPoint = margin;

            // Dibujar el logo
            if (logo != null)
            {
                XImage xLogo;
                using (var ms = new MemoryStream())
                {
                    logo.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    ms.Seek(0, SeekOrigin.Begin);
                    xLogo = XImage.FromStream(ms);
                }
                gfx.DrawImage(xLogo, margin, yPoint, XUnit.FromPoint(60), XUnit.FromPoint(60));
            }

            // Agregar título
            gfx.DrawString("BOMBEROS VOLUNTARIOS DE SAN VICENTE", titleFont, XBrushes.Black,
                new XRect(0, yPoint.Point + 20, pdfPage.Width, 40), XStringFormats.TopCenter);

            gfx.DrawString("ASISTENCIA DIARIA", headerFont, XBrushes.Black,
                new XRect(0, yPoint.Point + 60, pdfPage.Width, 20), XStringFormats.TopCenter);

            // Agregar fecha
            string fecha = "FECHA: " + dateTimePicker.Value.ToString("dd/MM/yyyy");
            gfx.DrawString(fecha, contentFont, XBrushes.Black,
                new XRect(pdfPage.Width - margin.Point - 150, yPoint.Point + 60, 150, 20), XStringFormats.TopLeft);

            yPoint += XUnit.FromPoint(100);

            // Calcular ancho de columnas
            XUnit columnWidth = (pdfPage.Width - 2 * margin.Point) / dtgv.Columns.Count;
            XUnit xPoint = margin;

            // Dibujar encabezado de tabla
            gfx.DrawRectangle(XPens.Black, margin, yPoint, pdfPage.Width - 2 * margin.Point, XUnit.FromPoint(20));

            string[] headers = { "JERARQUIA", "NOMBRE", "APELLIDO", "H. ENTRADA", "H. SALIDA", "CODIGO BOMBERO" };
            for (int i = 0; i < headers.Length; i++)
            {
                gfx.DrawString(headers[i], headerFont, XBrushes.Black,
                    new XRect(xPoint.Point, yPoint.Point, columnWidth.Point, 20), XStringFormats.Center);
                xPoint += columnWidth;
            }

            yPoint += XUnit.FromPoint(20);

            // Dibujar filas de la tabla
            foreach (DataGridViewRow row in dtgv.Rows)
            {
                if (row.IsNewRow) continue;

                xPoint = margin;
                gfx.DrawRectangle(XPens.Black, margin, yPoint, pdfPage.Width - 2 * margin.Point, XUnit.FromPoint(20));

                for (int i = 0; i < dtgv.Columns.Count; i++)
                {
                    string cellText = row.Cells[i].Value?.ToString() ?? string.Empty;

                    // Verifica si la columna es "H. ENTRADA" o "H. SALIDA"
                    if (dtgv.Columns[i].HeaderText.Contains("Hora_Entrada") || dtgv.Columns[i].HeaderText.Contains("Hora_Salida"))
                    {
                        if (DateTime.TryParse(cellText, out DateTime dateTimeValue))
                        {
                            // Solo mostrar la hora
                            cellText = dateTimeValue.ToString("HH:mm:ss");
                        }
                    }

                    // Verificar si la columna es "nombre" o "apellido" y asignar adecuadamente
                    if (dtgv.Columns[i].HeaderText == "nombre")
                    {
                        gfx.DrawString(cellText, contentFont, XBrushes.Black,
                            new XRect(xPoint.Point, yPoint.Point, columnWidth.Point, 20), XStringFormats.Center);
                        xPoint += columnWidth;
                    }
                    else if (dtgv.Columns[i].HeaderText == "apellido")
                    {
                        gfx.DrawString(cellText, contentFont, XBrushes.Black,
                            new XRect(xPoint.Point, yPoint.Point, columnWidth.Point, 20), XStringFormats.Center);
                        xPoint += columnWidth;
                    }
                    else
                    {
                        gfx.DrawString(cellText, contentFont, XBrushes.Black,
                            new XRect(xPoint.Point, yPoint.Point, columnWidth.Point, 20), XStringFormats.Center);
                        xPoint += columnWidth;
                    }
                }

                yPoint += XUnit.FromPoint(20);
            }

            // Guardar el documento
            pdf.Save(nombreArchivo);

            MessageBox.Show("El archivo PDF se ha generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }





        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener la fecha seleccionada en el DateTimePicker y formatearla
            string fecha = dateTimePicker1.Value.ToString("ddMMyyyy");

            // Concatenar la fecha al nombre base del archivo
            string nombreArchivo = "AsistenciaDiaria_" + fecha + ".pdf";

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF Files (*.pdf)|*.pdf",
                DefaultExt = "pdf",
                FileName = nombreArchivo // Usar el nombre con la fecha incluida
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportarDataGridViewAPDF(dataGridView1, saveFileDialog.FileName, dateTimePicker1);
            }
        }

         private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
         {
            DateTime fechaSeleccionada = dateTimePicker1.Value;
            dataGridView1.DataSource = negocio.ObtenerAsistenciaPorFecha(fechaSeleccionada);

         }
    }
}
