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
using System.Collections.ObjectModel;

namespace SIMA.Client.Auxiliares
{
    /// <summary>
    /// Lógica de interacción para frmSelectorTipoMantenimiento.xaml
    /// </summary>
    public partial class frmSelectorTipoMantenimiento : Window
    {
        TipoMantenimientoDataLogic tipoMantenimientoLogic;
        List<T_C_TipoMantenimiento> tipos;
        List<T_C_TipoMantenimiento> tiposSeleccionado;

        public event EventHandler<TipoMantenimientoEventArgs> resultado;

        public frmSelectorTipoMantenimiento()
        {
            InitializeComponent();
        }

        public frmSelectorTipoMantenimiento(List<T_C_TipoMantenimiento> data)
        {
            InitializeComponent();
            tiposSeleccionado = data;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tipoMantenimientoLogic = new TipoMantenimientoDataLogic();
            tipos = tipoMantenimientoLogic.ListarTipoMantenimientoActivo();
            gvTiposMantenimiento.ItemsSource = tipos;
            if (tiposSeleccionado != null)
            {
                for (int i = 0; i <= gvTiposMantenimiento.Items.Count; i++)
                {
                    foreach(T_C_TipoMantenimiento tip in tiposSeleccionado)
                    {
                        if ((gvTiposMantenimiento.Items[i] as T_C_TipoMantenimiento).Id_Tipo == tip.Id_Tipo)
                        {
                            gvTiposMantenimiento.SelectedItems.Add(gvTiposMantenimiento.Items[i]);
                        }
                    }
                }
            }
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (gvTiposMantenimiento.SelectedItems != null)
            {
                if (resultado != null)
                {
                    tiposSeleccionado = new List<T_C_TipoMantenimiento>();
                    foreach (object o in gvTiposMantenimiento.SelectedItems)
                    {
                        T_C_TipoMantenimiento t = (T_C_TipoMantenimiento)o;
                        tiposSeleccionado.Add(t);
                    }
                    resultado(this, new TipoMantenimientoEventArgs(tiposSeleccionado));
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos un tipo de mantenimiento disponible para el equipo");
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
