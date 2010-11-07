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
    /// Lógica de interacción para frmGestionarEstados.xaml
    /// </summary>
    public partial class frmGestionarEstados : UserControl
    {
        TablaDataLogic tablaLogic;
        EstadoDataLogic estadoLogic;
        public frmGestionarEstados()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            tablaLogic = new TablaDataLogic();
            estadoLogic = new EstadoDataLogic();
            cmbTablas.ItemsSource = tablaLogic.ListarTablas();
            gvEstados.ItemsSource = estadoLogic.ListarEstados();
            btnActualizar.IsEnabled = false;
            btnEliminar.IsEnabled = false;
            btnLimpiar.IsEnabled = false;
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            T_C_Estado estado = new T_C_Estado();
            estado.Nombre_Estado = txtNombre.Text;
            estado.Descripcion_Estado = txtDescripcion.Text;
            estado.Id_Tabla = (cmbTablas.SelectedItem as T_C_Tabla).Id_Tabla;
            estado.Por_Defecto = (bool)chkPorDefecto.IsChecked;
            estado.Muestra_Informacion = (bool)chkMuestraInformacion.IsChecked;
            MessageBox.Show(estadoLogic.AgregarEstado(estado));
            gvEstados.ItemsSource = estadoLogic.ListarEstados();
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            T_C_Estado estado = gvEstados.SelectedItem as T_C_Estado;
            estado.Descripcion_Estado = txtDescripcion.Text;
            estado.Muestra_Informacion = (bool)chkMuestraInformacion.IsChecked;
            estado.Nombre_Estado = txtNombre.Text;
            estado.Por_Defecto = (bool)chkPorDefecto.IsChecked;
            MessageBox.Show(estadoLogic.ActualizarEstado(estado));
            gvEstados.ItemsSource = estadoLogic.ListarEstados();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            T_C_Estado estado = gvEstados.SelectedItem as T_C_Estado;
            MessageBox.Show(estadoLogic.EliminarEstado(estado));
            gvEstados.ItemsSource = estadoLogic.ListarEstados();
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            btnRegistrar.IsEnabled = true;
            btnActualizar.IsEnabled = false;
            btnEliminar.IsEnabled = false;
            btnLimpiar.IsEnabled = false;
            txtDescripcion.Text = string.Empty;
            txtNombre.Text = string.Empty;
            cmbTablas.SelectedItem = null;
            chkPorDefecto.IsChecked = false;
            chkMuestraInformacion.IsChecked = false;
            gvEstados.SelectedItem = null;
        }

        private void gvTablas_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangeEventArgs e)
        {
            if (gvEstados.SelectedItem != null)
            {
                btnRegistrar.IsEnabled = false;
                btnActualizar.IsEnabled = true;
                btnEliminar.IsEnabled = true;
                btnLimpiar.IsEnabled = true;
                T_C_Estado temp = gvEstados.SelectedItem as T_C_Estado;
                txtDescripcion.Text = temp.Descripcion_Estado;
                txtNombre.Text = temp.Nombre_Estado;
                for (int i = 0; i <= cmbTablas.Items.Count; i++)
                {
                    if ((cmbTablas.Items[i] as T_C_Tabla).Id_Tabla == temp.Id_Tabla)
                    {
                        cmbTablas.SelectedIndex = i;
                        break;
                    }
                }
                cmbTablas.SelectedItem = temp.Tabla;
                chkPorDefecto.IsChecked = temp.Por_Defecto;
                chkMuestraInformacion.IsChecked = temp.Muestra_Informacion;
            }
            
        }

        
    }
}
