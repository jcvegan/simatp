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
    /// Lógica de interacción para frmGestionarTipoMantenimiento.xaml
    /// </summary>
    public partial class frmGestionarTipoMantenimiento : UserControl
    {
        TipoMantenimientoDataLogic TipoMantenimientoLogic;
        EstadoDataLogic estadoLogic;

        public frmGestionarTipoMantenimiento()
        {
            InitializeComponent();
            lblEstado.Visibility = Visibility.Hidden;
            cmbEstado.Visibility = Visibility.Hidden;

        }

        private void gvTipoMantenimiento_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangeEventArgs e)
        {
            if (gvTipoMantenimiento.SelectedItem != null)
            {
                btnRegistrar.IsEnabled = false;
                btnActualizar.IsEnabled = true;
                btnEliminar.IsEnabled = true;
                btnLimpiar.IsEnabled = true;
                lblEstado.Visibility = Visibility.Visible;
                cmbEstado.Visibility = Visibility.Visible;
                T_C_TipoMantenimiento temp = gvTipoMantenimiento.SelectedItem as T_C_TipoMantenimiento;
                txtDescripción.Text = temp.Descripcion;
                txtNombre.Text = temp.Nombre;
                for (int i = 0; i <= cmbEstado.Items.Count; i++)
                {
                    if ((cmbEstado.Items[i] as T_C_Estado).Id_Estado == temp.Id_Estado)
                    {
                        cmbEstado.SelectedIndex = i;
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
            TipoMantenimientoLogic = new TipoMantenimientoDataLogic();
            estadoLogic = new EstadoDataLogic();
            btnActualizar.IsEnabled = false;
            btnEliminar.IsEnabled = false;
            btnLimpiar.IsEnabled = false;
            //cmbEstado.Visibility = Visibility.Visible;
            //lblEstado.Visibility = Visibility.Visible;
            cmbEstado.ItemsSource = estadoLogic.ListarEstadosPorTabla("T_C_TipoMantenimiento");
            gvTipoMantenimiento.ItemsSource = TipoMantenimientoLogic.ListarTipoMantenimiento();
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            T_C_TipoMantenimiento TipoMantenimiento = new T_C_TipoMantenimiento();
            TipoMantenimiento.Nombre = txtNombre.Text;
            TipoMantenimiento.Descripcion = txtDescripción.Text;
            MessageBox.Show(TipoMantenimientoLogic.AgregarTipoMantenimiento(TipoMantenimiento));
            gvTipoMantenimiento.ItemsSource = TipoMantenimientoLogic.ListarTipoMantenimiento();
            Limpia();
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            T_C_TipoMantenimiento TipoMantenimiento = gvTipoMantenimiento.SelectedItem as T_C_TipoMantenimiento;
            TipoMantenimiento.Nombre = txtNombre.Text;
            TipoMantenimiento.Descripcion = txtDescripción.Text;
            TipoMantenimiento.Id_Estado = (cmbEstado.SelectedItem as T_C_Estado).Id_Estado;
            MessageBox.Show(TipoMantenimientoLogic.ActualizarTipoMantenimiento(TipoMantenimiento));
            gvTipoMantenimiento.ItemsSource = TipoMantenimientoLogic.ListarTipoMantenimiento();
            Limpia();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            T_C_TipoMantenimiento TipoMantenimiento = gvTipoMantenimiento.SelectedItem as T_C_TipoMantenimiento;
            MessageBox.Show(TipoMantenimientoLogic.EliminarTipoMantenimiento(TipoMantenimiento));
            gvTipoMantenimiento.ItemsSource = TipoMantenimientoLogic.ListarTipoMantenimiento();
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
            gvTipoMantenimiento.SelectedItem = null;
            txtDescripción.Text = string.Empty;
            txtNombre.Text = string.Empty;
            cmbEstado.SelectedItem = null;
        }
    }
}
