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


namespace SIMA.Client.Trabajos_de_Mantenimiento
{
    /// <summary>
    /// Lógica de interacción para frmAsignarEquiposAMantener.xaml
    /// </summary>
    public partial class frmAsignarEquiposAMantener : UserControl
    {
        private EquipoDataLogic equipoLogic;
        private TipoMantenimientoPorEquipoDataLogic tipoMantenimientoLogic;
        private List<T_C_Mantenimiento> mantenimientosProgramados;
        MantenimientoSessionAppCollection collection;
        public frmAsignarEquiposAMantener()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            equipoLogic = new EquipoDataLogic();
            cmbEquipos.ItemsSource = equipoLogic.ListarActivos();
            tipoMantenimientoLogic = new TipoMantenimientoPorEquipoDataLogic();
            collection = new MantenimientoSessionAppCollection(schHorario);
        }

        private void cmbEquipos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmbTipoMantenimientos.ItemsSource = tipoMantenimientoLogic.ListarMantenimientosActivosPorEquipo((cmbEquipos.SelectedItem as T_C_Equipo).Id_Equipo);
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            T_C_Mantenimiento mantenimiento = new T_C_Mantenimiento();
            mantenimiento.FechaProgramacion = (DateTime)dpFechaInicio.SelectedDate;
            mantenimiento.FechaRegistro = DateTime.Now;
            mantenimiento.Id_TipoMantenimiento = (cmbTipoMantenimientos.SelectedItem as T_C_TipoMantenimiento).Id_Tipo;
            mantenimiento.Id_Equipo = (cmbEquipos.SelectedItem as T_C_Equipo).Id_Equipo;
            mantenimiento.UsuarioRegistro = "quien sea";
            MantenimientoSessionApp ses = new MantenimientoSessionApp();
            ses.Equipo = mantenimiento.Id_Equipo;
            ses.Subject = ((DateTime)dpFechaInicio.SelectedDate).ToLongDateString();
            ses.Body = equipoLogic.SeleccionarEquipo(mantenimiento.Id_Equipo).Descripcion;
            ses.Start = (DateTime)dpFechaInicio.SelectedDate;

            schHorario.AppointmentsSource = collection;
        }
    }
}
