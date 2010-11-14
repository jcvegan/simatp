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
using SIMA.Client.Auxiliares;

namespace SIMA.Client.Orden_de_Trabajo
{
    /// <summary>
    /// Lógica de interacción para frmGestionarOrdendeTrabajo.xaml
    /// </summary>
    public partial class frmGestionarOrdendeTrabajo : UserControl
    {
        OrdenTrabajoDataLogic ordentrabajoLogic;
        

        public frmGestionarOrdendeTrabajo()
        {
            InitializeComponent();
        }

        private void gvOrdenesTrabajo_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangeEventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            T_C_OrdenTrabajo ordentrabajo = new T_C_OrdenTrabajo();
            ordentrabajo.Descripcion = txtCosto.Text;
            MessageBox.Show(ordentrabajoLogic.AgregarOrdenTrabajo(ordentrabajo));
            gvOrdenesTrabajo.ItemsSource = ordentrabajoLogic.ListarOrdenesTrabajo();
            Limpia();
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            Limpia();
        }

        private void btnVerDetalle_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAgregarDetalle_Click(object sender, RoutedEventArgs e)
        {
            frmSelectorEquipos equiposSelector = new frmSelectorEquipos();
            equiposSelector.Resultado += new EventHandler<SIMA.Client.Auxiliares.EventArgs.DetalleOrdenTrabajoEventArgs>(equiposSelector_Resultado);
            equiposSelector.Show();
        }

        void equiposSelector_Resultado(object sender, SIMA.Client.Auxiliares.EventArgs.DetalleOrdenTrabajoEventArgs e)
        {
            
        }

        private void Limpia()
        {

            txtDescripcion.Clear();

            //lblEstado.Visibility = Visibility.Hidden;
            //cmbEstado.Visibility = Visibility.Hidden;
            //btnActualizar.IsEnabled = false;
            //btnEliminar.IsEnabled = false;
            //btnLimpiar.IsEnabled = false;
            //btnRegistrar.IsEnabled = true;
            //gvPerfiles.SelectedItem = null;
            //txtDescripción.Text = string.Empty;
            //txtNombre.Text = string.Empty;
            //cmbEstado.SelectedItem = null;

        }
    }
}
