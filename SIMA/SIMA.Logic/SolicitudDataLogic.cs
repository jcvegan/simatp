using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.DataAccess;
using SIMA.Entities;

namespace SIMA.Logic
{
    public class SolicitudDataLogic
    {
        private SolicitudDataAccess solicitudAccess;

        public SolicitudDataLogic()
        {
            solicitudAccess = new SolicitudDataAccess();
        }
        
        public string AgregarSolicitud(T_C_Solicitud solicitud)
        {
            return solicitudAccess.AgregarSolicitud(solicitud);
        }

        public string AgregarDetalleSolicitud(T_C_DetalleSolicitud Detallesolicitud)
        {
            return solicitudAccess.AgregarDetalleSolicitud(Detallesolicitud);
        }

        public List<T_C_Solicitud> SeleccionarTodosSolicitud()         
        {
            return solicitudAccess.SeleccionarTodosSolicitud();
        }
    }
}
