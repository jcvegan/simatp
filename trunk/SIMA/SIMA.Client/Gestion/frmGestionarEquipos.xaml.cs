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
using SIMA.Client.Auxiliares;
using Telerik.Windows.Controls;

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
        EstadoDataLogic estadoLogic;
        T_C_Equipo padre;
        bool verPrimera = true;
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
            estadoLogic = new EstadoDataLogic();
            gvEquipo.ItemsSource = equipoLogic.ListarTodos();
            cmbEstado.ItemsSource = estadoLogic.ListarEstadosPorTabla("T_C_Equipo");
            SoloRegistra();
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            T_C_Equipo equipo = new T_C_Equipo();
            equipo.Cantidad = int.Parse(txtCantidad.Text);
            equipo.CapacidadOperacion = Convert.ToDecimal(txtCapOper.Text);
            equipo.Costo = (double)udCostoUnidad.Value;
            equipo.Descripcion = txtDescripcion.Text;
            equipo.DiamteroInterno =Convert.ToDecimal(txtDiamtero.Text);
            equipo.Fecha_Adquisicion = (DateTime)dtFAdquisicion.SelectedDateTime;
            equipo.Fecha_Registro = DateTime.Now;
            equipo.Id_Area = (cmbAreaEquipo.SelectedItem as T_C_Area).Id_Area;
            equipo.Id_Marca = (cmbMarcaEquipo.SelectedItem as T_C_Marca).Id_Marca;
            equipo.Id_Modelo = (cmbModeloEquipo.SelectedItem as T_C_Modelo).Id_Modelo;
            equipo.MaxHoras = int.Parse(udMaxHoras.Value.ToString());
            equipo.RevestimientoInterior = txtRevestimiento.Text;
            equipo.Serie = txtSerie.Text;
            equipo.Stock = int.Parse(txtCantidad.Text);
            equipo.UsoUnico = (bool)chkEsUsoUnico.IsChecked;
            MessageBox.Show(equipoLogic.AgregarEquipo(equipo));
            gvEquipo.ItemsSource = equipoLogic.ListarTodos();
            Limpia();
            SoloRegistra();
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            T_C_Equipo equipo = gvEquipo.SelectedItem as T_C_Equipo;
            equipo.Cantidad = int.Parse(txtCantidad.Text);
            equipo.CapacidadOperacion = Convert.ToDecimal(txtCapOper.Text);
            equipo.Costo = (double)udCostoUnidad.Value;
            equipo.Descripcion = txtDescripcion.Text;
            equipo.DiamteroInterno = Convert.ToDecimal(txtDiamtero.Text);
            equipo.Fecha_Adquisicion = (DateTime)dtFAdquisicion.SelectedDateTime;
            equipo.Fecha_Registro = DateTime.Now;
            equipo.Id_Area = (cmbAreaEquipo.SelectedItem as T_C_Area).Id_Area;
            equipo.Id_Marca = (cmbMarcaEquipo.SelectedItem as T_C_Marca).Id_Marca;
            equipo.Id_Modelo = (cmbModeloEquipo.SelectedItem as T_C_Modelo).Id_Modelo;
            equipo.MaxHoras = int.Parse(udMaxHoras.Value.ToString());
            equipo.RevestimientoInterior = txtRevestimiento.Text;
            equipo.Serie = txtSerie.Text;
            equipo.Stock = int.Parse(txtCantidad.Text);
            equipo.UsoUnico = (bool)chkEsUsoUnico.IsChecked;
            gvEquipo.ItemsSource = equipoLogic.ListarTodos();
            Limpia();
            SoloRegistra();
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

        private void SoloRegistra()
        {
            lblEstado.Visibility = Visibility.Hidden;
            cmbEstado.Visibility = Visibility.Hidden;
            btnActualizar.IsEnabled = false;
            btnEliminar.IsEnabled = false;
            btnRegistrar.IsEnabled = true;
        }

        private void Limpia()
        {
            gvEquipo.SelectedItem = null;
            lblEstado.Visibility = Visibility.Hidden;
            cmbEstado.Visibility = Visibility.Hidden;
            txtCantidad.Clear();
            txtCapOper.Clear();
            udCostoUnidad.Value=udCostoUnidad.Minimum;
            txtDescripcion.Clear();
            txtDiamtero.Clear();
            dtFAdquisicion.SelectedDateTime=DateTime.MinValue;
            cmbAreaEquipo.SelectedItem = null;
            cmbMarcaEquipo.SelectedItem = null;
            cmbModeloEquipo.SelectedItem = null;
            udMaxHoras.Value = udMaxHoras.Minimum;
            txtRevestimiento.Clear();
            txtSerie.Clear() ;
            txtCantidad.Clear();
            chkEsUsoUnico.IsChecked=false;
        }

        private void btnSelEquipoPadre_Click(object sender, RoutedEventArgs e)
        {
            frmSelectorEquipo selector;
            if (verPrimera)
            {
                selector = new frmSelectorEquipo();
                selector.SeleccionaEquipoPadre += new EventHandler<SIMA.Client.Auxiliares.EventArgs.EquipoPadreEventArgs>(selector_SeleccionaEquipoPadre);
                selector.ShowDialog();
                verPrimera = false;
            }
            else
            {
                selector = new frmSelectorEquipo(padre);
                selector.SeleccionaEquipoPadre += new EventHandler<SIMA.Client.Auxiliares.EventArgs.EquipoPadreEventArgs>(selector_SeleccionaEquipoPadre);
                selector.ShowDialog();
            }
            
            
        }

        void selector_SeleccionaEquipoPadre(object sender, SIMA.Client.Auxiliares.EventArgs.EquipoPadreEventArgs e)
        {
            padre = e.EquipoSeleccionado;
            DescripcionEquipo.Text = string.Concat(e.EquipoSeleccionado.Id_Equipo," ",e.EquipoSeleccionado.Descripcion);
        }
    }
}
