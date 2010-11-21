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

        public string AgregarDetalleOrdenDeTrabajo(T_C_DetalleOrdenDeTrabajo detalleordentrabajo)
        {
            try
            {
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_DetalleOrdenDeTrabajoInsert", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_OrdendeTrabajo", detalleordentrabajo.Id_OrdendeTrabajo);
                    Command.Parameters.AddWithValue("@Costo", detalleordentrabajo.Costo);
                    Command.Parameters.AddWithValue("@Porcentaje", 1);
                    Command.Parameters.AddWithValue("@Motivo", " ");
                    Command.Parameters.AddWithValue("@FechaRegistro", DateTime.Now);
                    Command.Parameters.AddWithValue("@Cantidad", detalleordentrabajo.Cantidad);
                    Command.Parameters.AddWithValue("@Id_Solicitud", 1);
                    Command.Parameters.AddWithValue("@Id_Equipo", detalleordentrabajo.IdEquipo);
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
<<<<<<< .mine
=======

>>>>>>> .r122
                        detalleordentrabajo.Id_DetalleOrdendeTrabajo = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_DetalleOrdendeTrabajo")).ToString());
                        detalles.Add(detalleordentrabajo);
<<<<<<< .mine
=======

>>>>>>> .r122
                        detalleordentrabajo.IdEquipo = reader.GetValue(reader.GetOrdinal("Id_Equipo")).ToString();
                        detalleordentrabajo.Id_DetalleOrdendeTrabajo = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Costo")).ToString());
<<<<<<< .mine
=======
                         

>>>>>>> .r122
                    }
                    return detalles;
                }
                return detalles;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                Connection.Close();
            }
<<<<<<< .mine
=======

>>>>>>> .r122
        }
    }
}
