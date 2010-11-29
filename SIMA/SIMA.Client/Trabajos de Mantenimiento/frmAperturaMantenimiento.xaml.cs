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
    /// Lógica de interacción para frmAperturaMantenimiento.xaml
    /// </summary>
    public partial class frmAperturaMantenimiento : UserControl
    {
        MantenimientoDataLogic mantenimientoLogic;        
        List<T_C_DetalleOrdenDeTrabajo> detalle;
        T_C_Mantenimiento mante;        
        bool vezPrimera = true;
        int ID;

        public frmAperturaMantenimiento()
        {
            InitializeComponent();
            detalle = new List<T_C_DetalleOrdenDeTrabajo>();
        }

        private void UserControl_Loaded_1(object sender, RoutedEventArgs e)
        {
            mantenimientoLogic = new MantenimientoDataLogic();
            mante = new T_C_Mantenimiento();
            BuscarEquipoMantenimiento();
        }

        private void BuscarEquipoMantenimiento()
        {
            gvMantenimiento.ItemsSource = mantenimientoLogic.SeleccionarMantenimientoEquipo();
        }
                       
        private void btnAgregarDetalle_Click(object sender, RoutedEventArgs e)
        {            
            //if (Convert.ToString(ID) != "0")
            //{
            //    frmConfirmarMantenimiento equiposSelector = new frmConfirmarMantenimiento();
            //    equiposSelector.txtID.Text = Convert.ToString(ID);                
            //    equiposSelector.SeleccionMantenimiento += new EventHandler<SIMA.Client.Auxiliares.EventArgs.ConfirmarMantenimientoEventArgs>(equiposSelector_Resultado);
            //    equiposSelector.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Seleccione un Mantenimiento");
            //}
        }

        void equiposSelector_Resultado(object sender, SIMA.Client.Auxiliares.EventArgs.ConfirmarMantenimientoEventArgs e)
        {

            BuscarEquipoMantenimiento();
            //if (e.DetalleOrden.Count > 0)
            //{
            //    detalle = e.DetalleOrden;
            //    DescripcionEquipo.Text = "Se cuenta con equipos";
            //}
            //else
            //{
            //    DescripcionEquipo.Text = "No cuenta con equipos";
            //}
        }

        private void gvMantenimiento_SelectionChanged(object sender, SelectionChangeEventArgs e)
        {
            if (gvMantenimiento.SelectedItem != null)
            {
                T_C_Mantenimiento mante1 = gvMantenimiento.SelectedItem as T_C_Mantenimiento;
                ID = mante1.Id_Mantenimiento;
                                
            }
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            BuscarEquipoMantenimiento();
        }

        private void gvMantenimiento_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            T_C_Mantenimiento mmm = gvMantenimiento.SelectedItem as T_C_Mantenimiento;
            frmConfirmarMantenimiento equiposSelector = new frmConfirmarMantenimiento(mmm);
            
            equiposSelector.SeleccionMantenimiento += new EventHandler<SIMA.Client.Auxiliares.EventArgs.ConfirmarMantenimientoEventArgs>(equiposSelector_Resultado);
            equiposSelector.Show();
        }

    }
}
