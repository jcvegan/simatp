using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.Entities;
using SIMA.DataAccess;

namespace SIMA.Logic
{
    public class AreaDataLogic
    {
        AreaDataAccess areaAccess;

        public AreaDataLogic()
        {
            areaAccess = new AreaDataAccess();
        }

        public string AgregarArea(T_C_Area area)
        {
            return areaAccess.AgregarArea(area);
        }

        public string ActualizarArea(T_C_Area area)
        {
            return areaAccess.ActualizarArea(area);
        }

        public string EliminarArea(T_C_Area area)
        {
            return areaAccess.EliminarArea(area);
        }

        public List<T_C_Area> ListarAreas()
        {
            return areaAccess.SeleccionarTodosArea();
        }

        public List<T_C_Area> ListarActivosArea()
        {
            return areaAccess.SeleccionarActivosArea();
        }
    }
}
