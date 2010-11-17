using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.DataAccess;
using SIMA.Entities;

namespace SIMA.Logic
{
    public class TurnoMantenimientoDataLogic
    {
        private TurnoMantenimientoDataAccess TurnoMantenimientoAccess;

        public TurnoMantenimientoDataLogic()
        {
            TurnoMantenimientoAccess = new TurnoMantenimientoDataAccess();
        }

        public string AgregarTurnoMantenimiento(T_C_TurnoMantenimiento TurnoMantenimiento)
        {
            return TurnoMantenimientoAccess.AgregarTurnoMantenimiento(TurnoMantenimiento);
        }
        public List<T_C_TurnoMantenimiento> ListarActivos()
        {
            return TurnoMantenimientoAccess.ListarTurnoMantenimientosActivos();
        }
        public List<T_C_TurnoMantenimiento> ListarTodos()
        {
            return TurnoMantenimientoAccess.SeleccionarTodosTurnoMantenimiento();
        }
        public T_C_TurnoMantenimiento SeleccionarTurnoMantenimiento(int Id_TurnoMantenimiento)
        {
            return TurnoMantenimientoAccess.SeleccionarTurnoMantenimiento(Id_TurnoMantenimiento);
        }
    }
}
