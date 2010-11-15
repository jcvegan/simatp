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

        public OrdenTrabajoDataLogic()
        {
            ordentrabajoAccess = new OrdenTrabajoDataAccess();
        }

        public string AgregarOrdenTrabajo(T_C_OrdenTrabajo ordentrabajo)
        {
            try
            {
                //if (ordentrabajo.Descripcion == string.Empty)
                //{
                //    throw new Exception();
                //}
                //if (ordentrabajo.CostoTotal <= 0)
                //{
                //    throw new Exception();
                //}  
                //if (ordentrabajo.Id_Estado <= 0)
                //{
                //    throw new Exception();
                //}
                return ordentrabajoAccess.AgregarOrdenTrabajo(ordentrabajo);
            }
            catch
            {
                return "Error al ingresar datos.";
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
                if (ordentrabajo.CostoTotal <= 0)
                {
                    throw new Exception();
                }
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
