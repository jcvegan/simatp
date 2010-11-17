using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.DataAccess.Base;
using SIMA.Entities;

namespace SIMA.DataAccess
{
    public class DetalleOrdenDeTrabajoDataAccess:DataAccessBase
    {
        private EstadoDataAccess estadoAccess;

        public DetalleOrdenDeTrabajoDataAccess()
            : base()
        {
            estadoAccess = new EstadoDataAccess();
        }

        public string AgregarDetalleOrdenDeTrabajo(T_C_DetalleOrdenDeTrabajo detalleordentrabajo)
        {
            try
            {
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_DetalleOrdenDeTrabajoInsert", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Costo", detalleordentrabajo.Costo);
                    Connection.Open();
                    Command.ExecuteNonQuery();
                }
                return "Detalle grabado satisfactoriamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
