using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato
{
    public class DatoRopero
    {
        public bool AgregarPrenda(string nombre, string tipoPrenda, string talla, string estado, string codigoPrenda,
                                  string codigoBombero, string materialPrincipal, bool resistenciaAlCalor,
                                  DateTime fechaAdquisicion, string marca, string modelo)
        {
            string query = "INSERT INTO Prendas (Nombre, TipoPrenda, Talla, Estado, CodigoPrenda, CodigoBombero, MaterialPrincipal, ResistenciaAlCalor, FechaAdquisicion, Marca, Modelo) " +
                           "VALUES (@Nombre, @TipoPrenda, @Talla, @Estado, @CodigoPrenda, @CodigoBombero, @MaterialPrincipal, @ResistenciaAlCalor, @FechaAdquisicion, @Marca, @Modelo)";

            
                SqlCommand command = new SqlCommand(query, Conexion.conectar());
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@TipoPrenda", tipoPrenda);
                command.Parameters.AddWithValue("@Talla", talla);
                command.Parameters.AddWithValue("@Estado", estado);
                command.Parameters.AddWithValue("@CodigoPrenda", codigoPrenda);
                command.Parameters.AddWithValue("@CodigoBombero", codigoBombero);
                command.Parameters.AddWithValue("@MaterialPrincipal", materialPrincipal);
                command.Parameters.AddWithValue("@ResistenciaAlCalor", resistenciaAlCalor);
                command.Parameters.AddWithValue("@FechaAdquisicion", fechaAdquisicion);
                command.Parameters.AddWithValue("@Marca", marca);
                command.Parameters.AddWithValue("@Modelo", modelo);

                try
                {
                    
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        public DataTable ObtenerPrendas()
        {
            string query = "SELECT * FROM Prendas";

           
                SqlCommand command = new SqlCommand(query, Conexion.conectar());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dtPrendas = new DataTable();

                try
                {
                   
                    adapter.Fill(dtPrendas);
                }
                catch (Exception)
                {
                    // Manejar la excepción según sea necesario
                }

                return dtPrendas;
            }
        public DataTable BuscarPrendas(string nombre, string tipoPrenda, string codigoPrenda, string talla, string estado, string codigoBombero,
                                       string materialPrincipal, bool? resistenciaAlCalor, DateTime? fechaAdquisicion, string marca, string modelo)
        {
            DataTable dtPrendas = new DataTable();
            string query = @"SELECT * FROM Prendas WHERE
                             (@Nombre IS NULL OR Nombre LIKE '%' + @Nombre + '%') AND
                             (@TipoPrenda IS NULL OR TipoPrenda = @TipoPrenda) AND
                             (@CodigoPrenda IS NULL OR CodigoPrenda = @CodigoPrenda) AND
                             (@Talla IS NULL OR Talla = @Talla) AND
                             (@Estado IS NULL OR Estado = @Estado) AND
                             (@CodigoBombero IS NULL OR CodigoBombero = @CodigoBombero) AND
                             (@MaterialPrincipal IS NULL OR MaterialPrincipal = @MaterialPrincipal) AND
                             (@ResistenciaAlCalor IS NULL OR ResistenciaAlCalor = @ResistenciaAlCalor) AND
                             (@FechaAdquisicion IS NULL OR FechaAdquisicion = @FechaAdquisicion) AND
                             (@Marca IS NULL OR Marca LIKE '%' + @Marca + '%') AND
                             (@Modelo IS NULL OR Modelo LIKE '%' + @Modelo + '%')";

           
                SqlCommand command = new SqlCommand(query, Conexion.conectar());
                command.Parameters.AddWithValue("@Nombre", string.IsNullOrEmpty(nombre) ? (object)DBNull.Value : nombre);
                command.Parameters.AddWithValue("@TipoPrenda", string.IsNullOrEmpty(tipoPrenda) ? (object)DBNull.Value : tipoPrenda);
                command.Parameters.AddWithValue("@CodigoPrenda", string.IsNullOrEmpty(codigoPrenda) ? (object)DBNull.Value : codigoPrenda);
                command.Parameters.AddWithValue("@Talla", string.IsNullOrEmpty(talla) ? (object)DBNull.Value : talla);
                command.Parameters.AddWithValue("@Estado", string.IsNullOrEmpty(estado) ? (object)DBNull.Value : estado);
                command.Parameters.AddWithValue("@CodigoBombero", string.IsNullOrEmpty(codigoBombero) ? (object)DBNull.Value : codigoBombero);
                command.Parameters.AddWithValue("@MaterialPrincipal", string.IsNullOrEmpty(materialPrincipal) ? (object)DBNull.Value : materialPrincipal);
                command.Parameters.AddWithValue("@ResistenciaAlCalor", resistenciaAlCalor.HasValue ? (object)resistenciaAlCalor : DBNull.Value);
                command.Parameters.AddWithValue("@FechaAdquisicion", fechaAdquisicion.HasValue ? (object)fechaAdquisicion : DBNull.Value);
                command.Parameters.AddWithValue("@Marca", string.IsNullOrEmpty(marca) ? (object)DBNull.Value : marca);
                command.Parameters.AddWithValue("@Modelo", string.IsNullOrEmpty(modelo) ? (object)DBNull.Value : modelo);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                try
                {
                   
                    adapter.Fill(dtPrendas);
                }
                catch (Exception)
                {
                    // Manejo de errores
                }

                return dtPrendas;
            }
        
    }
}
