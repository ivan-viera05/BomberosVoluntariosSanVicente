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

        public bool AgregarPersonal(string nombre, string apellido, string sexo, string jerarquia, int codigoPersona, int telefono, string direccion, string estado, string email, string especialidad, string dni)
        {
           
                string query = "INSERT INTO Personal (Nombre, Apellido, Sexo, Jerarquia, CodigoPersona, Telefono, Direccion, Estado, Email, Especialidad, DNI) " +
                               "VALUES (@Nombre, @Apellido, @Sexo, @Jerarquia, @CodigoPersona, @Telefono, @Direccion, @Estado, @Email, @Especialidad, @DNI)";

                SqlCommand command = new SqlCommand(query, Conexion.conectar());

                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Apellido", apellido);
                command.Parameters.AddWithValue("@Sexo", sexo);
                command.Parameters.AddWithValue("@Jerarquia", jerarquia);
                command.Parameters.AddWithValue("@CodigoPersona", codigoPersona);
                command.Parameters.AddWithValue("@Telefono", telefono);
                command.Parameters.AddWithValue("@Direccion", direccion);
                command.Parameters.AddWithValue("@Estado", estado);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Especialidad", especialidad);
                command.Parameters.AddWithValue("@DNI", dni);

                try
                {
                    
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    // Mostrar el mensaje de error completo en la capa de datos
                    throw new Exception("Error en la base de datos: " + ex.Message);
                }
            
        }

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
