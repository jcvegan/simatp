using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.DataAccess;
using SIMA.Entities;

namespace SIMA.Logic
{
    public class TipoMantenimientoPorEquipoDataLogic
    {
        private TipoMantenimientoPorEquipoDataAccess tipManXEquipoAccess;

        public TipoMantenimientoPorEquipoDataLogic()
        {
            tipManXEquipoAccess = new TipoMantenimientoPorEquipoDataAccess();
        }

        public List<T_C_TipoMantenimiento> ListarMantenimientosActivosPorEquipo(string idEquipo)
        {
            return tipManXEquipoAccess.SeleccionarTiposMantenimientoPorEquipo(idEquipo);
        }
    }
}
