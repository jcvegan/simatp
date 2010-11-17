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
using Telerik.Windows.Controls.Scheduler;
using System.Collections.ObjectModel;
using Telerik.Windows.Controls;

namespace SIMA.Client.Gestion
{
    /// <summary>
    /// Lógica de interacción para frmConsultarEquiposaMantener.xaml
    /// </summary>
    public partial class frmConsultarEquiposaMantener : UserControl
    {
        MantenimientoDataLogic Mantenimientologic;
        public frmConsultarEquiposaMantener()
        {
            InitializeComponent();
            Mantenimientologic = new MantenimientoDataLogic();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            schMantenimiento.AppointmentsSource = new Auxiliares.MantenimientoSessionAppCollection(schMantenimiento);
            gvMantenimientos.ItemsSource = Mantenimientologic.ListarMantenimientos();
                       
        }

        private void gvAreas_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangeEventArgs e)
        {

        }

        private void schMantenimiento_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void gvMantenimientos_SelectionChanged(object sender, SelectionChangeEventArgs e)
        {
            
        }
    }
}
