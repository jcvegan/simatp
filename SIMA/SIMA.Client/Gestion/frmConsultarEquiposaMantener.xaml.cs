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
        EquipoDataLogic Equipologic;
        TurnoMantenimientoDataLogic TurnoMantenimientologic;
        
        public frmConsultarEquiposaMantener()
        {
            InitializeComponent();
            Mantenimientologic = new MantenimientoDataLogic();
            Equipologic = new EquipoDataLogic();
            TurnoMantenimientologic = new TurnoMantenimientoDataLogic();
        }

        public void llenargridview(List<T_C_Mantenimiento> listamantenimiento) {
            List<object> obj = new List<object> { };
            foreach (T_C_Mantenimiento Mantenimiento in listamantenimiento)
            {
                string horaminutoinicio,horaminutofin, horainicio, minutoinicio, horafin, minutofin="";
                horaminutoinicio = TurnoMantenimientologic.SeleccionarTurnoMantenimiento(Mantenimiento.Id_TurnoMantenimiento).HoraInicio.ToString();
                horaminutofin = TurnoMantenimientologic.SeleccionarTurnoMantenimiento(Mantenimiento.Id_TurnoMantenimiento).HoraFin.ToString();
                if (horaminutoinicio.Length == 4)
                {
                    horainicio = horaminutoinicio.Substring(0, 2);
                    minutoinicio = horaminutoinicio.Substring(2, 2);
                }
                else {
                    horainicio = horaminutoinicio.Substring(0, 1);
                    minutoinicio = horaminutoinicio.Substring(1, 3);
                }
                if (horaminutofin.Length == 4)
                {
                    horafin = horaminutofin.Substring(0, 2);
                    minutofin = horaminutofin.Substring(2, 2);
                }
                else
                {
                    horafin = horaminutofin.Substring(0, 1);
                    minutofin = horaminutofin.Substring(1, 3);
                }
                string fecha = Mantenimiento.FechaProgramacion.Year + "-" + Mantenimiento.FechaProgramacion.Month + "-" + Mantenimiento.FechaProgramacion.Day;
                var Anom = new
                {
                    Mantenimiento.Id_Mantenimiento,
                    Equipologic.SeleccionarEquipo(Mantenimiento.Id_Equipo).Id_Equipo,
                    Equipologic.SeleccionarEquipo(Mantenimiento.Id_Equipo).Descripcion,
                    Inicio = horainicio + ":" + minutoinicio,
                    Fin= horafin + ":" + minutoinicio,
                    fecha
                };
                    obj.Add(Anom);
            }

            gvMantenimientos.ItemsSource = obj;
            
        }
        
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            schMantenimiento.AppointmentsSource = new Auxiliares.MantenimientoSessionAppCollection(schMantenimiento);
            llenargridview(Mantenimientologic.ListarActivosMantenimientos());
            
                       
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
