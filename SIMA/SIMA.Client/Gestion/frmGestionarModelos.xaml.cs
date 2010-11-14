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

namespace SIMA.Client.Gestion
{
    /// <summary>
    /// Lógica de interacción para frmGestionarModelos.xaml
    /// </summary>
    public partial class frmGestionarModelos : UserControl
    {
        ModeloDataLogic modeloLogic;
        MarcaDataLogic marcaLogic;
        EstadoDataLogic estadoLogic;
        public frmGestionarModelos()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            modeloLogic = new ModeloDataLogic();
            marcaLogic = new MarcaDataLogic();
            estadoLogic = new EstadoDataLogic();
            udAño.Maximum = DateTime.Now.Year;
            gvModelo.ItemsSource = modeloLogic.ListarTodos();
            cmbMarca.ItemsSource = marcaLogic.ListarActivosMarcas();
            cmbEstado.ItemsSource = estadoLogic.ListarEstadosPorTabla("T_C_Modelo");
            Limpia();
            SoloRegistra();
        }

        private void SoloRegistra()
        {
            Limpia();
            txtCodigoModelo.Text = "Auto Asignado";
            txtCodigoModelo.IsEnabled = false;
            btnActualizar.IsEnabled = false;
            btnEliminar.IsEnabled = false;
            btnLimpiar.IsEnabled = false;
            btnRegistrar.IsEnabled = true;
            lblEstado.Visibility = Visibility.Hidden;
            cmbEstado.Visibility = Visibility.Hidden;
        }

        private void Limpia()
        {
            txtCodigoModelo.Clear();
            txtDescripcion.Clear();
            udAño.Value = udAño.Minimum;
            btnActualizar.IsEnabled = false;
            btnEliminar.IsEnabled = false;
            btnLimpiar.IsEnabled = false;
            btnRegistrar.IsEnabled = true;
            gvModelo.SelectedItem = null;
            cmbEstado.SelectedItem = null;
            cmbMarca.SelectedItem = null;
            txtCodigoModelo.Text = "Auto Asignado";
            txtCodigoModelo.IsEnabled = false;
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

        private void gvModelos_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangeEventArgs e)
        {
            if (gvModelo.SelectedItem != null)
            {
                TodasOpciones();
                T_C_Modelo temp = gvModelo.SelectedItem as T_C_Modelo;
                txtDescripcion.Text = temp.Descripcion;
                txtCodigoModelo.Text = temp.Id_Modelo.ToString();
                udAño.Value = temp.Año;
                for (int i = 0; i <= cmbMarca.Items.Count - 1; i++)
                {
                    if ((cmbMarca.Items[i] as T_C_Marca).Id_Marca == temp.Id_Marca)
                    {
                        cmbMarca.SelectedIndex = i;
                        break;
                    }
                }

                for (int i = 0; i <= cmbEstado.Items.Count - 1; i++)
                {
                    if ((cmbEstado.Items[i] as T_C_Estado).Id_Estado == temp.Id_Estado)
                    {
                        cmbEstado.SelectedIndex = i;
                        break;
                    }
                }
            }
            else
            {
                SoloRegistra();
            }
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            T_C_Modelo modelo = new T_C_Modelo();
            modelo.Id_Marca = (cmbMarca.SelectedItem as T_C_Marca).Id_Marca;
            modelo.Descripcion = txtDescripcion.Text;
            modelo.Año = int.Parse(udAño.Value.ToString());
            MessageBox.Show(modeloLogic.AgregarModelo(modelo));
            gvModelo.ItemsSource = modeloLogic.ListarTodos();
            Limpia();
            SoloRegistra();
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            T_C_Modelo modelo = gvModelo.SelectedItem as T_C_Modelo;
            modelo.Año = int.Parse(udAño.Value.ToString());
            modelo.Descripcion = txtDescripcion.Text;
            modelo.Id_Estado = (cmbEstado.SelectedItem as T_C_Estado).Id_Estado;
            MessageBox.Show(modeloLogic.ActualizarModelo(modelo));
            gvModelo.ItemsSource = modeloLogic.ListarTodos();
            Limpia();
            SoloRegistra();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            T_C_Modelo modelo = gvModelo.SelectedItem as T_C_Modelo;
            MessageBox.Show(modeloLogic.EliminarModelo(modelo));
            Limpia();
            SoloRegistra();
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            Limpia();
            SoloRegistra();
        }
    }
}
