using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.Entities;
using SIMA.DataAccess.Base;
using System.Data.SqlClient;

namespace SIMA.DataAccess
{
    public class TipoMantenimientoPorEquipoDataAccess:DataAccessBase
    {
        private TipoMantenimientoDataAccess tipoMantenimientoAccess;
        private EquipoDataAccess equipoAccess;

        public TipoMantenimientoPorEquipoDataAccess()
            : base()
        {
            tipoMantenimientoAccess = new TipoMantenimientoDataAccess();
            equipoAccess = new EquipoDataAccess();
        }

        public List<T_C_TipoMantenimiento> SeleccionarTiposMantenimientoPorEquipo(string idEquipo)
        {
            List<T_C_TipoMantenimiento> tipoMantenimientos;
            try
            {
                tipoMantenimientos = new List<T_C_TipoMantenimiento>();
                using(Command = new System.Data.SqlClient.SqlCommand("T_C_TipoMantenimientoPorEquipoSelectActivo",Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_Equipo", idEquipo);
                    Connection.Open();
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        T_C_TipoMantenimiento tipoMantenimiento = new T_C_TipoMantenimiento();
                        tipoMantenimiento.Id_Tipo = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Tipo")).ToString());
                        tipoMantenimiento = tipoMantenimientoAccess.SeleccionarTipoMantenimiento(tipoMantenimiento.Id_Tipo);
                        tipoMantenimientos.Add(tipoMantenimiento);
                    }
                }
                return tipoMantenimientos;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
