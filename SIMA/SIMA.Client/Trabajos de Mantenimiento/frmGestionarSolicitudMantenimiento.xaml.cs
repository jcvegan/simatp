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

namespace SIMA.Client.Trabajos_de_Mantenimiento
{
    /// <summary>
    /// Lógica de interacción para frmGestionarSolicitudMantenimiento.xaml
    /// </summary>
    public partial class frmGestionarSolicitudMantenimiento : UserControl
    {   
        SolicitudDataLogic SolicitudLogic;
        List<T_C_DetalleOrdenDeTrabajo> detalle;
        bool vezPrimera = true;                

        public frmGestionarSolicitudMantenimiento()
        {
            InitializeComponent();
            detalle = new List<T_C_DetalleOrdenDeTrabajo>();
        }

       
        //private void gvEquipo_SelectionChanged(object sender, SelectionChangeEventArgs e)
        //{
        //    if (gvEquipo.SelectedItem != null)
        //    {                
        //        T_C_Equipo equipo = gvEquipo.SelectedItem as T_C_Equipo;
        //        txtEquipo.Text = equipo.Id_Equipo.ToString();                                
        //    }            
        //}

        private void UserControl_Loaded_1(object sender, RoutedEventArgs e)
        {
            SolicitudLogic = new SolicitudDataLogic();
            BuscarSolicitud();
        }

        private void BuscarSolicitud()
        {
            gvSolicitudes.ItemsSource = SolicitudLogic.SeleccionarTodosSolicitud();
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            T_C_Solicitud Solicitud = new T_C_Solicitud();
            T_C_DetalleSolicitud DetalleSolicitud = new T_C_DetalleSolicitud();

            if (detalle.Count > 0)
            {                
                Solicitud.Descripcion = txtDescripcion.Text;
                Solicitud.FechaSolicitud = (DateTime)dtFSolicitud.SelectedDateTime;
                Solicitud.FechaRespuesta = (DateTime)dtFRespuesta.SelectedDateTime;
                Solicitud.UsuarioRespuesta = txtUsuarioRespuesta.Text;                
                DetalleSolicitud.Motivo = txtMotivo.Text;
                SolicitudLogic.AgregarSolicitud(Solicitud);
                for (int i= 0; i < detalle.Count ; i++)
                {
                    DetalleSolicitud.Id_Equipo = detalle.ElementAt(i).IdEquipo;
                    SolicitudLogic.AgregarDetalleSolicitud(DetalleSolicitud);    
                }
                MessageBox.Show("Registro grabado satisfactoriamente");
                Limpiar();
                BuscarSolicitud();
            }
            else
            {
                MessageBox.Show("Seleccione un Equipo");
            }
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {            
            txtDescripcion.Text = "";
            dtFSolicitud.SelectedDateTime = DateTime.MinValue; ;
            dtFRespuesta.SelectedDateTime = DateTime.MinValue; ;
            txtUsuarioRespuesta.Text = "";            
            txtMotivo.Text = "";
            detalle.Clear();
        }

        private void btnAgregarDetalle_Click(object sender, RoutedEventArgs e)
        {
            if (vezPrimera)
            {
                frmSelectorEquipos equiposSelector = new frmSelectorEquipos();
                equiposSelector.Resultado += new EventHandler<SIMA.Client.Auxiliares.EventArgs.DetalleOrdenTrabajoEventArgs>(equiposSelector_Resultado);
                equiposSelector.Show();
                vezPrimera = false;
            }
            else
            {
                frmSelectorEquipos equiposSelector = new frmSelectorEquipos(detalle);
                equiposSelector.Resultado += new EventHandler<SIMA.Client.Auxiliares.EventArgs.DetalleOrdenTrabajoEventArgs>(equiposSelector_Resultado);
                equiposSelector.Show();
                vezPrimera = false;
            }
        }

        void equiposSelector_Resultado(object sender, SIMA.Client.Auxiliares.EventArgs.DetalleOrdenTrabajoEventArgs e)
        {
            if (e.DetalleOrden.Count > 0)
            {
                detalle = e.DetalleOrden;
                DescripcionEquipo.Text = "Se cuenta con equipos";
            }
            else
            {
                DescripcionEquipo.Text = "No cuenta con equipos";
            }
        }

    }
}
