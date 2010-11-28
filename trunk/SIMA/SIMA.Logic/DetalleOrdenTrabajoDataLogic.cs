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
        private OrdenTrabajoDataAccess ordentrabajoAccess;

        public DetalleOrdenTrabajoDataLogic()
        {
            detallerordentrabajoAccess = new DetalleOrdenDeTrabajoDataAccess();
        }

        public string AgregarDetalleOrdenTrabajo(T_C_DetalleOrdenDeTrabajo detalleordentrabajo, List<T_C_DetalleOrdenDeTrabajo> detalles)
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
                else
                {
                    int id = 0;
                    detallerordentrabajoAccess.AgregarDetalleOrdenDeTrabajo(detalleordentrabajo,out id);

                    double CostoTotal = 0;

                    foreach (T_C_DetalleOrdenDeTrabajo detalle in detalles)
                    {
                        detalle.Id_OrdendeTrabajo = id;

                        if (detalle.Cantidad > equipoAccess.SeleccionarEquipo(detalle.IdEquipo).Stock)
                        {
                            return "La cantidad no debe ser mayor a stock.";
                        }

                        else
                        {
                            detalle.Costo = detalle.Cantidad * equipoAccess.SeleccionarEquipo(detalle.IdEquipo).Costo;
                            detallerordentrabajoAccess.AgregarDetalleOrdenDeTrabajo(detalle, out id);
                            CostoTotal = CostoTotal + detalle.Costo;
                        }
                    }

                    return detallerordentrabajoAccess.AgregarDetalleOrdenDeTrabajo(detalleordentrabajo, out id);
                }
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
