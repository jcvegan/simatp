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
using Telerik.Windows.Controls;
using SIMA.Client.Gestion;
using SIMA.Client.Orden_de_Trabajo;
using SIMA.Client.Trabajos_de_Mantenimiento;
using SIMA.Client.Seguridad;
using SIMA.Entities;
using SIMA.Logic;
using System.Threading;
using System.ComponentModel;

namespace SIMA.Client
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        T_C_Usuario usuarioValido;
        T_C_Perfil perfilUsuario;
        List<T_C_Permiso> permisosUsuario;
        BackgroundWorker worker = new BackgroundWorker();
        
        public Window1()
        {
            InitializeComponent();
            OcultaRibbon();
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Dispatcher.BeginInvoke(new Action<List<T_C_Permiso>>(this.ActualizarPermisosEnSistema), e.Result);
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = CargarSeguridadDeUsuario();
        }

        private void rbtnChecked(object sender, RoutedEventArgs e)
        {
            RadTileViewItem item = new RadTileViewItem();
            StyleManager.SetTheme(item, new SummerTheme());
            item.Header = (sender as RadRibbonToggleButton).Content;
            switch (item.Header.ToString())
            {
                //case "Permisos":
                //    item.Content = new frmGestionarPermisos();
                //    break;

                case "IniciarSesion":
                    item.Content = new frmIniciarSesion();
                    break;
                case "Areas":
                    item.Content = new frmGestionarAreas();                    
                    break;
                case "Perfiles":
                    item.Content = new frmGestionarPerfiles();
                    break;
                case "Tablas":
                    item.Content = new frmGestionarTablas();
                    break;
                case "Estados":
                    item.Content = new frmGestionarEstados();
                    break;
                case "Equipos":
                    item.Content = new frmGestionarEquipos();
                    break;
                case "Tipo Mantenimiento":
                    item.Content = new frmGestionarTipoMantenimiento();
                    break;
                case "Orden de Trabajo":
                    item.Content = new frmGestionarOrdendeTrabajo();
                    break;
                case "Marcas":
                    item.Content = new frmGestionarMarca();
                    break;
                case "Modelos":
                    item.Content = new frmGestionarModelos();
                    break;
                case "Productos":
                    item.Content = new frmGestionarProducto();
                    break;
                case "Solicitud":
                    item.Content = new frmGestionarSolicitud();
                    break;
                case "Mantenimientos programados":
                    item.Content = new frmConsultarEquiposaMantener();
                    break;
                case "Equipos a mantener":
                    item.Content = new frmConsultarEquiposaMantener();
                    break;
                case "Asignar Equipos":
                    item.Content = new frmAsignarEquiposAMantener();
                    break;

                case "Solicitud Mantenimiento":
                    item.Content = new frmGestionarSolicitud();
                    break;
                case "Apertura Mantenimiento":
                    
                    break;
                case "Contraseña":
                    break;

                case "Registro Orden":
                    break;
                //case "Consultar Historico Mantenimiento":
                //    item.Content = new frmConsultarHistoricodeMantenimiento();
                //    break;     
                case "Usuarios":
                    item.Content = new frmGestionarUsuarios();
                    break;

            }
            item.MinimizedHeight = 20;
            item.TileState = TileViewItemState.Maximized;
            TileContainerRoot.Items.Add(item);
            
            
        }

        private void rbtnUnchecked(object sender, RoutedEventArgs e)
        {
            foreach (RadTileViewItem item in TileContainerRoot.Items)
            {
                if (item.Header == (sender as RadRibbonToggleButton).Content)
                {
                    TileContainerRoot.Items.Remove(item);
                    break;
                }
            }
        }

        private void RadRibbonButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cerrar la sesión?", "Informativo", MessageBoxButton.YesNoCancel, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                this.DataContext = null;
                dialogIniciarSesion.Owner = this;
                TileContainerRoot.Items.Clear();
                usuarioValido = null;
                permisosUsuario = null;
                OcultaRibbon();
                dialogIniciarSesion.ShowDialog(); 
            }            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dialogIniciarSesion.Owner = this;
            dialogIniciarSesion.ShowDialog();            
        }

        private void dialogIniciarSesion_UsuarioValidado(object sender, SIMA.Client.Auxiliares.EventArgs.UsuarioEventArgs e)
        {
            this.DataContext = e;
            usuarioValido = e.Usuario;
            biProcesando.BusyContent = "Cargando permisos de usuario";
            biProcesando.IsBusy = true;
            worker.RunWorkerAsync();
        }

        private void OcultaRibbon()
        {
            foreach (RadRibbonTab tab in ribbonTabPrincipal.Items)
            {
                foreach(RadRibbonGroup group in tab.Items)
                {
                    foreach (RadRibbonToggleButton tbtn in group.Items)
                    {
                        if (tbtn.IsChecked == true)
                        {
                            tbtn.IsChecked = false;                            
                        }
                        tbtn.Visibility = Visibility.Collapsed;
                    }
                    group.Visibility = Visibility.Collapsed;
                }
                tab.Visibility = Visibility.Collapsed;
            }
        }

        private void MuestraPermisos()
        {
            foreach (T_C_Permiso per in permisosUsuario)
            {
                foreach (RadRibbonTab tab in ribbonTabPrincipal.Items)
                {
                    bool flagt = false;
                    foreach (RadRibbonGroup group in tab.Items)
                    {
                        bool flagg = false;
                        foreach (RadRibbonToggleButton tbtn in group.Items)
                        {

                            //foreach (T_C_Permiso per in permisosUsuario)
                            //{
                                if (tbtn.Tag.ToString() == per.Nombre)
                                {
                                    if (tbtn.IsChecked == true)
                                    {
                                        tbtn.IsChecked = false;
                                    }
                                    tbtn.Visibility = Visibility.Visible;
                                    flagg = true;
                                    break;
                                }
                            //}
                        }
                        if (flagg)
                        {
                            group.Visibility = Visibility.Visible;
                            flagt = true;
                        }
                    }
                    if (flagt)
                    {
                        tab.Visibility = Visibility.Visible;
                    }
                }
            }
        }

        private List<T_C_Permiso> CargarSeguridadDeUsuario()
        {
            List<T_C_Permiso> permis;
            Thread.Sleep(1000);
            permis = new PermisosPorPerfilDataLogic().ListarPermisosPorPerfil(usuarioValido.Id_Perfil);
            return permis;
        }

        private void ActualizarPermisosEnSistema(List<T_C_Permiso> msg)
        {
            permisosUsuario = msg;
            MuestraPermisos();
            biProcesando.IsBusy = false;
        }

        private void dialogIniciarSesion_Closed(object sender, WindowClosedEventArgs e)
        {
            if (usuarioValido == null)
            {
                this.Close();
            } 
        }
    }
}
