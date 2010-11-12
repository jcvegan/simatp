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
using SIMA.Entities;
using SIMA.Logic;

namespace SIMA.Client.Gestion
{
    /// <summary>
    /// Lógica de interacción para frmGestionarMarca.xaml
    /// </summary>
    public partial class frmGestionarMarca : UserControl
    {
        MarcaDataLogic marcaLogic;
        public frmGestionarMarca()
        {
            InitializeComponent();
            marcaLogic = new MarcaDataLogic();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            gvMarcas.ItemsSource = marcaLogic.SeleccionarTodos();
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            T_C_Marca marca = new T_C_Marca();
            marca.Nombre = txtNombre.Text;
            marca.Descripcion = txtDescripcion.Text;
            //marca.Id_Estado = (cmbEstado.SelectedItem as T_C_Estado).Id_Estado;
            MessageBox.Show(marcaLogic.AgregarMarca(marca));
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void gvMarcas_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangeEventArgs e)
        {

        }
    }
}
