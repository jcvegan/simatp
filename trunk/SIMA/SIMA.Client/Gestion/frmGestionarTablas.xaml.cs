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
    /// Lógica de interacción para frmGestionarTablas.xaml
    /// </summary>
    public partial class frmGestionarTablas : UserControl
    {
        TablaDataLogic tablaLogic;
        public frmGestionarTablas()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            tablaLogic = new TablaDataLogic();
            gvTablas.ItemsSource = tablaLogic.ListarTablas();
            btnActualizar.IsEnabled = false;
            btnEliminar.IsEnabled = false;
            btnLimpiar.IsEnabled = false;
        }

        private void gvTablas_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangeEventArgs e)
        {
            if (gvTablas.SelectedItem != null)
            {
                btnRegistrar.IsEnabled = false;
                btnActualizar.IsEnabled = true;
                btnEliminar.IsEnabled = true;
                btnLimpiar.IsEnabled = true;
                T_C_Tabla temp = gvTablas.SelectedItem as T_C_Tabla;
                txtNombre.Text = temp.Nombre_Tabla;
                txtDescripción.Text = temp.Descripcion_Tabla;
            }
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            gvTablas.SelectedItem = null;
            txtNombre.Text = string.Empty;
            txtDescripción.Text = string.Empty;
            btnRegistrar.IsEnabled = true;
            btnActualizar.IsEnabled = false;
            btnEliminar.IsEnabled = false;
            btnLimpiar.IsEnabled = false;
            gvTablas.ItemsSource = tablaLogic.ListarTablas();
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            T_C_Tabla temp = new T_C_Tabla();
            temp.Nombre_Tabla = txtNombre.Text;
            temp.Descripcion_Tabla = txtDescripción.Text;
            MessageBox.Show(tablaLogic.AgregarTabla(temp));
            gvTablas.ItemsSource = tablaLogic.ListarTablas();
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            T_C_Tabla temp = gvTablas.SelectedItem as T_C_Tabla;

            temp.Nombre_Tabla = txtNombre.Text;
            temp.Descripcion_Tabla = txtDescripción.Text;

            MessageBox.Show(tablaLogic.ActualizarTabla(temp));
            gvTablas.ItemsSource = tablaLogic.ListarTablas();

        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            T_C_Tabla temp = gvTablas.SelectedItem as T_C_Tabla;
            MessageBox.Show(tablaLogic.EliminarTabla(temp));
            gvTablas.ItemsSource = tablaLogic.ListarTablas();
        }
    }
}
