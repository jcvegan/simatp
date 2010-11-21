using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.DataAccess;
using SIMA.Entities;

namespace SIMA.Logic
{
    public class OrdenTrabajoDataLogic 
    {
        private OrdenTrabajoDataAccess ordentrabajoAccess;
        private DetalleOrdenDeTrabajoDataAccess detalleOrdenAccess;
        private EquipoDataAccess equipoAccess;
        T_C_Equipo equipo = new T_C_Equipo();
        
        public OrdenTrabajoDataLogic()
        {
            ordentrabajoAccess = new OrdenTrabajoDataAccess();
            equipoAccess = new EquipoDataAccess();
            detalleOrdenAccess = new DetalleOrdenDeTrabajoDataAccess();
        }

        public string AgregarOrdenTrabajo(T_C_OrdenTrabajo ordentrabajo,List<T_C_DetalleOrdenDeTrabajo> detalles)
        {
            try
            {
                int id = 0;
                ordentrabajoAccess.AgregarOrdenTrabajo(ordentrabajo, out id);

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
                        detalleOrdenAccess.AgregarDetalleOrdenDeTrabajo(detalle);
                        CostoTotal = CostoTotal + detalle.Costo;
                    }
                    
                }

                ordentrabajo = ordentrabajoAccess.SeleccionarOrdenTrabajo(id);
                ordentrabajo.UltimaFechaModificacion = DateTime.Now;
                ordentrabajo.CostoTotal = CostoTotal;

                ordentrabajoAccess.ActualizarOrdenTrabajo(ordentrabajo);
                return "Orden de trabajo registrado satisfactoriamente";
            }
            catch (Exception ex)
            {
                return "";
            } 
        }

        public string ActualizarOrdenTrabajo(T_C_OrdenTrabajo ordentrabajo)
        {
            try
            {
                if (ordentrabajo.Descripcion == string.Empty)
                {
                    throw new Exception();
                }
                //if (ordentrabajo.CostoTotal < 0)
                //{
                //    throw new Exception();
                //}
                if (ordentrabajo.Id_Estado <= 0)
                {
                    throw new Exception();
                }
                return ordentrabajoAccess.ActualizarOrdenTrabajo(ordentrabajo);
            }
            catch
            {
                return "Error al ingresar datos.";
            }
        }

        public string EliminarOrdenTrabajo(T_C_OrdenTrabajo ordentrabajo)
        {
            return ordentrabajoAccess.EliminarOrdenTrabajo(ordentrabajo);
        }

        public List<T_C_OrdenTrabajo> ListarOrdenesTrabajo()
        {
            return ordentrabajoAccess.SeleccionarTodosOrdenTrabajo();
        }

        public List<T_C_OrdenTrabajo> ListarOrdenesTrabajoPorEstado()
        {
            return ordentrabajoAccess.SeleccionarOrdenTrabajoPorEstado();
        }

        public List<T_C_OrdenTrabajo> ListarOrdenesTrabajoPorUsuario()
        {
            return ordentrabajoAccess.SeleccionarOrdenTrabajoPorUsuario();
        }

        public List<T_C_OrdenTrabajo> ListarOrdenTrabajo()
        {
            return ordentrabajoAccess.SeleccionarOrdenTrabajo();
        }
    }
}
