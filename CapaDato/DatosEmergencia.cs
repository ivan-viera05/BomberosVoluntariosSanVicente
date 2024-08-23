using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato
{
    public class DatosEmergencia
    {


        public void InsertarEmergencia(int CodigoBomberoAcargo, string tipoEmergencia, string vehiculosAsignados, string direccionHecho,
                                  DateTime fechaHoraIngreso, DateTime fechaHoraSalida, string descripcionHecho,
                                  string accionesTomadas, string observaciones, DateTime fechaRegistro, List<int> bomberos)
        {
            using (SqlConnection conexion = Conexion.conectar())
            {
                string query = "INSERT INTO Emergencias (TipoEmergencia, VehiculosAsignados, DireccionHecho, FechaHoraIngreso, FechaHoraSalida, DescripcionHecho, AccionesTomadas, Observaciones, FechaRegistro, CodigoPersonaAcargo) " +
                               "OUTPUT INSERTED.EmergenciaID " +
                               "VALUES (@TipoEmergencia, @VehiculosAsignados, @DireccionHecho, @FechaHoraIngreso, @FechaHoraSalida, @DescripcionHecho, @AccionesTomadas, @Observaciones, @FechaRegistro, @CodigoBomberoAcargo)";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@CodigoBomberoAcargo", CodigoBomberoAcargo);
                cmd.Parameters.AddWithValue("@TipoEmergencia", tipoEmergencia);
                cmd.Parameters.AddWithValue("@VehiculosAsignados", vehiculosAsignados ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@DireccionHecho", direccionHecho);
                cmd.Parameters.AddWithValue("@FechaHoraIngreso", fechaHoraIngreso);
                cmd.Parameters.AddWithValue("@FechaHoraSalida", fechaHoraSalida);
                cmd.Parameters.AddWithValue("@DescripcionHecho", descripcionHecho ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@AccionesTomadas", accionesTomadas ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Observaciones", observaciones ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@FechaRegistro", fechaRegistro);

                int emergenciaID = (int)cmd.ExecuteScalar();

                foreach (var bombero in bomberos)
                {
                    InsertarBomberoEnEmergencia(emergenciaID, bombero);
                }
            }
        }

        public void InsertarBomberoEnEmergencia(int emergenciaID, int bomberoID)
        {
            using (SqlConnection conexion = Conexion.conectar())
            {
                string query = "INSERT INTO EmergenciaBombero (EmergenciaID, CodigoBombero) VALUES (@EmergenciaID, @CodigoBombero)";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@EmergenciaID", emergenciaID);
                cmd.Parameters.AddWithValue("@CodigoBombero", bomberoID);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ObtenerTareas()
        {
            try
            {
                string query = "SELECT * FROM Emergencias";
                using (SqlCommand cmd = new SqlCommand(query, Conexion.conectar()))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al obtener las tareas de la base de datos.", ex);
            }
        }

        public bool ExisteBombero(int bomberoID)
        {
            using (SqlConnection conexion = Conexion.conectar())
            {
                string query = "SELECT COUNT(*) FROM Personal WHERE CodigoPersona = @CodigoBombero";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@CodigoBombero", bomberoID);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
    }
}
