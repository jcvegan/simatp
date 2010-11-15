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

namespace SIMA.Client.Orden_de_Trabajo
{
    /// <summary>
    /// Lógica de interacción para frmGestionarOrdendeTrabajo.xaml
    /// </summary>
    public partial class frmGestionarOrdendeTrabajo : UserControl
    {
        OrdenTrabajoDataLogic ordentrabajoLogic;
        List<T_C_DetalleOrdenDeTrabajo> detalle;
        bool vezPrimera = true;

        public frmGestionarOrdendeTrabajo()
        {
            InitializeComponent();
            ordentrabajoLogic = new OrdenTrabajoDataLogic();
            detalle = new List<T_C_DetalleOrdenDeTrabajo>();
        }

        private void gvOrdenesTrabajo_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangeEventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            T_C_OrdenTrabajo ordentrabajo = new T_C_OrdenTrabajo();
            ordentrabajo.Descripcion = txtCosto.Text;
            MessageBox.Show(ordentrabajoLogic.AgregarOrdenTrabajo(ordentrabajo));
            gvOrdenesTrabajo.ItemsSource = ordentrabajoLogic.ListarOrdenesTrabajo();
            Limpia();
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            Limpia();
        }

        private void btnVerDetalle_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAgregarDetalle_Click(object sender, RoutedEventArgs e)
        {
            if (vezPrimera)
            {
                frmSelectorEquipos equiposSelector = new frmSelectorEquipos();
                equiposSelector.Resultado += new EventHandler<SIMA.Client.Auxiliares.EventArgs.DetalleOrdenTrabajoEventArgs>(equiposSelector_Resultado);
                equiposSelector.Show();
                vezPrimera = false;
            }
            else
            {
                frmSelectorEquipos equiposSelector = new frmSelectorEquipos(detalle);
                equiposSelector.Resultado += new EventHandler<SIMA.Client.Auxiliares.EventArgs.DetalleOrdenTrabajoEventArgs>(equiposSelector_Resultado);
                equiposSelector.Show();
                vezPrimera = false;
            }
        }

        void equiposSelector_Resultado(object sender, SIMA.Client.Auxiliares.EventArgs.DetalleOrdenTrabajoEventArgs e)
        {
            if (e.DetalleOrden.Count > 0)
            {
                detalle = e.DetalleOrden;
                DescripcionEquipo.Text = "Se cuenta con equipos";
            }
            else
            {
                DescripcionEquipo.Text = "No cuenta con equipos";
            }
        }

        private void Limpia()
        {
            txtDescripcion.Clear();
        }
    }
}
