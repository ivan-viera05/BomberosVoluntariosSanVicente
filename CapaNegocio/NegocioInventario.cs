using CapaDato;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegocioInventario
    {
        private DatosInventarios datos = new DatosInventarios();

        public bool AltaHerramienta(string codigoHerramienta, string nombreHerramienta, string categoria, string ubicacion, int cantidad, decimal costo, DateTime fechaAdquisicion, string estado)
        {
            // Aquí puedes agregar validaciones o lógica adicional si es necesario

            return datos.InsertarHerramienta(codigoHerramienta, nombreHerramienta, categoria, ubicacion, cantidad, costo, fechaAdquisicion, estado);
        }
        public DataTable ObtenerHerramientas()
        {
            return datos.ObtenerInventario();
        }

    }
}
