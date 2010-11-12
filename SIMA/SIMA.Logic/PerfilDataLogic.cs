using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.Entities;
using SIMA.DataAccess;

namespace SIMA.Logic
{
    public class PerfilDataLogic
    {
        private PerfilDataAccess perfilAccess;

        public PerfilDataLogic()
        {
            perfilAccess = new PerfilDataAccess();
        }

        public string AgregarPerfil(T_C_Perfil perfil)
        {
            try
            {
                if (perfil.Nombre == string.Empty)
                {
                    throw new Exception();
                }
                return perfilAccess.AgregarPerfil(perfil);
            }
            catch
            {
                return "Error al ingresar datos.";
            }
            
        }

        public string ActualizarPerfil(T_C_Perfil perfil)
        {
            try
            {
                if (perfil.Nombre == string.Empty)
                {
                    throw new Exception();
                }
                if (perfil.Id_Estado <= 0)
                {
                    throw new Exception();
                }
                return perfilAccess.ActualizarPerfil(perfil);
            }
            catch
            {
                return "Error al ingresar datos.";
            }
        }

        public string EliminarPerfil(T_C_Perfil perfil)
        {
            return perfilAccess.EliminarPerfil(perfil);
        }

        public List<T_C_Perfil> ListarPerfiles()
        {
            return perfilAccess.SeleccionarTodosPerfil();
        }
    }
}
