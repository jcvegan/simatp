using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.DataAccess;
using SIMA.Entities;

namespace SIMA.Logic
{
    public class EquipoDataLogic
    {
        private EquipoDataAccess equipoAccess;

        public EquipoDataLogic()
        {
            equipoAccess = new EquipoDataAccess();
        }

        public string AgregarEquipo(T_C_Equipo equipo)
        {
            return equipoAccess.AgregarEquipo(equipo);
        }
        public List<T_C_Equipo> ListarActivos()
        {
            return equipoAccess.ListarEquiposActivos();
        }
    }
}
