using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.DataAccess.Base;
using SIMA.Entities;
using System.Data.SqlClient;

namespace SIMA.DataAccess
{
    public class SolicitudDataAccess:DataAccessBase
    {
        private EstadoDataAccess estadoAccess;
        public SolicitudDataAccess()
            : base()
        {
            estadoAccess = new EstadoDataAccess();
        }

        public string AgregarSolicitud(T_C_Solicitud solicitud)
        {
            try
            {
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_SolicitudInsert", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    
                    Command.Parameters.AddWithValue("@Descripcion", solicitud.Descripcion);
                    Command.Parameters.AddWithValue("@FechaSolicitud", solicitud.FechaSolicitud);
                    Command.Parameters.AddWithValue("@FechaRespuesta", solicitud.FechaRespuesta);
                    Command.Parameters.AddWithValue("@UsuarioRespuesta", solicitud.UsuarioRespuesta);                   
                    
                    Connection.Open();
                    Command.ExecuteNonQuery();
                }
                return "Registro grabado satisfactoriamente";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                Connection.Close();
            }
        }

        public string AgregarDetalleSolicitud(T_C_DetalleSolicitud Detallesolicitud)
        {
            try
            {
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_DetalleSolicitudInsert", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;

                    Command.Parameters.AddWithValue("@Motivo", Detallesolicitud.Motivo);
                    Command.Parameters.AddWithValue("@ID_Equipo", Detallesolicitud.Id_Equipo);
                    
                    Connection.Open();
                    Command.ExecuteNonQuery();
                }
                return "Registro grabado satisfactoriamente";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                Connection.Close();
            }
        }

        public string ActualizarSolicitud(T_C_Solicitud solicitud)
        {
            try
            {
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_SolicitudUpdate", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_Solicitud", solicitud.Id_Estado);
                    Command.Parameters.AddWithValue("@Descripcion", solicitud.Descripcion);
                    Command.Parameters.AddWithValue("@FechaSolicitud", solicitud.FechaSolicitud);
                    Command.Parameters.AddWithValue("@FechaRespuesta", solicitud.FechaRespuesta);
                    Command.Parameters.AddWithValue("@UsuarioRespuesta", solicitud.UsuarioRespuesta);
                    Command.Parameters.AddWithValue("@Id_OrdenTrabajo", solicitud.Id_OrdenTrabajo);
                    Command.Parameters.AddWithValue("@Motivo", solicitud.Motivo);
                    Command.Parameters.AddWithValue("@Id_Estado", solicitud.Id_Estado);
                    Connection.Open();
                    Command.ExecuteNonQuery();
                }
                return "Registro actualizado satisfactoriamente";
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

        public string EliminarSolicitud(T_C_Solicitud solicitud)
        {
            try
            {
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_SolicitudDelete", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_Solicitud", solicitud.Id_Solicitud);
                    Connection.Open();
                    Command.ExecuteNonQuery();
                }
                return "Registro eliminado satisfactoriamente.";
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

        public string EliminarSolicitudPorEstado(T_C_Solicitud solicitud)
        {
            try
            {
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_SolicitudDeleteAllById_Estado", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_Estado", solicitud.Id_Estado);
                    Connection.Open();
                    Command.ExecuteNonQuery();
                }
                return "Registro eliminado satisfactoriamente.";
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

        public List<T_C_Solicitud> SeleccionarTodosSolicitud()
        {
            try
            {
                List<T_C_Solicitud> solicitudes;
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_SolicitudSelectAll", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Connection.Open();
                    solicitudes = new List<T_C_Solicitud>();
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        T_C_Solicitud solicitud = new T_C_Solicitud();
                        solicitud.Id_Solicitud = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Solicitud")).ToString());
                        solicitud.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion")).ToString();
                        solicitud.FechaSolicitud = Convert.ToDateTime(reader.GetValue(reader.GetOrdinal("FechaSolicitud")).ToString());
                        solicitud.FechaRespuesta = Convert.ToDateTime(reader.GetValue(reader.GetOrdinal("FechaRespuesta")).ToString());
                        solicitud.UsuarioRespuesta = reader.GetValue(reader.GetOrdinal("UsuarioRespuesta")).ToString();                        
                        solicitud.Motivo = reader.GetValue(reader.GetOrdinal("Motivo")).ToString();
                        solicitud.Id_Estado = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Estado")).ToString());
                        solicitudes.Add(solicitud);
                    }
                }
                return solicitudes;
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

        public List<T_C_Solicitud> SeleccionarSolicitud()
        {
            try
            {
                List<T_C_Solicitud> solicitudes;
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_SolicitudSelect", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Connection.Open();
                    solicitudes = new List<T_C_Solicitud>();
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        T_C_Solicitud solicitud = new T_C_Solicitud();
                        solicitud.Id_Solicitud = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Solicitud")).ToString());
                        solicitud.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion")).ToString();
                        solicitud.FechaSolicitud = Convert.ToDateTime(reader.GetValue(reader.GetOrdinal("FechaSolicitud")).ToString());
                        solicitud.FechaRespuesta = Convert.ToDateTime(reader.GetValue(reader.GetOrdinal("FechaRespuesta")).ToString());
                        solicitud.UsuarioRespuesta = reader.GetValue(reader.GetOrdinal("UsuarioRespuesta")).ToString();
                        solicitud.Id_OrdenTrabajo = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_OrdenTrabajo")).ToString());
                        solicitud.Motivo = reader.GetValue(reader.GetOrdinal("Motivo")).ToString();
                        solicitud.Id_Estado = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Estado")).ToString());
                        solicitudes.Add(solicitud);
                    }
                }
                return solicitudes;
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

        public List<T_C_Solicitud> SeleccionarSolicitudPorEstado()
        {
            try
            {
                List<T_C_Solicitud> solicitudes;
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_SolicitudSelectAllById_Estado", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Connection.Open();
                    solicitudes = new List<T_C_Solicitud>();
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        T_C_Solicitud solicitud = new T_C_Solicitud();
                        solicitud.Id_Solicitud = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Solicitud")).ToString());
                        solicitud.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion")).ToString();
                        solicitud.FechaSolicitud = Convert.ToDateTime(reader.GetValue(reader.GetOrdinal("FechaSolicitud")).ToString());
                        solicitud.FechaRespuesta = Convert.ToDateTime(reader.GetValue(reader.GetOrdinal("FechaRespuesta")).ToString());
                        solicitud.UsuarioRespuesta = reader.GetValue(reader.GetOrdinal("UsuarioRespuesta")).ToString();
                        solicitud.Id_OrdenTrabajo = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_OrdenTrabajo")).ToString());
                        solicitud.Motivo = reader.GetValue(reader.GetOrdinal("Motivo")).ToString();
                        solicitud.Id_Estado = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Estado")).ToString());
                        solicitudes.Add(solicitud);
                    }
                }
                return solicitudes;
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
