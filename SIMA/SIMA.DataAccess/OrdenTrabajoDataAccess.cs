using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.DataAccess.Base;
using SIMA.Entities;
using System.Data.SqlClient;

namespace SIMA.DataAccess
{
    public class OrdenTrabajoDataAccess:DataAccessBase
    {
        private EstadoDataAccess estadoAccess;
        public OrdenTrabajoDataAccess()
            : base()
        {
            estadoAccess = new EstadoDataAccess();
        }

        public string AgregarOrdenTrabajo(T_C_OrdenTrabajo ordentrabajo)
        {
            try
            {
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_OrdenTrabajoInsert", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_OrdenTrabajo", ordentrabajo.Id_OrdenTrabajo);
                    Command.Parameters.AddWithValue("@Descripcion", ordentrabajo.Descripcion);
                    Command.Parameters.AddWithValue("@CostoTotal", ordentrabajo.CostoTotal);
                    Command.Parameters.AddWithValue("@FechaRegistro", ordentrabajo.FechaRegistro);
                    Command.Parameters.AddWithValue("@UltimaFechaModificacion", ordentrabajo.UltimaFechaModificacion);
                    Command.Parameters.AddWithValue("@Id_Usuario", ordentrabajo.Id_Usuario);
                    Connection.Open();
                    Command.ExecuteNonQuery();
                }
                return "Registro grabado satisfactoriamente.";
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

        public string ActualizarOrdenTrabajo(T_C_OrdenTrabajo ordentrabajo)
        {
            try
            {
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_OrdenTrabajoUpdate", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_OrdenTrabajo", ordentrabajo.Id_OrdenTrabajo);
                    Command.Parameters.AddWithValue("@Descripcion",ordentrabajo.Descripcion);
                    Command.Parameters.AddWithValue("@CostoTotal", ordentrabajo.CostoTotal);
                    Command.Parameters.AddWithValue("@FechaRegistro", ordentrabajo.FechaRegistro);
                    Command.Parameters.AddWithValue("@UltimaFechaModificacion", ordentrabajo.UltimaFechaModificacion);
                    Command.Parameters.AddWithValue("@Id_Estado", ordentrabajo.Id_Estado);
                    Command.Parameters.AddWithValue("@Id_Usuario", ordentrabajo.Id_Usuario);
                    Connection.Open();
                    Command.ExecuteNonQuery();
                }
                return "Registro actualizado satisfactoriamente.";
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

        public string EliminarOrdenTrabajo(T_C_OrdenTrabajo ordentrabajo)
        {
            try
            {
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_OrdenTrabajoDelete", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_OrdenTrabajo", ordentrabajo.Id_OrdenTrabajo);
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

        public string EliminarOrdenTrabajoPorEstado(T_C_OrdenTrabajo ordentrabajo)
        {
            try
            {
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_OrdenTrabajoDeleteAllById_Estado", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_OrdenTrabajo", ordentrabajo.Id_OrdenTrabajo);
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

        public string EliminarOrdenTrabajoPorUsuario(T_C_OrdenTrabajo ordentrabajo)
        {
            try
            {
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_OrdenTrabajoDeleteAllById_Usuario", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_Usuario", ordentrabajo.Id_Usuario);
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

        public List<T_C_OrdenTrabajo> SeleccionarTodosOrdenTrabajo()
        {
            try
            {
                List<T_C_OrdenTrabajo> ordenestrabajos;
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_OrdenTrabajoSelectAll", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Connection.Open();
                    ordenestrabajos = new List<T_C_OrdenTrabajo>();
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {

                        T_C_OrdenTrabajo ordentrabajo = new T_C_OrdenTrabajo();
                        ordentrabajo.Id_OrdenTrabajo = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_OrdenTrabajo")).ToString());
                        ordentrabajo.Descripcion = reader.GetValue(reader.GetOrdinal("Id_OrdenTrabajo")).ToString();
                        ordentrabajo.CostoTotal = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("CostoTotal")).ToString());
                        ordentrabajo.FechaRegistro = Convert.ToDateTime(reader.GetValue(reader.GetOrdinal("FechaRegistro")).ToString());
                        ordentrabajo.UltimaFechaModificacion = Convert.ToDateTime(reader.GetValue(reader.GetOrdinal("UltimaFechaModificacion")).ToString());
                        ordentrabajo.Id_Estado = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Estado")).ToString());
                        ordentrabajo.Id_Usuario = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Usuario")).ToString());
                        ordenestrabajos.Add(ordentrabajo);
                    }
                }
                return ordenestrabajos;
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

        public List<T_C_OrdenTrabajo> SeleccionarOrdenTrabajo()
        {
            try
            {
                List<T_C_OrdenTrabajo> ordenestrabajos;
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_OrdenTrabajoSelect", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Connection.Open();
                    ordenestrabajos = new List<T_C_OrdenTrabajo>();
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {

                        T_C_OrdenTrabajo ordentrabajo = new T_C_OrdenTrabajo();
                        ordentrabajo.Id_OrdenTrabajo = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_OrdenTrabajo")).ToString());
                        ordentrabajo.Descripcion = reader.GetValue(reader.GetOrdinal("Id_OrdenTrabajo")).ToString();
                        ordentrabajo.CostoTotal = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("CostoTotal")).ToString());
                        ordentrabajo.FechaRegistro = Convert.ToDateTime(reader.GetValue(reader.GetOrdinal("FechaRegistro")).ToString());
                        ordentrabajo.UltimaFechaModificacion = Convert.ToDateTime(reader.GetValue(reader.GetOrdinal("UltimaFechaModificacion")).ToString());
                        ordentrabajo.Id_Estado = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Estado")).ToString());
                        ordentrabajo.Id_Usuario = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Usuario")).ToString());
                        ordenestrabajos.Add(ordentrabajo);
                    }
                }
                return ordenestrabajos;
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

        public List<T_C_OrdenTrabajo> SeleccionarOrdenTrabajoPorEstado()
        {
            try
            {
                List<T_C_OrdenTrabajo> ordenestrabajos;
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_OrdenTrabajoSelectAllById_Estado", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Connection.Open();
                    ordenestrabajos = new List<T_C_OrdenTrabajo>();
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {

                        T_C_OrdenTrabajo ordentrabajo = new T_C_OrdenTrabajo();
                        ordentrabajo.Id_OrdenTrabajo = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_OrdenTrabajo")).ToString());
                        ordentrabajo.Descripcion = reader.GetValue(reader.GetOrdinal("Id_OrdenTrabajo")).ToString();
                        ordentrabajo.CostoTotal = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("CostoTotal")).ToString());
                        ordentrabajo.FechaRegistro = Convert.ToDateTime(reader.GetValue(reader.GetOrdinal("FechaRegistro")).ToString());
                        ordentrabajo.UltimaFechaModificacion = Convert.ToDateTime(reader.GetValue(reader.GetOrdinal("UltimaFechaModificacion")).ToString());
                        ordentrabajo.Id_Estado = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Estado")).ToString());
                        ordentrabajo.Id_Usuario = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Usuario")).ToString());
                        ordenestrabajos.Add(ordentrabajo);
                    }
                }
                return ordenestrabajos;
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

        public List<T_C_OrdenTrabajo> SeleccionarOrdenTrabajoPorUsuario()
        {
            try
            {
                List<T_C_OrdenTrabajo> ordenestrabajos;
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_OrdenTrabajoSelectAllById_Usuario", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Connection.Open();
                    ordenestrabajos = new List<T_C_OrdenTrabajo>();
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {

                        T_C_OrdenTrabajo ordentrabajo = new T_C_OrdenTrabajo();
                        ordentrabajo.Id_OrdenTrabajo = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_OrdenTrabajo")).ToString());
                        ordentrabajo.Descripcion = reader.GetValue(reader.GetOrdinal("Id_OrdenTrabajo")).ToString();
                        ordentrabajo.CostoTotal = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("CostoTotal")).ToString());
                        ordentrabajo.FechaRegistro = Convert.ToDateTime(reader.GetValue(reader.GetOrdinal("FechaRegistro")).ToString());
                        ordentrabajo.UltimaFechaModificacion = Convert.ToDateTime(reader.GetValue(reader.GetOrdinal("UltimaFechaModificacion")).ToString());
                        ordentrabajo.Id_Estado = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Estado")).ToString());
                        ordentrabajo.Id_Usuario = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Usuario")).ToString());
                        ordenestrabajos.Add(ordentrabajo);
                    }
                }
                return ordenestrabajos;
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
