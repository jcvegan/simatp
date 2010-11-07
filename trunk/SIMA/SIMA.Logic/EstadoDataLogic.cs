using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.DataAccess;
using SIMA.Entities;

namespace SIMA.Logic
{
    public class EstadoDataLogic
    {
        private EstadoDataAccess estadoAccess;

        public EstadoDataLogic()
        {
            estadoAccess = new EstadoDataAccess();
        }

        public string AgregarEstado(T_C_Estado estado)
        {
            try
            {
                if (estado.Id_Tabla < 1)
                {
                    throw new Exception();
                }
                else
                {
                    return estadoAccess.AgregarEstado(estado);
                }
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public List<T_C_Estado> ListarEstados()
        {
            return estadoAccess.SeleccionarTodosEstado();
        }

        public string EliminarEstado(T_C_Estado estado)
        {
            return estadoAccess.EliminarEstado(estado);
        }
    }
}
