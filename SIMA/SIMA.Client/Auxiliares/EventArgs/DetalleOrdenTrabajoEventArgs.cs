using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.Entities;
using SIMA.Logic;

namespace SIMA.Client.Auxiliares.EventArgs
{
    public class DetalleOrdenTrabajoEventArgs:System.EventArgs
    {
        private List<T_C_DetalleOrdenDeTrabajo> detalleOrden;

        public List<T_C_DetalleOrdenDeTrabajo> DetalleOrden
        {
            get { return detalleOrden; }            
        }

        public DetalleOrdenTrabajoEventArgs(List<T_C_DetalleOrdenDeTrabajo> _detalleOrden)
        {
            detalleOrden = _detalleOrden;
        }
    }
}
