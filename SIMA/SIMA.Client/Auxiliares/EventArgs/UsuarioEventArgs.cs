using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.Entities;

namespace SIMA.Client.Auxiliares.EventArgs
{
    public class UsuarioEventArgs:System.EventArgs
    {
        private T_C_Usuario usuario;
        private DateTime fechaInicioSesion;


        public DateTime FechaInicioSesion
        {
            get { return fechaInicioSesion; }
        }
        
        public T_C_Usuario Usuario
        {
            get { return usuario; }
        }
        public UsuarioEventArgs(T_C_Usuario usuario)
        {
            this.usuario = usuario;
            this.fechaInicioSesion = DateTime.Now;
        }
    }
}
