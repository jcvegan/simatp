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

namespace SIMA.Client.Auxiliares
{
    /// <summary>
    /// Lógica de interacción para frmMuestraDetalles.xaml
    /// </summary>
    public partial class frmMuestraDetalles : Window
    {
        public frmMuestraDetalles(List<T_C_DetalleOrdenDeTrabajo> detalle)
        {
            InitializeComponent();
            gvDetalleOrden.ItemsSource = detalle;
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
