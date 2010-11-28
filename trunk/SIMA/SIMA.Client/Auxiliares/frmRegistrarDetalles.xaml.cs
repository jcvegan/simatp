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
using SIMA.Entities;
using SIMA.Logic;

namespace SIMA.Client.Auxiliares
{
    /// <summary>
    /// Lógica de interacción para frmRegistrarDetalles.xaml
    /// </summary>
    public partial class frmRegistrarDetalles : Window
    {
        List<T_C_DetalleOrdenDeTrabajo> detalle;
        OrdenTrabajoDataLogic ordentrabajoLogic;
        DetalleOrdenTrabajoDataLogic detalleordenLogic;

        bool vezPrimera = true;

        public frmRegistrarDetalles()
        {
            InitializeComponent();
            detalle = new List<T_C_DetalleOrdenDeTrabajo>();
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            if (vezPrimera)
            {
                frmSelectorEquipos equiposSelector = new frmSelectorEquipos();
                equiposSelector.Resultado += new EventHandler<SIMA.Client.Auxiliares.EventArgs.DetalleOrdenTrabajoEventArgs>(equiposSelector_Resultado);
                equiposSelector.ShowDialog();
                vezPrimera = false;
            }
            else
            {
                frmSelectorEquipos equiposSelector = new frmSelectorEquipos(detalle);
                equiposSelector.Resultado += new EventHandler<SIMA.Client.Auxiliares.EventArgs.DetalleOrdenTrabajoEventArgs>(equiposSelector_Resultado);
                equiposSelector.ShowDialog();
                vezPrimera = false;
            }
        }

        void equiposSelector_Resultado(object sender, SIMA.Client.Auxiliares.EventArgs.DetalleOrdenTrabajoEventArgs e)
        {
            if (e.DetalleOrden.Count > 0)
            {
                detalle = e.DetalleOrden;
                lblSeleccionEquipo.Text = "Se cuenta con equipos";
            }
            else
            {
                lblSeleccionEquipo.Text = "No cuenta con equipos";
            }
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Ingresar Descripcion");
            }
            else
            {
                T_C_DetalleOrdenDeTrabajo detalleorden = new T_C_DetalleOrdenDeTrabajo();
                detalleorden.Descrippcion = txtDescripcion.Text;

                MessageBox.Show(detalleordenLogic.AgregarDetalleOrdenTrabajo(detalleorden, detalle));
                txtDescripcion.Clear();
                gvDetalleConE.ItemsSource = detalleordenLogic.ListarDetalles();
            }            
        }

        private void chkConEquipo_Checked(object sender, RoutedEventArgs e)
        {
            if (chkConEquipo.IsChecked == true)
            {
                lblSeleccionEquipo.Visibility = Visibility.Visible;
                btnBuscar.Visibility = Visibility.Visible;
                lblCosto.Visibility = Visibility.Visible;
                txtCosto.Visibility = Visibility.Visible;
                txtCosto.IsEnabled = false;
            }
            else
            {
                lblCosto.Visibility = Visibility.Visible;
                txtCosto.Visibility = Visibility.Visible;
                lblCosto.IsEnabled = true;
            }
        }
    }
}
