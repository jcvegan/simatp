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
using System.Windows.Shapes;
using SIMA.Entities;
using SIMA.Client.Auxiliares.EventArgs;
using SIMA.Client.Auxiliares.Enums;
using SIMA.Logic;
using System.Collections.ObjectModel;

namespace SIMA.Client.Auxiliares
{
    /// <summary>
    /// Lógica de interacción para frmConfirmarMantenimiento.xaml
    /// </summary>
    public partial class frmConfirmarMantenimiento : Window
    {
        

        List<T_C_Mantenimiento> detalles;        
        MantenimientoDataLogic matenimiento;
        T_C_Mantenimiento mante;        
        public event EventHandler<ConfirmarMantenimientoEventArgs> SeleccionMantenimiento;

        public frmConfirmarMantenimiento(T_C_Mantenimiento mn)
        {
            InitializeComponent();
            matenimiento = new MantenimientoDataLogic();
            mante = mn;
            //detalles = new List<T_C_Mantenimiento>();
            //mante = new T_C_Mantenimiento();
        }
        
        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            T_C_Mantenimiento manteni = new T_C_Mantenimiento();
            
            //if (txtID.Text != "")
            //{
                //manteni.Id_Mantenimiento = Convert.ToInt32(txtID.Text);
                //manteni.FechaTrabajoInicio = (DateTime)dtFInicio.SelectedDateTime;
                //manteni.FechaTrabajoFin = (DateTime)dtFFin.SelectedDateTime;
                //MessageBox.Show(matenimiento.ActualizarMantenimientoEquipo(manteni));
                if (SeleccionMantenimiento != null)
                {
                   // MessageBox.Show(matenimiento.ActualizarMantenimientoEquipo(manteni));
                    SeleccionMantenimiento(this, new ConfirmarMantenimientoEventArgs(manteni));
                }
                this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Seleccione un Mantenimiento");
            //}

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //txtDescripcion.Text = Convert.ToString(mante.Id_Mantenimiento);
            //detalles = matenimiento.SeleccionarMantenimientoEquipo();
            lblUsuarioApertura.Content = (App.Current.Resources["UsuarioValido"] as UsuarioEventArgs).Usuario.Nombres;
            lblFechaInicio.Content = DateTime.Now;
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
