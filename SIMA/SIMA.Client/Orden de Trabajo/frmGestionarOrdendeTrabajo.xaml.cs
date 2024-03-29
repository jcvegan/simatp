﻿using System;
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
using SIMA.Client.Auxiliares;
using System.Data.SqlClient;

namespace SIMA.Client.Orden_de_Trabajo
{
    /// <summary>
    /// Lógica de interacción para frmGestionarOrdendeTrabajo.xaml
    /// </summary>
    public partial class frmGestionarOrdendeTrabajo : UserControl
    {
        OrdenTrabajoDataLogic ordentrabajoLogic;
        EstadoDataLogic estadoLogic;
        Logic.DetalleOrdenTrabajoDataLogic detalleordentrabajoLogic;

        List<T_C_DetalleOrdenDeTrabajo> detalle;
        bool vezPrimera = true;

        public frmGestionarOrdendeTrabajo()
        {
            InitializeComponent();
            ordentrabajoLogic = new OrdenTrabajoDataLogic();
            detalle = new List<T_C_DetalleOrdenDeTrabajo>();
            detalleordentrabajoLogic = new DetalleOrdenTrabajoDataLogic();
        }

        private void gvOrdenesTrabajo_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangeEventArgs e)
        {
            if (gvOrdenesTrabajo.SelectedItem != null)
            {
                lblEstado.Visibility = Visibility.Visible;
                cmbEstado.Visibility = Visibility.Visible;

                T_C_OrdenTrabajo ordentrabajo = gvOrdenesTrabajo.SelectedItem as T_C_OrdenTrabajo;
                txtDescripcion.Text = ordentrabajo.Descripcion;
                txtCosto.Text = ordentrabajo.CostoTotal.ToString();
                dtFRegistro.SelectedDateTime = ordentrabajo.FechaRegistro;
                txtIdOrden.Text = Convert.ToString(ordentrabajo.Id_OrdenTrabajo);

                for (int i = 0; i <= cmbEstado.Items.Count; i++)
                {
                    if ((cmbEstado.Items[i] as T_C_Estado).Id_Estado == ordentrabajo.Id_Estado)
                    {
                        cmbEstado.SelectedIndex = i;
                        break;
                    }
                }

                DescripcionEquipo.Text = "Se cuenta con equipos";
                
                lblUsuario.Visibility = Visibility.Visible;
                txtUsuario.Visibility = Visibility.Visible;

                btnActualizar.IsEnabled = true;
                btnEliminar.IsEnabled = true;
                btnLimpiar.IsEnabled = true;
                btnVerDetalle.IsEnabled = true;

                lblCosto.Visibility = Visibility.Visible;
                txtCosto.Visibility = Visibility.Visible;
                txtCosto.IsEnabled = false;

                dtFRegistro.IsEnabled = false;
                
                lblFRegistro.Visibility = Visibility.Visible;
                dtFRegistro.Visibility = Visibility.Visible;                
            }


            else
            {
                DescripcionEquipo.Text = "No cuenta con equipos";

                lblEstado.Visibility = Visibility.Hidden;
                cmbEstado.Visibility = Visibility.Hidden;
                lblUsuario.Visibility = Visibility.Hidden;
                txtUsuario.Visibility = Visibility.Hidden;
                btnActualizar.Visibility = Visibility.Hidden;
                btnEliminar.Visibility = Visibility.Hidden;
                btnLimpiar.Visibility = Visibility.Hidden;
                btnVerDetalle.Visibility = Visibility.Hidden;
                lblCosto.Visibility = Visibility.Hidden;
                txtCosto.Visibility = Visibility.Hidden;
                lblFRegistro.Visibility = Visibility.Hidden;
                
                lblFModificacion.Visibility = Visibility.Hidden;
                dtFModificacion.Visibility = Visibility.Hidden;
            }
            
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            ordentrabajoLogic = new OrdenTrabajoDataLogic();            
            estadoLogic = new EstadoDataLogic();
            cmbEstado.ItemsSource = estadoLogic.ListarEstadosPorTabla("T_C_OrdenTrabajo");
            gvOrdenesTrabajo.ItemsSource = ordentrabajoLogic.ListarOrdenesTrabajo();
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Ingresar Descripcion");
            }
            else
            {
                if (DescripcionEquipo.Text == "No existe ningun detalle")
                {
                    MessageBox.Show("Agregar nuevos Detalles");
                }
                else
                {
                    T_C_OrdenTrabajo ordentrabajo = new T_C_OrdenTrabajo();
                    ordentrabajo.Descripcion = txtDescripcion.Text;
                    ordentrabajo.FechaRegistro = DateTime.Now;


                    MessageBox.Show(ordentrabajoLogic.AgregarOrdenTrabajo(ordentrabajo, detalle));
                    txtDescripcion.Clear();
                    DescripcionEquipo.Text = "No existe ningun detalle";
                    gvOrdenesTrabajo.ItemsSource = ordentrabajoLogic.ListarOrdenesTrabajo();

                }
            }
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            T_C_OrdenTrabajo orden = gvOrdenesTrabajo.SelectedItem as T_C_OrdenTrabajo;
            orden.Descripcion = txtDescripcion.Text;
            orden.UltimaFechaModificacion = DateTime.Now;
            orden.Id_Estado = (cmbEstado.SelectedItem as T_C_Estado).Id_Estado;
            MessageBox.Show(ordentrabajoLogic.ActualizarOrdenTrabajo(orden));
            gvOrdenesTrabajo.ItemsSource = ordentrabajoLogic.ListarOrdenesTrabajo();
            cmbEstado.SelectedItem = null;
            Limpia();            
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            T_C_OrdenTrabajo ordentrabajo = gvOrdenesTrabajo.SelectedItem as T_C_OrdenTrabajo;
            MessageBox.Show(ordentrabajoLogic.EliminarOrdenTrabajo(ordentrabajo));
            gvOrdenesTrabajo.ItemsSource = ordentrabajoLogic.ListarOrdenesTrabajo();
            Limpia();
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            Limpia();
        }

        private void btnVerDetalle_Click(object sender, RoutedEventArgs e)
        {
            if (vezPrimera == true)
            {
                frmSelectorEquipos equiposSelector = new frmSelectorEquipos();
                equiposSelector.Resultado += new EventHandler<SIMA.Client.Auxiliares.EventArgs.DetalleOrdenTrabajoEventArgs>(equiposSelector_Resultado);
                equiposSelector.ShowDialog();
            }
        }

        private void btnAgregarDetalle_Click(object sender, RoutedEventArgs e)
        {
            frmRegistrarDetalles regDetalles = new frmRegistrarDetalles();
            regDetalles.ShowDialog();

        }

        void equiposSelector_Resultado(object sender, SIMA.Client.Auxiliares.EventArgs.DetalleOrdenTrabajoEventArgs e)
        {

        }

        private void Limpia()
        {
            txtDescripcion.Clear();
            DescripcionEquipo.Text = "No existe ningun detalle.";
            detalle.Clear();
            txtCosto.Clear();
            txtCosto.Visibility = Visibility.Hidden;
            lblCosto.Visibility = Visibility.Hidden;
            lblFRegistro.Visibility = Visibility.Hidden;
            lblFModificacion.Visibility = Visibility.Hidden;
            dtFRegistro.Visibility = Visibility.Hidden;
            dtFModificacion.Visibility = Visibility.Hidden;
            lblUsuario.Visibility = Visibility.Hidden;
            txtUsuario.Visibility = Visibility.Hidden;
            lblEstado.Visibility = Visibility.Hidden;
            cmbEstado.Visibility = Visibility.Hidden;
        }
    }
}
