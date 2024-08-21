using CapaDato;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegocioTareas
    {
        private DatosTareas tareas = new DatosTareas();

        

        public bool ValidarExistenciaBombero(int codigoBombero)
        {
            try
            {
                return tareas.ExisteBombero(codigoBombero);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al validar la existencia del bombero.", ex);
            }
        }

        public void AgregarTarea(int codigoBomberoAcargo, string bomberosParticipantes, string descripcionHecho, string estadoTarea, DateTime fechaAsignacion, DateTime fechaFinalizacion)
        {
            try
            {
                tareas.InsertarTarea(codigoBomberoAcargo, bomberosParticipantes, descripcionHecho, estadoTarea, fechaAsignacion, fechaFinalizacion);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar la tarea en la capa de negocio.", ex);
            }
        }

        public bool ModificarTarea(int tareaId, string descripcion, string estado, DateTime fechaAsignacion, DateTime? fechaFinalizacion)
        {
            try
            {
                return tareas.ModificarTarea(tareaId, descripcion, estado, fechaAsignacion, fechaFinalizacion);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar la tarea.", ex);
            }
        }

        public DataTable ObtenerTareas()
        {
            try
            {
                return tareas.ObtenerTareas();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las tareas.", ex);
            }
        }
    }
}
