using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIMA.Client.Auxiliares
{
    class ClaseConsultarEquiposaMantener
    {
        private int Id_Mantenimiento;

        public int id_Mantenimiento
        {
            get { return Id_Mantenimiento; }
            set { Id_Mantenimiento = value; }
        }
        private string Id_Equipo;

        public string id_Equipo
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
        private string Inicio;

        public string inicio
        {
            get { return Inicio; }
            set { Inicio = value; }
        }
        private string Fin;

        public string fin
        {
            get { return Fin; }
            set { Fin = value; }
        }
        private string Fecha;

        public string fecha
        {
            get { return Fecha; }
            set { Fecha = value; }
        }


    }
}
