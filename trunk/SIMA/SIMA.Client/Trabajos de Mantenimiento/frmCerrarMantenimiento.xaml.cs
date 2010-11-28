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
        Auxiliares.ClaseCerrarManenimiento clasecerrar;
        T_C_Mantenimiento mantenimiento;
        UsuarioDataLogic usuariologic;
        T_C_Usuario usuario;
        List<Auxiliares.ClaseCerrarManenimiento> listaclasecerrar;
        public frmCerrarMantenimiento()
        {
            InitializeComponent();
            Equipologic = new EquipoDataLogic();
            Mantenimientologic=new MantenimientoDataLogic();
            mantenimiento = new T_C_Mantenimiento();
            usuario = new T_C_Usuario();
            usuariologic = new UsuarioDataLogic();
            listaclasecerrar = new List<SIMA.Client.Auxiliares.ClaseCerrarManenimiento>();
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

            llenargridview();


        }

        private void llenargridview()
        {
            listaclasecerrar = new List<SIMA.Client.Auxiliares.ClaseCerrarManenimiento>();
            foreach (T_C_Equipo equipo in Equipologic.ListarEquiposEnMantenimiento())
            {
                mantenimiento = new T_C_Mantenimiento();
                mantenimiento = Mantenimientologic.SeleccionarMantenimientoPorEquipoEnMantenimiento(equipo.Id_Equipo);
                usuario = usuariologic.SeleccionarUsuario(Convert.ToInt32(mantenimiento.UsuarioRegistro));
                clasecerrar = new Client.Auxiliares.ClaseCerrarManenimiento();
                clasecerrar.id_equipo = equipo.Id_Equipo;
                clasecerrar.descripcion = equipo.Descripcion;
                clasecerrar.usuario = usuario.Nombres + " " + usuario.Apellidos;
                clasecerrar.fechatrabajoinicio = mantenimiento.FechaTrabajoInicio;
                clasecerrar.fechatrabajofin = mantenimiento.FechaTrabajoFin;
                clasecerrar.id_mantenimiento = mantenimiento.Id_Mantenimiento;
                listaclasecerrar.Add(clasecerrar);
            }
            gvCerrarMantenimiento.ItemsSource = listaclasecerrar;
        }

        private void btnCerrarMantenimiento_Click(object sender, RoutedEventArgs e)
        {
            mantenimiento=new T_C_Mantenimiento();
            mantenimiento=Mantenimientologic.SeleccionarMantenimiento((gvCerrarMantenimiento.SelectedItem as Auxiliares.ClaseCerrarManenimiento).id_mantenimiento);
            mantenimiento.Id_Estado = 23;
            Mantenimientologic.ActualizarMantenimiento(mantenimiento);
            llenargridview();
        }

        private void gvCerrarMantenimiento_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangeEventArgs e)
        {

        }

    }
}
