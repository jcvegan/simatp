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
using Telerik.Windows.Controls;
using SIMA.Client.Auxiliares.EventArgs;

namespace SIMA.Client.Seguridad
{
    /// <summary>
    /// Lógica de interacción para frmIniciarSesion.xaml
    /// </summary>
    public partial class frmIniciarSesion : RadWindow
    {
        //UsuarioDataLogic usuario = new UsuarioDataLogic();
        UsuarioDataLogic usuarioLogic;
        public event EventHandler<UsuarioEventArgs> UsuarioValidado;
        public event EventHandler NoAcreditado;

        public frmIniciarSesion()
        {
            InitializeComponent();
            usuarioLogic = new UsuarioDataLogic();
        }

        private void RadButton_Click(object sender, RoutedEventArgs e)
        {
            if (txtUsuario.Text != string.Empty)
            {
                if (txtContraseña.Password != string.Empty)
                {
                    int idUsuario = Convert.ToInt32(txtUsuario.Text);
                    string contrasenia = txtContraseña.Password;
                    T_C_Usuario usuario = usuarioLogic.ValidaUsuario(idUsuario, contrasenia);
                    if (usuario != null)
                    {
                        if (UsuarioValidado != null)
                        {
                            UsuarioValidado(this, new UsuarioEventArgs(usuario));
                            txtContraseña.Clear();
                            txtUsuario.Clear();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Usuario validado");
                        }
                    }
                    else
                    {
                        if (NoAcreditado != null)
                        {
                            NoAcreditado(this, new EventArgs());
                        }
                        else
                        {
                            MessageBox.Show("Usuario Inválido");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese contraseña");
                }
            }
            else
            {
                MessageBox.Show("Ingrese código de usuario.");
            }
           //eUsuario  = usuario.SeleccionarTabla(email, contrasenia); 
            

        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
