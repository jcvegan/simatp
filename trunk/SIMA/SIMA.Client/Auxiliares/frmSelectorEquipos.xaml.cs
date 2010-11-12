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

namespace SIMA.Client.Auxiliares
{
    /// <summary>
    /// Lógica de interacción para frmSelectorEquipos.xaml
    /// </summary>
    public partial class frmSelectorEquipos : Window
    {
        List<T_C_DetalleOrdenDeTrabajo> detalles;
        public event EventHandler<DetalleOrdenTrabajoEventArgs> Resultado;

        public frmSelectorEquipos()
        {
            InitializeComponent();
            detalles = new List<T_C_DetalleOrdenDeTrabajo>();
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (Resultado != null)
            {
                Resultado(this, new DetalleOrdenTrabajoEventArgs(detalles));
            }
            this.Close();

        }
    }
}
