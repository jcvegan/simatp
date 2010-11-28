using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.DataAccess;
using SIMA.Entities;

namespace SIMA.Logic
{
    public class MantenimientoDataLogic
    {
        private MantenimientoDataAccess MantenimientoAccess;

        public MantenimientoDataLogic()
        {
            MantenimientoAccess = new DataAccess.MantenimientoDataAccess();
        }

        public string AgregarMantenimiento(T_C_Mantenimiento Mantenimiento)
        {
            return MantenimientoAccess.AgregarMantenimiento(Mantenimiento);
        }

        public string ActualizarMantenimiento(T_C_Mantenimiento Mantenimiento)
        {
            return MantenimientoAccess.ActualizarMantenimiento(Mantenimiento);
        }

        public string EliminarMantenimiento(T_C_Mantenimiento Mantenimiento)
        {
            return MantenimientoAccess.EliminarMantenimiento(Mantenimiento);
        }

        public List<T_C_Mantenimiento> ListarMantenimientos()
        {
            return MantenimientoAccess.SeleccionarTodosMantenimiento();
        }

        public List<T_C_Mantenimiento> ListarActivosMantenimientos()
        {
            return MantenimientoAccess.SeleccionarActivosMantenimiento();
        }

        public List<T_C_Mantenimiento> SeleccionarMantenimientoEquipo()
        {
            return MantenimientoAccess.SeleccionarMantenimientoEquipo();
        }

        public string ActualizarMantenimientoEquipo(T_C_Mantenimiento Mantenimiento)
        {
            return MantenimientoAccess.ActualizarMantenimientoEquipo(Mantenimiento);
        }

        public List<T_C_Mantenimiento> SeleccionarActivosMantenimientoPorFecha(T_C_Mantenimiento Mantenimiento)
        {
            return MantenimientoAccess.SeleccionarActivosMantenimientoPorFecha(Mantenimiento);
        }

        public T_C_Mantenimiento SeleccionarMantenimientoPorEquipoEnMantenimiento(string id_equipo)
        {
            return MantenimientoAccess.SeleccionarMantenimientoporid_EquipoEnMantenimiento(id_equipo);
        }

        public T_C_Mantenimiento SeleccionarMantenimiento(int id_mantenimiento)
        {
            return MantenimientoAccess.SeleccionarMantenimiento(id_mantenimiento);
        }

        public int BuscaEstadoActivo() 
        {
            return MantenimientoAccess.BuscarEstadoActivo();
        }
    }
}
