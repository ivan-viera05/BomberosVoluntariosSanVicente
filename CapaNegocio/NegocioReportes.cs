using CapaDato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegocioReportes
    {
        private datosReporte datosReportes = new datosReporte();

        public void AgregarReporte(int codigobombero, string tipoReporte, string descripcion, DateTime fechaReporte, string observaciones)
        {
            try
            {
                if (!datosReportes.ExisteBombero(codigobombero))
                {
                    throw new Exception("El bombero con el código proporcionado no existe.");
                }

                datosReportes.InsertarReporte(codigobombero, tipoReporte, descripcion, fechaReporte, observaciones);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el reporte. Verifique que los datos ingresados sean correctos.", ex);
            }
        }
    }
}
