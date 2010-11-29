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
using System.ComponentModel;
using System.Threading;

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
        T_C_Equipo equipo;
        List<T_C_TipoMantenimiento> tipoMantenimiento;
        BackgroundWorker worker = new BackgroundWorker();
        bool verPrimera = true;
        bool vezPrimeraTipo = true;
        public frmGestionarEquipos()
        {
            InitializeComponent();
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Dispatcher.BeginInvoke(new Action<string>(this.ActualizarRegistro), e.Result);
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = RegistrarEquipo();
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

            if (!worker.IsBusy)
            {
                biIndicador.BusyContent = "Registrando Información";
                equipo = new T_C_Equipo();
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
                biIndicador.IsBusy = true;
                worker.RunWorkerAsync();
            }
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            biIndicador.BusyContent = "Actualizando Información";
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
            if (gvEquipo.SelectedItem != null)
            {
                T_C_Equipo equipo = gvEquipo.SelectedItem as T_C_Equipo;
                txtCantidad.Text = equipo.Cantidad.ToString();
                txtCapOper.Text = equipo.CapacidadOperacion.ToString();
                udCostoUnidad.Value = equipo.Costo;
                txtDescripcion.Text = equipo.Descripcion;
                txtDiamtero.Text = equipo.DiamteroInterno.ToString();
                dtFAdquisicion.SelectedDateTime = equipo.Fecha_Adquisicion;
                txtSerie.Text = equipo.Serie;
                txtCantidad.Text = equipo.Stock.ToString();
                for (int i = 0; i <= cmbAreaEquipo.Items.Count; i++)
                {
                    if ((cmbAreaEquipo.Items[i] as T_C_Area).Id_Area == equipo.Id_Area)
                    {
                        cmbAreaEquipo.SelectedIndex = i;
                        break;
                    }
                }
                for (int i = 0; i <= cmbEstado.Items.Count; i++)
                {
                    if ((cmbEstado.Items[i] as T_C_Estado).Id_Estado == equipo.Id_Estado)
                    {
                        cmbEstado.SelectedIndex = i;
                        break;
                    }
                }
                //equipo.Id_Area = (cmbAreaEquipo.SelectedItem as T_C_Area).Id_Area;
                //equipo.Id_Marca = (cmbMarcaEquipo.SelectedItem as T_C_Marca).Id_Marca;
                //equipo.Id_Modelo = (cmbModeloEquipo.SelectedItem as T_C_Modelo).Id_Modelo;
                //equipo.MaxHoras = int.Parse(udMaxHoras.Value.ToString());
                //equipo.RevestimientoInterior = txtRevestimiento.Text;
                
                //equipo.Stock = int.Parse(txtCantidad.Text);
                //equipo.UsoUnico = (bool)chkEsUsoUnico.IsChecked;
            }
        }

        private void cmbMarcaEquipo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbMarcaEquipo.SelectedItem != null)
            {
                //TodasOperaciones();
                cmbModeloEquipo.ItemsSource = modeloLogic.ListarPorMarca((cmbMarcaEquipo.SelectedItem as T_C_Marca).Id_Marca);
                cmbModeloEquipo.Visibility = Visibility.Visible;
                lblModelo.Visibility = Visibility.Visible;
            }
            else
            {
                SoloRegistra();
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
            btnLimpiar.IsEnabled = false;
            btnRegistrar.IsEnabled = true;
        }

        private void TodasOperaciones()
        {
            lblEstado.Visibility = Visibility.Visible;
            cmbEstado.Visibility = Visibility.Visible;
            btnActualizar.IsEnabled = true;
            btnEliminar.IsEnabled = true;
            btnLimpiar.IsEnabled = true;
            btnRegistrar.IsEnabled = false;

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

        private void gvEquipo_SelectionChanged(object sender, SelectionChangeEventArgs e)
        {
            if (gvEquipo.SelectedItem != null)
            {
                TodasOperaciones();
                T_C_Equipo equipo = gvEquipo.SelectedItem as T_C_Equipo;
                txtCantidad.Text = equipo.Cantidad.ToString();
                txtCapOper.Text = equipo.CapacidadOperacion.ToString();
                udCostoUnidad.Value = equipo.Costo;
                equipo.Descripcion = txtDescripcion.Text;
                //equipo.DiamteroInterno = Convert.ToDecimal(txtDiamtero.Text);
                //equipo.Fecha_Adquisicion = (DateTime)dtFAdquisicion.SelectedDateTime;
                //equipo.Fecha_Registro = DateTime.Now;
                //equipo.Id_Area = (cmbAreaEquipo.SelectedItem as T_C_Area).Id_Area;
                //equipo.Id_Marca = (cmbMarcaEquipo.SelectedItem as T_C_Marca).Id_Marca;
                //equipo.Id_Modelo = (cmbModeloEquipo.SelectedItem as T_C_Modelo).Id_Modelo;
                //equipo.MaxHoras = int.Parse(udMaxHoras.Value.ToString());
                //equipo.RevestimientoInterior = txtRevestimiento.Text;
                //equipo.Serie = txtSerie.Text;
                //equipo.Stock = int.Parse(txtCantidad.Text);
                //equipo.UsoUnico = (bool)chkEsUsoUnico.IsChecked;
            }
            else
            {
                SoloRegistra();
            }
        }

        private void btnSelTipoMantenimiento_Click(object sender, RoutedEventArgs e)
        {
            frmSelectorTipoMantenimiento selector;
            if (vezPrimeraTipo)
            {
                vezPrimeraTipo = false;
                selector = new frmSelectorTipoMantenimiento();
                selector.resultado += new EventHandler<SIMA.Client.Auxiliares.EventArgs.TipoMantenimientoEventArgs>(selector_resultado);
                selector.ShowDialog();
            }
            else
            {
                selector = new frmSelectorTipoMantenimiento(tipoMantenimiento);
                selector.resultado += new EventHandler<SIMA.Client.Auxiliares.EventArgs.TipoMantenimientoEventArgs>(selector_resultado);
                selector.ShowDialog();
            }
        }

        void selector_resultado(object sender, SIMA.Client.Auxiliares.EventArgs.TipoMantenimientoEventArgs e)
        {
            tipoMantenimiento = e.TiposDeMantenimiento;
        }

        private string RegistrarEquipo()
        {
            string msg = string.Empty;
            
            if (padre != null)
            {
                equipo.EquipoPadre = padre.Id_Equipo;
            }
            msg = equipoLogic.AgregarEquipo(equipo);
            if (msg == "Registro grabado satisfactoriamente.")
            {
                Thread.Sleep(1000);
            }

            return msg;
        }

        private void ActualizarRegistro(string msg)
        {
            
            gvEquipo.ItemsSource = equipoLogic.ListarTodos();
            Limpia();
            MessageBox.Show(msg);
            biIndicador.IsBusy = false;
        }

        private void cmbAreaEquipo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
