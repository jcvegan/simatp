using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.Entities;

namespace SIMA.Client.Auxiliares.EventArgs
{
    public class TipoMantenimientoEventArgs:System.EventArgs
    {
        private List<T_C_TipoMantenimiento> tiposDeMantenimiento;


        public List<T_C_TipoMantenimiento> TiposDeMantenimiento
        {
            get { return tiposDeMantenimiento; }
            set { tiposDeMantenimiento = value; }
        }


        public TipoMantenimientoEventArgs(List<T_C_TipoMantenimiento> tipos)
        {
            tiposDeMantenimiento = tipos;
        }
    }
}
