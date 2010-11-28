using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.Entities;
using SIMA.DataAccess;

namespace SIMA.Logic
{
    public class PermisoDataLogic
    {
        private PermisoDataAccess permisoAccess;

        public PermisoDataLogic()
        {
            permisoAccess = new PermisoDataAccess();
        }
       
        public string AgregarPermiso(T_C_Permiso permiso)
        {
            try
            {
                if (permiso.Nombre == string.Empty)
                {
                    throw new Exception();
                }
                return permisoAccess.AgregarPermiso(permiso);
            }
            catch
            {
                return "Error al ingresar datos.";
            }

        }

        public string ActualizarPermiso(T_C_Permiso permiso)
        {
            try
            {
                if (permiso.Nombre == string.Empty)
                {
                    throw new Exception();
                }
                if (permiso.Id_Estado <= 0)
                {
                    throw new Exception();
                }
                return permisoAccess.ActualizarPermiso(permiso);
            }
            catch
            {
                return "Error al ingresar datos.";
            }
        }

        public string EliminarPermiso(T_C_Permiso permiso)
        {
            return permisoAccess.EliminarPermiso(permiso);
        }

        public List<T_C_Permiso> ListarPermisos()
        {
            return permisoAccess.SeleccionarTodosPermisos();
        }

    }
}
