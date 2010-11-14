using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.Entities;
using SIMA.DataAccess;

namespace SIMA.Logic
{
    public class TipoMantenimientoDataLogic
    {
        private TipoMantenimientoDataAccess TipoMantenimientoAccess;

        public TipoMantenimientoDataLogic()
        {
            TipoMantenimientoAccess = new TipoMantenimientoDataAccess();
        }

        public string AgregarTipoMantenimiento(T_C_TipoMantenimiento TipoMantenimiento)
        {
            try
            {
                if (TipoMantenimiento.Nombre == string.Empty)
                {
                    throw new Exception("El nombre esta en blanco");
                }
                if (TipoMantenimiento.Descripcion == string.Empty)
                {
                    throw new Exception("La descripcion esta en blanco");
                }

                return TipoMantenimientoAccess.AgregarTipoMantenimiento(TipoMantenimiento);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string ActualizarTipoMantenimiento(T_C_TipoMantenimiento TipoMantenimiento)
        {
            try
            {
                if (TipoMantenimiento.Nombre == string.Empty)
                {
                    throw new Exception("El nombre esta en blanco");
                }
                if (TipoMantenimiento.Descripcion == string.Empty)
                {
                    throw new Exception("La descripcion esta en blanco");
                }
                if (TipoMantenimiento.Id_Estado <= 0)
                {
                    throw new Exception("Seleccione un estado");
                }
                return TipoMantenimientoAccess.ActualizarTipoMantenimiento(TipoMantenimiento);
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public string EliminarTipoMantenimiento(T_C_TipoMantenimiento TipoMantenimiento)
        {
            return TipoMantenimientoAccess.EliminarTipoMantenimiento(TipoMantenimiento);
        }

        public List<T_C_TipoMantenimiento> ListarTipoMantenimiento()
        {
            return TipoMantenimientoAccess.SeleccionarTodosTipoMantenimiento();
        }

    }
}
