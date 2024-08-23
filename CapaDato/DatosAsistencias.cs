using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato
{
    public class DatosAsistencias
    {
        public void InsertarAsistencia(int codigoBombero, DateTime horaEntrada)
        {
            string query = @"
                INSERT INTO AsistenciaDiaria (jerarquia, nombre, apellido, Hora_Entrada, Codigo_bombero)
                SELECT p.jerarquia, p.Nombre, p.Apellido, @Hora_Entrada, p.CodigoPersona
                FROM Personal p
                WHERE p.CodigoPersona = @CodigoBombero";

            Conexion.conectar();
            using (SqlCommand cmd = new SqlCommand(query, Conexion.conectar()))
            {
                cmd.Parameters.AddWithValue("@CodigoBombero", codigoBombero);
                cmd.Parameters.AddWithValue("@Hora_Entrada", horaEntrada);
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable ObtenerTodosLosClientes()
        {
            using (SqlConnection conexion = Conexion.conectar())
            {
                string sql = "SELECT * FROM AsistenciaDiaria ";
                using (SqlCommand cmd = new SqlCommand(sql, conexion))
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

        public void RegistrarSalida(int codigoBombero, DateTime horaSalida)
        {
            string query = @"
                UPDATE AsistenciaDiaria
                SET Hora_Salida = @Hora_Salida
                WHERE Codigo_bombero = @CodigoBombero AND Hora_Salida IS NULL";

         
                using (SqlCommand cmd = new SqlCommand(query, Conexion.conectar()))
                {
                    cmd.Parameters.AddWithValue("@CodigoBombero", codigoBombero);
                    cmd.Parameters.AddWithValue("@Hora_Salida", horaSalida);
                    cmd.ExecuteNonQuery();
                }
            
        }

        public DataTable ObtenerAsistenciaPorFecha(DateTime fecha)
        {
            using (SqlConnection conexion = Conexion.conectar())
            {
                string sql = @"
                SELECT * FROM AsistenciaDiaria WHERE CONVERT(date, Hora_Entrada) = @Fecha";

                using (SqlCommand cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@Fecha", fecha.Date); // Solo la parte de la fecha, sin la hora
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
}
