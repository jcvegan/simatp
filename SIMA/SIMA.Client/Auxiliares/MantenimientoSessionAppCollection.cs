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
using SIMA.Logic;
namespace SIMA.Client.Auxiliares
{
    public class MantenimientoSessionAppCollection : ObservableCollection<MantenimientoSessionApp>, IAppointmentFactory
    {
        public MantenimientoSessionAppCollection(RadScheduler scheduler)
        {
            int month = DateTime.Now.Month;
            DateTime mondayDate = CalendarHelper.GetFirstDayOfWeek(DateTime.Today, DayOfWeek.Monday);
            DateTime satDate = CalendarHelper.GetFirstDayOfWeek(DateTime.Today, DayOfWeek.Saturday);
            DateTime lastsundayDate = CalendarHelper.GetEndOfMonth(DateTime.Today);

            MantenimientoSessionApp MantenimientoApp = new MantenimientoSessionApp();
            MantenimientoApp.Subject = "mantenimiento 1"; 
            MantenimientoApp.Body = "mantenimiento de equipo fn17";
            MantenimientoApp.Start = DateTime.Now;
            MantenimientoApp.End = DateTime.Now.AddHours(3);
            MantenimientoApp.Equipo = "FN17";
            MantenimientoApp.Category = scheduler.Categories.GetCategoryByName("MANTE");
            Add(MantenimientoApp);
        }
        #region IAppointmentFactory Members

        public IAppointment CreateNewAppointment()
        {
            return new MantenimientoSessionApp();
        }

        #endregion

    }


}
