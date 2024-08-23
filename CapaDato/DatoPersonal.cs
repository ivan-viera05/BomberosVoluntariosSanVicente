using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato
{
    public class DatoPersonal
    {
        public DataTable ObtenerTodosLosPersonales()
        {
           
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Personal", Conexion.conectar()))
                {
                  
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }          
        }
        public bool ModificarPersona(int codigoPersona, string nombre, string apellido, string sexo, string jerarquia, string telefono, string direccion, string email, string estado)
        {
           
                string query = "UPDATE Personal SET Nombre = @Nombre, Apellido = @Apellido, Sexo = @Sexo, jerarquia = @Jerarquia, telefono = @Telefono, direccion = @Direccion, email = @Email, estado = @Estado WHERE CodigoPersona = @CodigoPersona";
                SqlCommand command = new SqlCommand(query,Conexion.conectar());
                command.Parameters.AddWithValue("@CodigoPersona", codigoPersona);
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Apellido", apellido);
                command.Parameters.AddWithValue("@Sexo", sexo);
                command.Parameters.AddWithValue("@Jerarquia", jerarquia);
                command.Parameters.AddWithValue("@Telefono", telefono);
                command.Parameters.AddWithValue("@Direccion", direccion);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Estado", estado);

               
                int result = command.ExecuteNonQuery();
                return result > 0;
            
        }
        public bool EliminarPersona(int codigoPersona)
        {
                Conexion.conectar();
                string query = "DELETE FROM Personal WHERE CodigoPersona = @CodigoPersona";
                SqlCommand command = new SqlCommand(query, Conexion.conectar());
                command.Parameters.AddWithValue("@CodigoPersona", codigoPersona);
                
                int result = command.ExecuteNonQuery();
                return result > 0;
            
        }
        public DataRow ObtenerPersonaPorCodigo(int codigoPersona)
        {
           
                string query = "SELECT * FROM Personal WHERE CodigoPersona = @CodigoPersona";
                SqlCommand command = new SqlCommand(query, Conexion.conectar());
                command.Parameters.AddWithValue("@CodigoPersona", codigoPersona);
                
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0];
                }
                else
                {
                    return null;
                }
            
        }
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
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Personal WHERE DNI = @dni AND CodigoPersona = @codigoPersona", Conexion.conectar());
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
        public DataTable BuscarPersonal(string nombre, string apellido, int? codigoBombero, string jerarquia, string sexo, string telefono, string direccion, string estado, string email)
        {
            StringBuilder query = new StringBuilder("SELECT * FROM Personal WHERE 1=1");

            if (!string.IsNullOrEmpty(nombre))
                query.Append(" AND Nombre LIKE @Nombre");
            if (!string.IsNullOrEmpty(apellido))
                query.Append(" AND Apellido LIKE @Apellido");
            if (codigoBombero.HasValue)
                query.Append(" AND CodigoPersona = @CodigoBombero");
            if (!string.IsNullOrEmpty(jerarquia))
                query.Append(" AND Jerarquia = @Jerarquia");
            if (!string.IsNullOrEmpty(sexo))
                query.Append(" AND Sexo = @Sexo");
            if (!string.IsNullOrEmpty(telefono))
                query.Append(" AND Telefono LIKE @Telefono");
            if (!string.IsNullOrEmpty(direccion))
                query.Append(" AND Direccion LIKE @Direccion");
            if (!string.IsNullOrEmpty(estado))
                query.Append(" AND Estado = @Estado");
            if (!string.IsNullOrEmpty(email))
                query.Append(" AND Email LIKE @Email");

              using (SqlCommand cmd = new SqlCommand(query.ToString(), Conexion.conectar()))
                {
                    if (!string.IsNullOrEmpty(nombre))
                        cmd.Parameters.AddWithValue("@Nombre", "%" + nombre + "%");
                    if (!string.IsNullOrEmpty(apellido))
                        cmd.Parameters.AddWithValue("@Apellido", "%" + apellido + "%");
                    if (codigoBombero.HasValue)
                        cmd.Parameters.AddWithValue("@CodigoBombero", codigoBombero.Value);
                    if (!string.IsNullOrEmpty(jerarquia))
                        cmd.Parameters.AddWithValue("@Jerarquia", jerarquia);
                    if (!string.IsNullOrEmpty(sexo))
                        cmd.Parameters.AddWithValue("@Sexo", sexo);
                    if (!string.IsNullOrEmpty(telefono))
                        cmd.Parameters.AddWithValue("@Telefono", "%" + telefono + "%");
                    if (!string.IsNullOrEmpty(direccion))
                        cmd.Parameters.AddWithValue("@Direccion", "%" + direccion + "%");
                    if (!string.IsNullOrEmpty(estado))
                        cmd.Parameters.AddWithValue("@Estado", estado);
                    if (!string.IsNullOrEmpty(email))
                        cmd.Parameters.AddWithValue("@Email", "%" + email + "%");

                    
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            
        }
    }
}
