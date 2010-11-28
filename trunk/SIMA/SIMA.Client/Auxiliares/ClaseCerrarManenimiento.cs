using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIMA.Client.Auxiliares
{
    class ClaseCerrarManenimiento
    {
        private int Id_Mantenimiento;

        public int id_mantenimiento
        {
            get { return Id_Mantenimiento; }
            set { Id_Mantenimiento = value; }
        }

        private DateTime FechaTrabajoInicio;

        public DateTime fechatrabajoinicio
        {
            get { return FechaTrabajoInicio; }
            set { FechaTrabajoInicio = value; }
        }
        private string Id_Equipo;

        public string id_equipo
        {
            get { return Id_Equipo; }
            set { Id_Equipo = value; }
        }
        private string Descripcion;

        public string descripcion
        {
            get { return Descripcion; }
            set { Descripcion = value; }
        }
        private string Usuario;

        public string usuario
        {
            get { return Usuario; }
            set { Usuario = value; }
        }
        private DateTime FechaTrabajoFin;

        public DateTime fechatrabajofin
        {
            get { return FechaTrabajoFin; }
            set { FechaTrabajoFin = value; }
        }

    }
}
