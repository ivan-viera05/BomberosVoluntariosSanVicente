using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato
{
    public class DatosInventarios
    {
        public bool InsertarHerramienta(string codigoHerramienta, string nombreHerramienta, string categoria, string ubicacion, int cantidad, decimal costo, DateTime fechaAdquisicion, string estado)
        {
            string query = @"INSERT INTO InventarioHerramientas 
                             (CodigoHerramienta, NombreHerramienta, Categoria, Ubicacion, Cantidad, Costo, FechaAdquisicion, Estado) 
                             VALUES 
                             (@CodigoHerramienta, @NombreHerramienta, @Categoria, @Ubicacion, @Cantidad, @Costo, @FechaAdquisicion, @Estado)";

            
                using (SqlCommand command = new SqlCommand(query, Conexion.conectar()))
                {
                    command.Parameters.AddWithValue("@CodigoHerramienta", codigoHerramienta);
                    command.Parameters.AddWithValue("@NombreHerramienta", nombreHerramienta);
                    command.Parameters.AddWithValue("@Categoria", categoria);
                    command.Parameters.AddWithValue("@Ubicacion", ubicacion);
                    command.Parameters.AddWithValue("@Cantidad", cantidad);
                    command.Parameters.AddWithValue("@Costo", costo);
                    command.Parameters.AddWithValue("@FechaAdquisicion", fechaAdquisicion);
                    command.Parameters.AddWithValue("@Estado", estado);

                    
                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
            
        }
        public DataTable ObtenerInventario()
        {

            using (SqlCommand cmd = new SqlCommand("SELECT * FROM InventarioHerramientas", Conexion.conectar()))
            {

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
