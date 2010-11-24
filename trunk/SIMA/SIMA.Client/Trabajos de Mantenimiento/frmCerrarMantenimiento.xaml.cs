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
    /// Lógica de interacción para frmCerrarMantenimiento.xaml
    /// </summary>
    public partial class frmCerrarMantenimiento : UserControl
    {
        EquipoDataLogic Equipologic;
        MantenimientoDataLogic Mantenimientologic;

        public frmCerrarMantenimiento()
        {
            InitializeComponent();
            Equipologic = new EquipoDataLogic();
            Mantenimientologic=new MantenimientoDataLogic();
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            //foreach (T_C_Equipo equipos in Equipologic.ListarEquiposEnMantenimiento())
            //{

            //    var anom = new {
            //        FechaInicioFin,
            //        Id_Equipo=equipos.Id_Equipo,
            //        Descripcion=equipos.Descripcion,
            //        Id_Usuario,
            //        FechaTrabajoFin
            //    };
            //}
        }

        private void btnCerrarMantenimiento_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
