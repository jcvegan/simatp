using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using Telerik.Windows.Controls;
using System.Diagnostics;

namespace SIMA.Client.Auxiliares
{
        public class MantenimientoSessionApp : Appointment
        {
            public override IAppointment Copy()
            {
                IAppointment appointment = new MantenimientoSessionApp();
                appointment.CopyFrom(this);
                return appointment;
            }

            public override void CopyFrom(IAppointment other)
            {
                MantenimientoSessionApp appointment = other as MantenimientoSessionApp;
                if (appointment != null)
                {
                    base.CopyFrom(other);
                }

            }
            public string TipoMantenimiento
            {
                get
                {
                    IResource resource = this.Resources.GetResourceByType("TipoMantenimiento");
                    if (resource != null)
                    {
                        return this.Resources.GetResourceByType("TipoMantenimiento").ResourceName;
                    }

                    return null;
                }
                set
                {
                    this.Resources.Add(new Resource(value, "TipoMantenimiento"));
                    OnPropertyChanged("TipoMantenimiento");
                }
            }

            public string Equipo
            {
                get
                {
                    IResource resource = this.Resources.GetResourceByType("Equipo");
                    if (resource != null)
                    {
                        return this.Resources.GetResourceByType("Equipo").ResourceName;
                    }
                    return null;
                }
                set
                {
                    this.Resources.Add(new Resource(value, "Equipo"));
                    OnPropertyChanged("Equipo");
                }
            }

        }

    }

