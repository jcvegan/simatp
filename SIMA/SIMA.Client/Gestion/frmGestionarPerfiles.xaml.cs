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
    /// Lógica de interacción para frmGestionarPerfiles.xaml
    /// </summary>
    public partial class frmGestionarPerfiles : UserControl
    {
        PerfilDataLogic perfilLogic;
        EstadoDataLogic estadoLogic;
        

        public frmGestionarPerfiles()
        {
            InitializeComponent();
        }

        private void gvPerfiles_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangeEventArgs e)
        {
            if (gvPerfiles.SelectedItem != null)
            {
                lblEstado.Visibility = Visibility.Visible;
                cmbEstado.Visibility = Visibility.Visible;
                T_C_Perfil temp = gvPerfiles.SelectedItem as T_C_Perfil;
                txtNombre.Text = temp.Nombre;
                txtDescripción.Text = temp.Descripcion;
                btnActualizar.IsEnabled = true;
                btnEliminar.IsEnabled = true;
                btnLimpiar.IsEnabled = true;
                btnRegistrar.IsEnabled = false;
                for (int i = 0; i <= cmbEstado.Items.Count - 1; i++)
                {
                    if ((cmbEstado.Items[i] as T_C_Estado) == temp.Estado)
                    {
                        cmbEstado.SelectedIndex = 1;
                        break;
                    }
                }
            }
            else
            {
                lblEstado.Visibility = Visibility.Hidden;
                cmbEstado.Visibility = Visibility.Hidden;
                btnActualizar.IsEnabled = false;
                btnEliminar.IsEnabled = false;
                btnLimpiar.IsEnabled = false;
                btnRegistrar.IsEnabled = true;
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            perfilLogic = new PerfilDataLogic();
            estadoLogic = new EstadoDataLogic();
            btnActualizar.IsEnabled = false;
            btnEliminar.IsEnabled = false;
            btnLimpiar.IsEnabled = false;
            //cmbEstado.Visibility = Visibility.Visible;
            //lblEstado.Visibility = Visibility.Visible;
            cmbEstado.ItemsSource = estadoLogic.ListarEstadosPorTabla("T_C_Perfil");
            gvPerfiles.ItemsSource = perfilLogic.ListarPerfiles();
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            T_C_Perfil perfil = new T_C_Perfil();
            perfil.Nombre = txtNombre.Text;
            perfil.Descripcion = txtDescripción.Text;
            MessageBox.Show(perfilLogic.AgregarPerfil(perfil));
            gvPerfiles.ItemsSource = perfilLogic.ListarPerfiles();
            Limpia();
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            T_C_Perfil perfil = gvPerfiles.SelectedItem as T_C_Perfil;
            perfil.Nombre = txtNombre.Text;
            perfil.Descripcion = txtDescripción.Text;
            perfil.Id_Estado = (cmbEstado.SelectedItem as T_C_Estado).Id_Estado;
            MessageBox.Show(perfilLogic.ActualizarPerfil(perfil));
            gvPerfiles.ItemsSource = perfilLogic.ListarPerfiles();
            Limpia();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            T_C_Perfil perfil = gvPerfiles.SelectedItem as T_C_Perfil;
            MessageBox.Show(perfilLogic.EliminarPerfil(perfil));
            gvPerfiles.ItemsSource = perfilLogic.ListarPerfiles();
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
            gvPerfiles.SelectedItem = null;
            txtDescripción.Text = string.Empty;
            txtNombre.Text = string.Empty;
            cmbEstado.SelectedItem = null;
        }
    }
}
