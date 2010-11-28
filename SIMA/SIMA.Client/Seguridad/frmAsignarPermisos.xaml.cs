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

namespace SIMA.Client.Seguridad
{
    /// <summary>
    /// Lógica de interacción para frmAsignarPermisos.xaml
    /// </summary>
    public partial class frmAsignarPermisos : UserControl
    {
        PermisoDataLogic permisoLogic;
        PerfilDataLogic perfilLogic;
        PermisosPorPerfilDataLogic perxPerLogic;
        List<T_C_Permiso> permisosSeleccionados;
        public frmAsignarPermisos()
        {
            InitializeComponent();
            permisosSeleccionados = new List<T_C_Permiso>();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            perfilLogic = new PerfilDataLogic();
            cmbPerfiles.ItemsSource = perfilLogic.ListarPerfiles();
            permisoLogic = new PermisoDataLogic();
            gvPermisos.ItemsSource = permisoLogic.SeleccionarActivos();
            perxPerLogic = new PermisosPorPerfilDataLogic();
        }

        private void cmbPerfiles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbPerfiles.SelectedItem != null)
            {
                permisosSeleccionados.Clear();
                permisosSeleccionados = perxPerLogic.ListarPermisosPorPerfil((cmbPerfiles.SelectedItem as T_C_Perfil).Id_Perfil);
                foreach (T_C_Permiso per in permisosSeleccionados)
                {
                    foreach (T_C_Permiso pergv in (gvPermisos.ItemsSource as List<T_C_Permiso>))
                    {
                        if (pergv.Id_Permiso == per.Id_Permiso)
                        {
                            gvPermisos.SelectedItems.Add(per);
                        }
                    }
                }
            }
        }
    }
}
