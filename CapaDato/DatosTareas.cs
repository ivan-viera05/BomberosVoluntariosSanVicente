using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato
{
    public class DatosTareas
    {
        public bool ExisteBombero(int codigoBombero)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Personal WHERE CodigoPersona = @CodigoBombero", Conexion.conectar()))
                {
                    cmd.Parameters.AddWithValue("@CodigoBombero", codigoBombero);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al verificar la existencia del bombero en la base de datos.", ex);
            }
        }

        public void InsertarTarea(int codigoBomberoAcargo, string bomberosParticipantes, string descripcionHecho, string estadoTarea, DateTime fechaAsignacion, DateTime fechaFinalizacion)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Tareas (CodigoBombero, BomberosParticipantes, DescripcionHecho, EstadoTarea, FechaAsignacion, FechaFinalizacion) VALUES (@CodigoBomberoAcargo, @BomberosParticipantes, @DescripcionHecho, @EstadoTarea, @FechaAsignacion, @FechaFinalizacion)", Conexion.conectar()))
                {
                    cmd.Parameters.AddWithValue("@CodigoBomberoAcargo", codigoBomberoAcargo);
                    cmd.Parameters.AddWithValue("@BomberosParticipantes", bomberosParticipantes);
                    cmd.Parameters.AddWithValue("@DescripcionHecho", descripcionHecho);
                    cmd.Parameters.AddWithValue("@EstadoTarea", estadoTarea);
                    cmd.Parameters.AddWithValue("@FechaAsignacion", fechaAsignacion);
                    cmd.Parameters.AddWithValue("@FechaFinalizacion", fechaFinalizacion);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al insertar la tarea en la base de datos.", ex);
            }
        }

        public bool ModificarTarea(int tareaId, string descripcion, string estado, DateTime fechaAsignacion, DateTime? fechaFinalizacion)
        {
            try
            {
                string query = "UPDATE Tareas SET DescripcionHecho = @DescripcionHecho, EstadoTarea = @EstadoTarea, FechaAsignacion = @FechaAsignacion, FechaFinalizacion = @FechaFinalizacion WHERE IdTarea = @IdTarea";
                using (SqlCommand cmd = new SqlCommand(query, Conexion.conectar()))
                {
                    cmd.Parameters.AddWithValue("@IdTarea", tareaId);
                    cmd.Parameters.AddWithValue("@DescripcionHecho", descripcion);
                    cmd.Parameters.AddWithValue("@EstadoTarea", estado);
                    cmd.Parameters.AddWithValue("@FechaAsignacion", fechaAsignacion);
                    cmd.Parameters.AddWithValue("@FechaFinalizacion", (object)fechaFinalizacion ?? DBNull.Value);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al modificar la tarea en la base de datos.", ex);
            }
        }

        public DataTable ObtenerTareas()
        {
            try
            {
                string query = "SELECT * FROM Tareas";
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

    }
}
