using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.Entities;

namespace SIMA.Logic
{
    public class UsuarioDataLogic
    {
        private UsuarioDataLogic estadoAccess;

        public UsuarioDataLogic()
        {
            estadoAccess = new UsuarioDataLogic();
        }
        public T_C_Usuario SeleccionarTabla(string Id_usuario, string Contrasenia)
        {
            return estadoAccess.SeleccionarTabla(Id_usuario, Contrasenia);
        }
    }
}
