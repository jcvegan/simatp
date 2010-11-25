using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.DataAccess;
using SIMA.Entities;

namespace SIMA.Logic
{
    public class PermisosPorPerfilDataLogic
    {
        private PermisosPorPerfilDataAccess perxPerfilAccess;

        public PermisosPorPerfilDataLogic()
        {
            perxPerfilAccess = new PermisosPorPerfilDataAccess();
        }

        public List<T_C_Permiso> ListarPermisosPorPerfil(int idPerfil)
        {
            return perxPerfilAccess.SeleccionarPermisosPorPerfil(idPerfil);
        }
    }
}
