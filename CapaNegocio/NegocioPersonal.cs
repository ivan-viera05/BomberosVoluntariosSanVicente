using CapaDato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CapaNegocio.NegocioPersonal;

namespace CapaNegocio
{
    public class NegocioPersonal
    {
         private DatoPersonal datos = new DatoPersonal();


        public bool Login(string dni, string codigoPersona)
        {
            // Lógica para verificar en la base de datos si existe una persona con ese DNI y código
            return datos.ValidarCredenciales(dni, codigoPersona);
        }
        public string ObtenerJerarquia(string dni)
        {
            // Lógica para obtener la jerarquía desde la base de datos
            return datos.ObtenerJerarquiaPorDni(dni);
        }

    }
}
