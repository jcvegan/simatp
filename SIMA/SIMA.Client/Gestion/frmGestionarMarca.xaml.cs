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
        EstadoDataLogic estadoLogic;
        public frmGestionarMarca()
        {
            InitializeComponent();
            
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            marcaLogic = new MarcaDataLogic();
            gvMarcas.ItemsSource = marcaLogic.ListarMarcas();
            estadoLogic = new EstadoDataLogic();
            cmbEstado.ItemsSource = estadoLogic.ListarEstadosPorTabla("T_C_Marca");
            SoloRegistra();
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            T_C_Marca marca = new T_C_Marca();
            marca.Nombre = txtNombre.Text;
            marca.Descripcion = txtDescripcion.Text;
            //marca.Id_Estado = (cmbEstado.SelectedItem as T_C_Estado).Id_Estado;
            MessageBox.Show(marcaLogic.AgregarMarca(marca));
            gvMarcas.ItemsSource = marcaLogic.ListarMarcas();
            Limpia();
            SoloRegistra();
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            T_C_Marca marca = new T_C_Marca();
            marca.Id_Marca = int.Parse(txtCodigoMarca.Text);
            marca.Nombre = txtNombre.Text;
            marca.Descripcion = txtDescripcion.Text;
            marca.Id_Estado = (cmbEstado.SelectedItem as T_C_Estado).Id_Estado;
            MessageBox.Show(marcaLogic.ActualizarMarca(marca));
            gvMarcas.ItemsSource = marcaLogic.ListarMarcas();
            Limpia();
            SoloRegistra();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            T_C_Marca marca = new T_C_Marca();
            marca.Id_Marca = int.Parse(txtCodigoMarca.Text);
            marca.Nombre = txtNombre.Text;
            marca.Descripcion = txtDescripcion.Text;
            marca.Id_Estado = (cmbEstado.SelectedItem as T_C_Estado).Id_Estado;
            MessageBox.Show(marcaLogic.EliminarMarca(marca));
            gvMarcas.ItemsSource = marcaLogic.ListarMarcas();
            Limpia();
            SoloRegistra();
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            Limpia();
        }

        private void gvMarcas_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangeEventArgs e)
        {
            if (gvMarcas.SelectedItem != null)
            {
                lblEstado.Visibility = Visibility.Visible;
                cmbEstado.Visibility = Visibility.Visible;
                T_C_Marca temp = gvMarcas.SelectedItem as T_C_Marca;
                txtCodigoMarca.Text = temp.Id_Marca.ToString();
                txtDescripcion.Text = temp.Descripcion;
                txtNombre.Text = temp.Nombre;

                for (int i = 0; i <= cmbEstado.Items.Count - 1; i++)
                {
                    if ((cmbEstado.Items[i] as T_C_Estado).Id_Estado == temp.Id_Estado)
                    {
                        cmbEstado.SelectedIndex = i;
                        break;
                    }
                }
                TodasOpciones();
            }
        }

        private void SoloRegistra()
        {
            Limpia();
            txtCodigoMarca.Text = "Auto Asignado";
            txtCodigoMarca.IsEnabled = false;
            btnActualizar.IsEnabled = false;
            btnEliminar.IsEnabled = false;
            btnLimpiar.IsEnabled = false;
            btnRegistrar.IsEnabled = true;
            lblEstado.Visibility = Visibility.Hidden;
            cmbEstado.Visibility = Visibility.Hidden;
        }

        private void Limpia()
        {
            txtCodigoMarca.Clear();
            txtDescripcion.Clear();
            txtNombre.Clear();
            btnActualizar.IsEnabled = false;
            btnEliminar.IsEnabled = false;
            btnLimpiar.IsEnabled = false;
            btnRegistrar.IsEnabled = true;
            gvMarcas.SelectedItem = null;
            cmbEstado.SelectedItem = null;
            txtCodigoMarca.Text = "Auto Asignado";
            txtCodigoMarca.IsEnabled = false;
            lblEstado.Visibility = Visibility.Hidden;
            cmbEstado.Visibility = Visibility.Hidden;
        }

        private void TodasOpciones()
        {

            btnActualizar.IsEnabled = true;
            btnEliminar.IsEnabled = true;
            btnLimpiar.IsEnabled = true;
            btnRegistrar.IsEnabled = false;
            lblEstado.Visibility = Visibility.Visible;
            cmbEstado.Visibility = Visibility.Visible;
        }
    }
}
