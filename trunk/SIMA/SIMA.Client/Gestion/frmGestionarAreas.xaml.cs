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
using System.ComponentModel;

namespace SIMA.Client.Gestion
{
    /// <summary>
    /// Lógica de interacción para frmGestionarAreas.xaml
    /// </summary>
    public partial class frmGestionarAreas : UserControl
    {
        BackgroundWorker worker = new BackgroundWorker();
        EstadoDataLogic estadoLogic;
        AreaDataLogic areaLogic;

        public frmGestionarAreas()
        {
            InitializeComponent();
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            T_C_Area area = new T_C_Area();
            area.Id_Area = txtIdArea.Text;
            area.Nombre = txtNombre.Text;
            area.Descripcion = txtDescripción.Text;
            MessageBox.Show(areaLogic.AgregarArea(area));
            gvAreas.ItemsSource = areaLogic.ListarAreas();
            Limpiar();
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            T_C_Area area = new T_C_Area();
            area.Id_Area = txtIdArea.Text;
            area.Nombre = txtNombre.Text;
            area.Descripcion = txtDescripción.Text;
            area.Id_Estado = (cmbEstado.SelectedItem as T_C_Estado).Id_Estado;
            MessageBox.Show(areaLogic.ActualizarArea(area));
            gvAreas.ItemsSource = areaLogic.ListarAreas();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            T_C_Area area = new T_C_Area();
            area.Id_Area = txtIdArea.Text;
            area.Nombre = txtNombre.Text;
            area.Descripcion = txtDescripción.Text;
            area.Id_Estado = (cmbEstado.SelectedItem as T_C_Estado).Id_Estado;
            MessageBox.Show(areaLogic.EliminarArea(area));
            gvAreas.ItemsSource = areaLogic.ListarAreas();
            Limpiar();
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void gvAreas_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangeEventArgs e)
        {
            if (gvAreas.SelectedItem != null)
            {
                btnRegistrar.IsEnabled = false;
                btnActualizar.IsEnabled = true;
                btnEliminar.IsEnabled = true;
                btnLimpiar.IsEnabled = true;
                lblEstado.Visibility = Visibility.Visible;
                cmbEstado.Visibility = Visibility.Visible;
                T_C_Area temp = gvAreas.SelectedItem as T_C_Area;
                txtDescripción.Text = temp.Descripcion;
                txtIdArea.Text = temp.Id_Area;
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
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            estadoLogic = new EstadoDataLogic();
            areaLogic = new AreaDataLogic();
            btnActualizar.IsEnabled = false;
            btnEliminar.IsEnabled = false;
            btnLimpiar.IsEnabled = false;
            cmbEstado.ItemsSource = estadoLogic.ListarEstadosPorTabla("T_C_Area");
            gvAreas.ItemsSource = areaLogic.ListarAreas();
        }

        private void Limpiar()
        {
            btnRegistrar.IsEnabled = true;
            btnActualizar.IsEnabled = false;
            btnEliminar.IsEnabled = false;
            btnLimpiar.IsEnabled = false;
            txtIdArea.Text = string.Empty;
            txtDescripción.Text = string.Empty;
            txtNombre.Text = string.Empty;
            cmbEstado.SelectedItem = null;
            gvAreas.SelectedItem = null;
            lblEstado.Visibility = Visibility.Hidden;
            cmbEstado.Visibility = Visibility.Hidden;
        }
    }
}
