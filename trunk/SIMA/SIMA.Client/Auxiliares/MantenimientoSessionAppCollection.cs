using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Telerik.Windows.Controls.Scheduler;
using System.Collections.ObjectModel;
using Telerik.Windows.Controls;
using SIMA.Client.Auxiliares;
using SIMA.Entities;
using SIMA.Logic;

namespace SIMA.Client.Auxiliares
{
    public class MantenimientoSessionAppCollection : ObservableCollection<MantenimientoSessionApp>, IAppointmentFactory
    {
        public MantenimientoSessionAppCollection(RadScheduler scheduler)
        {
            MantenimientoDataLogic MantenimientoLogic = new MantenimientoDataLogic();
            EquipoDataLogic EquipoLogic = new EquipoDataLogic();
            TurnoMantenimientoDataLogic TurnoLogic = new TurnoMantenimientoDataLogic();
            int month = DateTime.Now.Month;
            DateTime mondayDate = CalendarHelper.GetFirstDayOfWeek(DateTime.Today, DayOfWeek.Monday);
            DateTime satDate = CalendarHelper.GetFirstDayOfWeek(DateTime.Today, DayOfWeek.Saturday);
            DateTime lastsundayDate = CalendarHelper.GetEndOfMonth(DateTime.Today);
            foreach (T_C_Mantenimiento Mantenimiento in MantenimientoLogic.ListarActivosMantenimientos())
            {
                MantenimientoSessionApp MantenimientoApp = new MantenimientoSessionApp();
                MantenimientoApp.Subject = EquipoLogic.SeleccionarEquipo(Mantenimiento.Id_Equipo.ToString()).Descripcion;
                MantenimientoApp.Body = "mantenimiento de equipo "+MantenimientoApp.Subject;
                string horaminutoinicio,horaminutofin, horainicio, minutoinicio, horafin, minutofin="";
                horaminutoinicio = TurnoLogic.SeleccionarTurnoMantenimiento(Mantenimiento.Id_TurnoMantenimiento).HoraInicio.ToString();
                horaminutofin = TurnoLogic.SeleccionarTurnoMantenimiento(Mantenimiento.Id_TurnoMantenimiento).HoraFin.ToString();
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
                MantenimientoApp.Start = Convert.ToDateTime(Mantenimiento.FechaProgramacion.Year + "-" + Mantenimiento.FechaProgramacion.Month + "-" + Mantenimiento.FechaProgramacion.Day + " " + horainicio + ":" + minutoinicio + ":00.000");
                MantenimientoApp.End = Convert.ToDateTime(Mantenimiento.FechaProgramacion.Year + "-" + Mantenimiento.FechaProgramacion.Month + "-" + Mantenimiento.FechaProgramacion.Day + " " + horafin+ ":" + minutofin+ ":00.000");
                MantenimientoApp.Equipo = Mantenimiento.Id_Equipo;
                MantenimientoApp.Category = scheduler.Categories.GetCategoryByName("MANTE");
                Add(MantenimientoApp);
            }
            
        }
        #region IAppointmentFactory Members

        public IAppointment CreateNewAppointment()
        {
            return new MantenimientoSessionApp();
        }

        #endregion

    }


}
