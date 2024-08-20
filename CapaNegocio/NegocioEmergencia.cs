using CapaDato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegocioEmergencia
    {
        private DatosEmergencia emergencia = new DatosEmergencia();

        public void GuardarEmergencia(int CodigoBomberoAcargo, string tipoEmergencia, string vehiculosAsignados, string direccionHecho,
                                      DateTime fechaHoraIngreso, DateTime fechaHoraSalida, string descripcionHecho,
                                      string accionesTomadas, string observaciones, List<int> bomberos)
        {
            DateTime fechaRegistro = DateTime.Now; // Setea la fecha de registro antes de guardar
            emergencia.InsertarEmergencia(CodigoBomberoAcargo, tipoEmergencia, vehiculosAsignados, direccionHecho,
                                          fechaHoraIngreso, fechaHoraSalida, descripcionHecho, accionesTomadas, observaciones, fechaRegistro, bomberos);
        }

        public void AgregarBomberoAEmergencia(int bomberoID, int emergenciaID)
        {
            emergencia.InsertarBomberoEnEmergencia(bomberoID, emergenciaID);
        }

        public bool ValidarExistenciaBombero(int bomberoID)
        {
            return emergencia.ExisteBombero(bomberoID);
        }
    }
}
