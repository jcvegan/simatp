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

namespace SIMA.Client.Trabajos_de_Mantenimiento
{
    /// <summary>
    /// Lógica de interacción para frmAsignarEquiposAMantener.xaml
    /// </summary>
    public partial class frmAsignarEquiposAMantener : UserControl
    {
        private EquipoDataLogic equipoLogic;
        private TipoMantenimientoPorEquipoDataLogic tipoMantenimientoLogic;
        public frmAsignarEquiposAMantener()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            equipoLogic = new EquipoDataLogic();
            cmbEquipos.ItemsSource = equipoLogic.ListarActivos();
            tipoMantenimientoLogic = new TipoMantenimientoPorEquipoDataLogic();
        }

        private void cmbEquipos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmbTipoMantenimientos.ItemsSource = tipoMantenimientoLogic.ListarMantenimientosActivosPorEquipo((cmbEquipos.SelectedItem as T_C_Equipo).Id_Equipo);
        }
    }
}
