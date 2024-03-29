﻿using System;
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
        public List<T_C_Equipo> ListarTodos()
        {
            return equipoAccess.ListarEquipos();
        }
        public T_C_Equipo SeleccionarEquipo(string Id_Equipo)
        {
            return equipoAccess.SeleccionarEquipo(Id_Equipo);
        }
        public List<T_C_Equipo> ListarEquiposEnMantenimiento()
        {
            return equipoAccess.ListarEquiposEnMantenimiento();
        }

        public string ActualizarEquipo(T_C_Equipo equipo) 
        {
            return equipoAccess.ActualizarEquipo(equipo);
        }

        public int BuscaEstadoActivo()
        {
            return equipoAccess.BuscarEstadoActivo();
        }

    }
}
