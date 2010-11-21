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
        private EquipoDataAccess equipoAccess;

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

                if (detalleordentrabajo.Cantidad > equipoAccess.SeleccionarEquipo(detalleordentrabajo.IdEquipo).Stock)
                {
                    return "La cantidad no debe ser mayor a stock.";
                }

                if (detalleordentrabajo.Cantidad <= 0)
                {
                    return "Ingresar una cantidad mayor a 0.";
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
