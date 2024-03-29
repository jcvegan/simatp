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
using System.Windows.Shapes;
using SIMA.Entities;
using SIMA.Client.Auxiliares.EventArgs;
using SIMA.Client.Auxiliares.Enums;
using SIMA.Logic;
using System.Collections.ObjectModel;

namespace SIMA.Client.Auxiliares
{
    /// <summary>
    /// Lógica de interacción para frmSelectorEquipos.xaml
    /// </summary>
    public partial class frmSelectorEquipos : Window
    {
        
        List<T_C_DetalleOrdenDeTrabajo> detalles;
        List<T_C_Equipo> equipos;
        EquipoDataLogic equipoLogic;
        T_C_Equipo equipo;

        public event EventHandler<DetalleOrdenTrabajoEventArgs> Resultado;
        public event EventHandler<EquipoPadreEventArgs> SeleccionEquipos;

        public frmSelectorEquipos()
        {
            InitializeComponent();
            equipoLogic = new EquipoDataLogic();
            detalles = new List<T_C_DetalleOrdenDeTrabajo>();
        }

        public frmSelectorEquipos(List<T_C_DetalleOrdenDeTrabajo> detalle)
        {
            InitializeComponent();
            equipoLogic = new EquipoDataLogic();
            detalles = detalle;
        }

        public frmSelectorEquipos(TipoSeleccionEquipo tipoSeleccion)
        {
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (gvEquipos.SelectedItem != null)
            {
                ObservableCollection<object> equipoTemps = gvEquipos.SelectedItems;
                List<T_C_Equipo> equipos = new List<T_C_Equipo>();                


                foreach (object obj in equipoTemps)
                {
                    T_C_Equipo tmp = (T_C_Equipo)obj;
                    T_C_DetalleOrdenDeTrabajo detTemp = new T_C_DetalleOrdenDeTrabajo();
                    equipos.Add(tmp);
                    detTemp.IdEquipo = tmp.Id_Equipo;
                    detTemp.Cantidad = tmp.Cantidad;
                    detalles.Add(detTemp);
                    equipo = equipoLogic.SeleccionarEquipo(detTemp.IdEquipo);

                    if (detTemp.Cantidad <= 0)
                    {
                        MessageBox.Show("Ingresar una cantidad mayor a 0.");
                        gvEquipos.ItemsSource = equipoLogic.ListarActivos();
                    }
                    else
                    {
                        
                        if (detTemp.Cantidad > equipo.Stock)
                        {
                            MessageBox.Show("La cantidad no debe ser mayor a stock.");
                            gvEquipos.ItemsSource = equipoLogic.ListarActivos();
                        }
                        else
                        {
                            Resultado(this, new DetalleOrdenTrabajoEventArgs(detalles));
                            this.Close();
                        }
                    }
                }                
            }
            else
            {
                MessageBox.Show("Seleccionar Equipos");
            }

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gvEquipos.ItemsSource = equipoLogic.ListarActivos();
            List<T_C_Equipo> equipos = new List<T_C_Equipo>();
            if (detalles.Count > 0)
            {
                foreach (T_C_DetalleOrdenDeTrabajo det in detalles)
                {
                    T_C_Equipo eqtemp = new T_C_Equipo();
                    eqtemp.Id_Equipo = det.IdEquipo;
                    eqtemp.Descripcion = equipoLogic.SeleccionarEquipo(eqtemp.Id_Equipo).Descripcion;
                    eqtemp.Cantidad = det.Cantidad;
                    equipos.Add(eqtemp);
                }
                gvEquipos.ItemsSource = equipos;
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();            
        }
    }
}
