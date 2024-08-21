using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato
{
    public class datosReporte
    {
        public void InsertarReporte(int codigobombero, string tipoReporte, string descripcion, DateTime fechaReporte, string observaciones)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO ReportesBomberos (BomberoID, TipoReporte, Descripcion, FechaReporte, Observaciones) VALUES (@codigobombero, @TipoReporte, @Descripcion, @FechaReporte, @Observaciones)", Conexion.conectar()))
                {
                    cmd.Parameters.AddWithValue("@codigobombero", codigobombero);
                    cmd.Parameters.AddWithValue("@TipoReporte", tipoReporte);
                    cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@FechaReporte", fechaReporte);
                    cmd.Parameters.AddWithValue("@Observaciones", observaciones ?? (object)DBNull.Value);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al insertar el reporte en la base de datos.", ex);
            }
        }

        public bool ExisteBombero(int codigobombero)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(1) FROM Personal WHERE CodigoPersona = @codigobombero", Conexion.conectar()))
                {
                    cmd.Parameters.AddWithValue("@codigobombero", codigobombero);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al verificar la existencia del bombero en la base de datos.", ex);
            }
        }
    }
}
