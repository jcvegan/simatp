using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.Entities;

namespace SIMA.Client.Auxiliares.EventArgs
{
    public class EquipoPadreEventArgs : System.EventArgs
    {
        private T_C_Equipo equipoSeleccionado;

        public EquipoPadreEventArgs(T_C_Equipo equiposseleccionado)
        {
            equipoSeleccionado = equiposseleccionado;
        }

        public T_C_Equipo EquipoSeleccionado
        {
            get { return equipoSeleccionado; }
            set { equipoSeleccionado = value; }
        }

    }
}
