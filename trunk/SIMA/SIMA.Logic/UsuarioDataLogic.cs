using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.Entities;
using SIMA.DataAccess;

namespace SIMA.Logic
{
    public class UsuarioDataLogic
    {
        private UsuarioDataAccess usuarioAccess;

        public UsuarioDataLogic()
        {
            usuarioAccess = new UsuarioDataAccess();
        }

        public T_C_Usuario SeleccionarTabla(string Id_usuario, string Contrasenia)
        {
            return usuarioAccess.SeleccionarTabla(Id_usuario, Contrasenia);
        }

        public T_C_Usuario ValidaUsuario(int Id_Usuario, string Contraseña)
        {
            if (Id_Usuario == 0 && Contraseña == string.Empty)
            {
                return null;
            }
            else
            {
                return usuarioAccess.ValidarUsuario(Id_Usuario, Contraseña);
            }
        }
        public string AgregarUsuario(T_C_Usuario usuario)
        {
            return usuarioAccess.AgregarUsuario(usuario);
        }

        public List<T_C_Usuario> ListarUsuarios()
        {
            return usuarioAccess.SeleccionarTodosUsuario();
        }

        public string ActualizarUsuario(T_C_Usuario usuario)
        {
            try
            {
                if (usuario.Nombres == string.Empty || usuario.Apellidos == string.Empty)
                {
                    throw new Exception();
                }
                if (usuario.Id_Perfil <= 0)
                {
                    throw new Exception();
                }
                if (usuario.Id_Estado <= 0)
                {
                    throw new Exception();
                }
                return usuarioAccess.ActualizarUsuario(usuario);
            }
            catch
            {
                return "Error al ingresar datos.";
            }
        }

        public string EliminarUsuario(T_C_Usuario usuario)
        {
            return usuarioAccess.EliminarUsuario(usuario);
        }
    }
}
