using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato
{
    public class DatoPersonal
    {
        public bool ValidarCredenciales(string dni, string codigoPersona)
        {
          
            
                Conexion.conectar();
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Personal WHERE DNI = @dni AND CodigoPersona = @codigoPersona",Conexion.conectar());
                command.Parameters.AddWithValue("@dni", dni);
                command.Parameters.AddWithValue("@codigoPersona", codigoPersona);

                int count = (int)command.ExecuteScalar();
                return count > 0;
            
        }

        // Método para obtener la jerarquía por DNI
        public string ObtenerJerarquiaPorDni(string dni)
        {
            
                Conexion.conectar();
                SqlCommand command = new SqlCommand("SELECT Jerarquia FROM Personal WHERE DNI = @dni", Conexion.conectar());
                command.Parameters.AddWithValue("@dni", dni);

                string jerarquia = (string)command.ExecuteScalar();
                return jerarquia;
            
        }
    }
}
