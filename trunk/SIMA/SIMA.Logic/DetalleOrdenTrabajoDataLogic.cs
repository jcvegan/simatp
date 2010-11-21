using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.DataAccess;
using SIMA.Entities;

namespace SIMA.Logic
{
    public class DetalleOrdenTrabajoDataLogic
    {
        private DetalleOrdenDeTrabajoDataAccess detallerordentrabajoAccess;

        public DetalleOrdenTrabajoDataLogic()
        {
            detallerordentrabajoAccess = new DetalleOrdenDeTrabajoDataAccess();
        }

        public string AgregarDetalleOrdenTrabajo(T_C_DetalleOrdenDeTrabajo detalleordentrabajo)
        {
            try
            {
                if (detalleordentrabajo.Costo == 0)
                {
                    throw new Exception();
                }
                return detallerordentrabajoAccess.AgregarDetalleOrdenDeTrabajo(detalleordentrabajo);
            }
            catch
            {
                return "Error al ingresar datos.";
            }
        }

        public List<T_C_DetalleOrdenDeTrabajo> ListarDetalles()
        {
            return detallerordentrabajoAccess.SeleccionarDetallePorEstado();
        }
    }
}
