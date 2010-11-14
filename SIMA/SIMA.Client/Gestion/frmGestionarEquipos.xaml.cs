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
    /// Lógica de interacción para frmGestionarEquipos.xaml
    /// </summary>
    public partial class frmGestionarEquipos : UserControl
    {
        AreaDataLogic areaLogic;
        MarcaDataLogic marcaLogic;
        ModeloDataLogic modeloLogic;
        EquipoDataLogic equipoLogic;
        public frmGestionarEquipos()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            areaLogic = new AreaDataLogic();
            cmbAreaEquipo.ItemsSource = areaLogic.ListarActivosArea();
            marcaLogic = new MarcaDataLogic();
            cmbMarcaEquipo.ItemsSource = marcaLogic.ListarActivosMarcas();
            modeloLogic = new ModeloDataLogic();
            equipoLogic = new EquipoDataLogic();
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            T_C_Equipo equipo = new T_C_Equipo();
            equipo.CapacidadOperacion = Convert.ToDecimal(txtCapOper.Text);
            equipo.Costo = (float)udCostoUnidad.Value;
            equipo.Descripcion = txtDescripcion.Text;
            equipo.DiamteroInterno =Convert.ToDecimal(txtDiamtero.Text);     
            MessageBox.Show(equipoLogic.AgregarEquipo(equipo));
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnVerDetalle_Click(object sender, RoutedEventArgs e)
        {

        }

        private void gvOrdenesTrabajo_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangeEventArgs e)
        {

        }

        private void cmbMarcaEquipo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbMarcaEquipo.SelectedItem != null)
            {
                lblModelo.Visibility = Visibility.Visible;
                cmbModeloEquipo.Visibility = Visibility.Visible;
                cmbModeloEquipo.ItemsSource = modeloLogic.ListarPorMarca((cmbMarcaEquipo.SelectedItem as T_C_Marca).Id_Marca);
            }
            else
            {
                lblModelo.Visibility = Visibility.Hidden;
                cmbModeloEquipo.Visibility = Visibility.Hidden;
            }
        }

        private void cmbModeloEquipo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
