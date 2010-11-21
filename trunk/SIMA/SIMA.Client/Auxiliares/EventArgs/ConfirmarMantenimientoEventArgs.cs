using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.Entities;

namespace SIMA.Client.Auxiliares.EventArgs
{
    public class ConfirmarMantenimientoEventArgs : System.EventArgs
    {
        private T_C_Mantenimiento matenimiento;

        public ConfirmarMantenimientoEventArgs(T_C_Mantenimiento Matenimientos)
        {
            matenimiento = Matenimientos;
        }

        public T_C_Mantenimiento Matenimiento
        {
            get { return matenimiento; }
            set { matenimiento = value; }
        }

    }
}
