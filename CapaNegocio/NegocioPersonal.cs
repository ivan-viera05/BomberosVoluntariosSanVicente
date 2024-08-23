using CapaDato;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CapaNegocio.NegocioPersonal;

namespace CapaNegocio
{
    public class NegocioPersonal
    {
         private DatoPersonal datos = new DatoPersonal();



        public DataTable ObtenerTodosLosPersonales()
        {
            return datos.ObtenerTodosLosPersonales();
        }




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


        public bool AgregarPersonal(string nombre, string apellido, string sexo, string jerarquia, int codigoPersona, int telefono, string direccion, string estado, string email, string especialidad, string dni)
        {
            // Validaciones de negocio
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido))
            {
                throw new Exception("El nombre y apellido son obligatorios");
            }

            // Llamar a la capa de datos
            return datos.AgregarPersonal(nombre, apellido, sexo, jerarquia, codigoPersona, telefono, direccion, estado, email, especialidad, dni);
        }


        public DataTable BuscarPersonal(string nombre, string apellido, int? codigoBombero, string jerarquia, string sexo, string telefono, string direccion, string estado, string email)
        {
            return datos.BuscarPersonal(nombre, apellido, codigoBombero, jerarquia, sexo, telefono, direccion, estado, email);
        }


        public bool ModificarPersona(int codigoPersona, string nombre, string apellido, string sexo, string jerarquia, string telefono, string direccion, string email, string estado)
        {
            return datos.ModificarPersona(codigoPersona, nombre, apellido, sexo, jerarquia, telefono, direccion, email, estado);
        }

        public bool EliminarPersona(int codigoPersona)
        {
            return datos.EliminarPersona(codigoPersona);
        }

        public DataRow ObtenerPersonaPorCodigo(int codigoPersona)
        {
            return datos.ObtenerPersonaPorCodigo(codigoPersona);
        }
    }
}
