using CapaDato;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegocioAsistencia
    {
       private DatosAsistencias datos = new DatosAsistencias();
     

        public DataTable obtenerDatos()
        {
            return datos.ObtenerTodosLosClientes();
        }

        public void RegistrarEntrada(int codigoBombero)
        {
            DateTime horaEntrada = DateTime.Now;
             datos.InsertarAsistencia(codigoBombero, horaEntrada);
        }

        public void RegistrarSalida(int codigoBombero)
        {
            DateTime horaSalida = DateTime.Now;
            datos.RegistrarSalida(codigoBombero, horaSalida);
        }
        public DataTable ObtenerAsistenciaPorFecha(DateTime fecha)
        {
            return datos.ObtenerAsistenciaPorFecha(fecha);
        }
    }
}
