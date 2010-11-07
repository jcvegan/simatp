using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.Entities;
using SIMA.DataAccess;

namespace SIMA.Logic
{
    public class TablaDataLogic
    {
        private TablaDataAccess tablaAccess;

        public TablaDataLogic()
        {
            tablaAccess = new TablaDataAccess();
        }

        public List<T_C_Tabla> ListarTablas()
        {
            return tablaAccess.SeleccionarTodosTabla();
        }

        public string AgregarTabla(T_C_Tabla tabla)
        {
            try
            {
                if (tabla.Descripcion_Tabla == "" || tabla.Nombre_Tabla == "")
                {
                    throw new Exception();
                }
                else
                {
                    return tablaAccess.AgregarTabla(tabla);
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string ActualizarTabla(T_C_Tabla tabla)
        {
            try
            {
                if (tabla.Descripcion_Tabla == "" || tabla.Nombre_Tabla == "")
                {
                    throw new Exception();
                }
                else
                {
                    return tablaAccess.ActualizarTabla(tabla);
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string EliminarTabla(T_C_Tabla tabla)
        {
            try
            {
                if (tabla.Descripcion_Tabla == "" || tabla.Nombre_Tabla == "")
                {
                    throw new Exception();
                }
                else
                {
                    return tablaAccess.EliminarTabla(tabla);
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
