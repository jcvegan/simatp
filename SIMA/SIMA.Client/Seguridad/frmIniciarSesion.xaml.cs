using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SIMA.Logic;
using SIMA.Entities;
namespace SIMA.Client.Seguridad
{
    /// <summary>
    /// Lógica de interacción para frmIniciarSesion.xaml
    /// </summary>
    public partial class frmIniciarSesion : UserControl
    {
        //UsuarioDataLogic usuario = new UsuarioDataLogic();
        T_C_Usuario eUsuario = new T_C_Usuario();
        public frmIniciarSesion()
        {
            InitializeComponent();
        }

        private void RadButton_Click(object sender, RoutedEventArgs e)
        {
            string email = txtUsuario.Text;
            string contrasenia = txtContraseña.Password;
           //eUsuario  = usuario.SeleccionarTabla(email, contrasenia); 
            

        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
