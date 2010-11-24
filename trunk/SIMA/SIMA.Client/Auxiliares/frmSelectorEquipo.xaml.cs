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
using SIMA.Logic;
using SIMA.Client.Auxiliares.EventArgs;
using SIMA.Entities;

namespace SIMA.Client.Auxiliares
{
    /// <summary>
    /// Lógica de interacción para frmSelectorEquipo.xaml
    /// </summary>
    public partial class frmSelectorEquipo : Window
    {
        EquipoDataLogic equipoLogic;
        T_C_Equipo padre;
        public event EventHandler<EquipoPadreEventArgs> SeleccionaEquipoPadre;
        public frmSelectorEquipo()
        {
            InitializeComponent();
            equipoLogic = new EquipoDataLogic();
        }
        public frmSelectorEquipo(T_C_Equipo eq)
        {
            InitializeComponent();
            equipoLogic = new EquipoDataLogic();
            padre = eq;
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gvEquipos.ItemsSource = equipoLogic.ListarActivos();
            if (padre != null)
            {
                for (int i = 0; i <= gvEquipos.Items.Count; i++)
                {
                    if ((gvEquipos.Items[i] as T_C_Equipo).Id_Equipo == padre.Id_Equipo)
                    {
                        gvEquipos.SelectedItem = gvEquipos.Items[i];
                        break;
                    }
                }
            }
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (gvEquipos.SelectedItem != null)
            {
                if (SeleccionaEquipoPadre != null)
                {
                    SeleccionaEquipoPadre(this, new EquipoPadreEventArgs(gvEquipos.SelectedItem as T_C_Equipo));
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un equipo", "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void RadDataPager_PageIndexChanged(object sender, Telerik.Windows.Controls.PageIndexChangedEventArgs e)
        {
            
        }
    }
}
