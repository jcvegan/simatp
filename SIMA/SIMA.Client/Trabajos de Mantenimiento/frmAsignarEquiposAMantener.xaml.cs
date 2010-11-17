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

namespace SIMA.Client.Trabajos_de_Mantenimiento
{
    /// <summary>
    /// Lógica de interacción para frmAsignarEquiposAMantener.xaml
    /// </summary>
    public partial class frmAsignarEquiposAMantener : UserControl
    {
        private EquipoDataLogic equipoLogic;
        public frmAsignarEquiposAMantener()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            equipoLogic = new EquipoDataLogic();
            cmbEquipos.ItemsSource = equipoLogic.ListarActivos();
        }
    }
}
