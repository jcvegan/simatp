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

namespace SIMA.Client.Gestion
{
    /// <summary>
    /// Lógica de interacción para frmGestionarUsuarios.xaml
    /// </summary>
    public partial class frmGestionarUsuarios : UserControl
    {
        UsuarioDataLogic usuarioLogic;
        PerfilDataLogic perfilLogic;
        EstadoDataLogic estadoLogic;

        public frmGestionarUsuarios()
        {
            InitializeComponent();
            dtpFechaNacimiento.SelectedDateTime = new DateTime(1980, DateTime.Now.Month, DateTime.Now.Day);
            dtpFechaRegistro.SelectedDateTime = DateTime.Now.Date;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            usuarioLogic = new UsuarioDataLogic();
            perfilLogic = new PerfilDataLogic();
            estadoLogic = new EstadoDataLogic();
            btnActualizar.IsEnabled = false;
            btnEliminar.IsEnabled = false;
            btnLimpiar.IsEnabled = false;
            //cmbEstado.Visibility = Visibility.Visible;
            //lblEstado.Visibility = Visibility.Visible;
            cmbEstado.ItemsSource = estadoLogic.ListarEstadosPorTabla("T_C_Perfil");
            cmbPerfil.ItemsSource = perfilLogic.ListarPerfiles();
            gvUsuarios.ItemsSource = usuarioLogic.ListarUsuarios();
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            T_C_Usuario usuario = new T_C_Usuario();
            usuario.Nombres = txtNombres.Text;
            usuario.Apellidos = txtApellidos.Text;
            usuario.Contraseña = txtContraseña.Text;
            usuario.Direccion = txtDireccion.Text;
            usuario.Email = txtEmail.Text;
            usuario.Fecha_Nacimiento = dtpFechaNacimiento.SelectedDateTime.Value;
            usuario.Fecha_Registro = dtpFechaRegistro.SelectedDateTime.Value;
            usuario.Telefono = Convert.ToInt32(txtTelefono.Text);
            usuario.Id_Perfil = (cmbPerfil.SelectedItem as T_C_Perfil).Id_Perfil;

            MessageBox.Show(usuarioLogic.AgregarUsuario(usuario));
            gvUsuarios.ItemsSource = usuarioLogic.ListarUsuarios();
            Limpia();
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            T_C_Usuario usuario = gvUsuarios.SelectedItem as T_C_Usuario;
            usuario.Nombres = txtNombres.Text;
            usuario.Apellidos = txtApellidos.Text;
            usuario.Contraseña = txtContraseña.Text;
            usuario.Direccion = txtDireccion.Text;
            usuario.Email = txtEmail.Text;
            usuario.Fecha_Nacimiento = dtpFechaNacimiento.SelectedDateTime.Value;
            usuario.Fecha_Registro = dtpFechaRegistro.SelectedDateTime.Value;
            usuario.Telefono = Convert.ToInt32(txtTelefono.Text);

            usuario.Id_Estado = (cmbEstado.SelectedItem as T_C_Estado).Id_Estado;
            usuario.Id_Perfil = (cmbPerfil.SelectedItem as T_C_Perfil).Id_Perfil;

            MessageBox.Show(usuarioLogic.ActualizarUsuario(usuario));
            gvUsuarios.ItemsSource = usuarioLogic.ListarUsuarios();
            Limpia();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            T_C_Usuario usuario = gvUsuarios.SelectedItem as T_C_Usuario;
            MessageBox.Show(usuarioLogic.EliminarUsuario(usuario));
            gvUsuarios.ItemsSource = usuarioLogic.ListarUsuarios();
            Limpia();
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            Limpia();
        }

        private void Limpia()
        {
            lblEstado.Visibility = Visibility.Hidden;
            cmbEstado.Visibility = Visibility.Hidden;
            btnActualizar.IsEnabled = false;
            btnEliminar.IsEnabled = false;
            btnLimpiar.IsEnabled = false;
            btnRegistrar.IsEnabled = true;
            gvUsuarios.SelectedItem = null;
            txtNombres.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtContraseña.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtEmail.Text = string.Empty;
            dtpFechaNacimiento.SelectedDateTime = new DateTime(1980,DateTime.Now.Month, DateTime.Now.Day);
            dtpFechaRegistro.SelectedDateTime = DateTime.Now.Date;
            txtTelefono.Text = string.Empty;
            cmbPerfil.SelectedItem = null;
            cmbEstado.SelectedItem = null;
        }

        private void gvUsuarios_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangeEventArgs e)
        {
            if (gvUsuarios.SelectedItem != null)
            {
                lblEstado.Visibility = Visibility.Visible;
                cmbEstado.Visibility = Visibility.Visible;
                T_C_Usuario temp = gvUsuarios.SelectedItem as T_C_Usuario;
                txtNombres.Text = temp.Nombres;
                txtApellidos.Text = temp.Apellidos;
                txtTelefono.Text = temp.Telefono.ToString();
                txtDireccion.Text = temp.Direccion;
                dtpFechaRegistro.SelectedDateTime = temp.Fecha_Registro;
                dtpFechaNacimiento.SelectedDateTime = temp.Fecha_Nacimiento;
                txtEmail.Text = temp.Email;
                txtContraseña.Text = temp.Contraseña;

                btnActualizar.IsEnabled = true;
                btnEliminar.IsEnabled = true;
                btnLimpiar.IsEnabled = true;
                btnRegistrar.IsEnabled = false;
                for (int i = 0; i <= cmbEstado.Items.Count - 1; i++)
                {
                    if ((cmbEstado.Items[i] as T_C_Estado) == temp.Estado)
                    {
                        cmbEstado.SelectedIndex = i;
                        break;
                    }
                }
                for (int i = 0; i <= cmbPerfil.Items.Count - 1; i++)
                {
                    if ((cmbPerfil.Items[i] as T_C_Perfil) == temp.Perfil)
                    {
                        cmbPerfil.SelectedIndex = i;
                        break;
                    }
                }
            }
            else
            {
                //lblPerfil.Visibility = Visibility.Hidden;
                //cmbPerfil.Visibility = Visibility.Hidden;
                lblEstado.Visibility = Visibility.Hidden;
                cmbEstado.Visibility = Visibility.Hidden;
                btnActualizar.IsEnabled = false;
                btnEliminar.IsEnabled = false;
                btnLimpiar.IsEnabled = false;
                btnRegistrar.IsEnabled = true;
            }
        }
    }
}
