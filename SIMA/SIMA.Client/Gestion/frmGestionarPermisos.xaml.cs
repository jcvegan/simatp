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
    /// Lógica de interacción para frmGestionarPermisos.xaml
    /// </summary>
    public partial class frmGestionarPermisos : UserControl
    {
        PermisoDataLogic permisoLogic;
        EstadoDataLogic estadoLogic;
        

        public frmGestionarPermisos()
        {
            InitializeComponent();
        }

        private void gvPermisos_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangeEventArgs e)
        {
            if (gvPermisos.SelectedItem != null)
            {
                lblEstado.Visibility = Visibility.Visible;
                cmbEstado.Visibility = Visibility.Visible;
                T_C_Permiso temp = gvPermisos.SelectedItem as T_C_Permiso;

                for (int i = 0; i <= cmbEstado.Items.Count - 1; i++)
                {
                    if ((cmbEstado.Items[i] as T_C_Estado).Id_Estado == temp.Id_Estado)
                    {
                        cmbEstado.SelectedIndex = i;
                        break;
                    }
                }

                txtNombre.Text = temp.Nombre;
                txtDescripción.Text = temp.Descripcion;
                btnActualizar.IsEnabled = true;
                btnEliminar.IsEnabled = true;
                btnLimpiar.IsEnabled = true;
                btnRegistrar.IsEnabled = false;
                lblEstado.Visibility = Visibility.Visible;
                cmbEstado.Visibility = Visibility.Visible;
                
                
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
            permisoLogic = new PermisoDataLogic();
            estadoLogic = new EstadoDataLogic();
            btnActualizar.IsEnabled = false;
            btnEliminar.IsEnabled = false;
            btnLimpiar.IsEnabled = false;
            //cmbEstado.Visibility = Visibility.Visible;
            //lblEstado.Visibility = Visibility.Visible;
            cmbEstado.ItemsSource = estadoLogic.ListarEstadosPorTabla("T_C_Permiso");
            gvPermisos.ItemsSource = permisoLogic.ListarPermisos();
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            T_C_Permiso permiso = new T_C_Permiso();
            permiso.Nombre = txtNombre.Text;
            permiso.Descripcion = txtDescripción.Text;
            MessageBox.Show(permisoLogic.AgregarPermiso(permiso));
            gvPermisos.ItemsSource = permisoLogic.ListarPermisos();
            Limpia();
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            T_C_Permiso permiso = gvPermisos.SelectedItem as T_C_Permiso;
            permiso.Nombre = txtNombre.Text;
            permiso.Descripcion = txtDescripción.Text;
            permiso.Id_Estado = (cmbEstado.SelectedItem as T_C_Estado).Id_Estado;
            MessageBox.Show(permisoLogic.ActualizarPermiso(permiso));
            gvPermisos.ItemsSource = permisoLogic.ListarPermisos();
            Limpia();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            T_C_Permiso permiso = gvPermisos.SelectedItem as T_C_Permiso;
            MessageBox.Show(permisoLogic.EliminarPermiso(permiso));
            gvPermisos.ItemsSource = permisoLogic.ListarPermisos();
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
            gvPermisos.SelectedItem = null;
            txtDescripción.Text = string.Empty;
            txtNombre.Text = string.Empty;
            cmbEstado.SelectedItem = null;
        }

        private void cmbEstado_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
