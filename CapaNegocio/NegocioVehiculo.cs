using CapaDato;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegocioVehiculo
    {
        DatosVehiculos negocio = new DatosVehiculos();

        public DataTable obtenerVehiculos()
        {
          return  negocio.ObtenerVehiculos();

        }
    }
}
