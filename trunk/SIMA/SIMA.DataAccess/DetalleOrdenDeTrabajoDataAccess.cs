using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.DataAccess.Base;
using SIMA.Entities;
using System.Data.SqlClient;

namespace SIMA.DataAccess
{
    public class DetalleOrdenDeTrabajoDataAccess:DataAccessBase
    {
        private EstadoDataAccess estadoAccess;
        private EquipoDataAccess equipoAccess;

        public DetalleOrdenDeTrabajoDataAccess()
            : base()
        {
            estadoAccess = new EstadoDataAccess();
            equipoAccess = new EquipoDataAccess();
        }

        public string AgregarDetalleOrdenDeTrabajo(T_C_DetalleOrdenDeTrabajo detalleordentrabajo, out int id)
        {
            try
            {
                Connection = new SqlConnection(ConnectionString);
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_DetalleOrdenDeTrabajoInsert", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_OrdendeTrabajo", detalleordentrabajo.Id_OrdendeTrabajo);
                    Command.Parameters.AddWithValue("@Costo", detalleordentrabajo.Costo);
                    Command.Parameters.AddWithValue("@Porcentaje", 1);
                    Command.Parameters.AddWithValue("@Descrippcion", " ");
                    Command.Parameters.AddWithValue("@FechaRegistro", DateTime.Now);
                    Command.Parameters.AddWithValue("@Cantidad", detalleordentrabajo.Cantidad);
                    Command.Parameters.AddWithValue("@Id_Solicitud", 1);
                    Command.Parameters.AddWithValue("@Id_Equipo", detalleordentrabajo.IdEquipo);
                    Command.Parameters.AddWithValue("@FlagEquipo", detalleordentrabajo.Flag);
                    Connection.Open();
                    id = (Int32)Command.ExecuteScalar();
                }
                return "Detalle grabado satisfactoriamente.";
            }
            catch (Exception ex)
            {
                id = 0;
                return ex.Message;
            }
            finally
            {
                Connection.Close();
            }
        }

        public List<T_C_DetalleOrdenDeTrabajo> SeleccionarDetallePorEstado()
        {
            try
            {
                List<T_C_DetalleOrdenDeTrabajo> detalles;
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_DetalleOrdenDeTrabajoSelectAllById_OrdenTrabajo", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Connection.Open();
                    detalles = new List<T_C_DetalleOrdenDeTrabajo>();
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        T_C_DetalleOrdenDeTrabajo detalleordentrabajo = new T_C_DetalleOrdenDeTrabajo();

                        detalleordentrabajo.Id_DetalleOrdendeTrabajo = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_DetalleOrdendeTrabajo")).ToString());
                        detalles.Add(detalleordentrabajo);

                        detalleordentrabajo.IdEquipo = reader.GetValue(reader.GetOrdinal("Id_Equipo")).ToString();
                        detalleordentrabajo.Id_DetalleOrdendeTrabajo = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Costo")).ToString());

                    }
                    return detalles;
                }
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
