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
        private UsuarioDataAccess usuarioAccess;

        public OrdenTrabajoDataAccess()
            : base()
        {
            estadoAccess = new EstadoDataAccess();
        }

        public string AgregarOrdenTrabajo(T_C_OrdenTrabajo ordentrabajo,out int id)
        {
            try
            {
                Connection = new SqlConnection(ConnectionString);
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_OrdenTrabajoInsert", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Descripcion", ordentrabajo.Descripcion);
                    Command.Parameters.AddWithValue("@CostoTotal", ordentrabajo.CostoTotal);
                    Command.Parameters.AddWithValue("@FechaRegistro", DateTime.Now);
                    Command.Parameters.AddWithValue("@UltimaFechaModificacion", DateTime.Now);
                    Command.Parameters.AddWithValue("@Id_Usuario", 1);
                    Connection.Open();
                    id = (Int32)Command.ExecuteScalar();
                    //id = (int)p.Value;
                }
                return "Registro grabado satisfactoriamente.";
            }
            catch(Exception ex)
            {
                id = 0;
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
                Connection = new SqlConnection(ConnectionString);
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
                Connection = new SqlConnection(ConnectionString);
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
                Connection = new SqlConnection(ConnectionString);
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
                Connection = new SqlConnection(ConnectionString);
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
                Connection = new SqlConnection(ConnectionString);
                List<T_C_OrdenTrabajo> ordenestrabajos;
                Connection = new SqlConnection(ConnectionString);
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
                        ordentrabajo.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion")).ToString();
                        ordentrabajo.CostoTotal = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("CostoTotal")).ToString());
                        ordentrabajo.FechaRegistro = Convert.ToDateTime(reader.GetValue(reader.GetOrdinal("FechaRegistro")).ToString());
                        ordentrabajo.UltimaFechaModificacion = Convert.ToDateTime(reader.GetValue(reader.GetOrdinal("UltimaFechaModificacion")).ToString());
                        ordentrabajo.Estado = estadoAccess.Seleccionar(ordentrabajo.Id_Estado);
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
                Connection = new SqlConnection(ConnectionString);
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
                Connection = new SqlConnection(ConnectionString);
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
                Connection = new SqlConnection(ConnectionString);
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

        public T_C_OrdenTrabajo SeleccionarOrdenTrabajo(int id)
        {
            try
            {
                Connection = new SqlConnection(ConnectionString);
                T_C_OrdenTrabajo ordentrabajo;
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_OrdenTrabajoSelect", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_OrdenTrabajo", id);
                    Connection.Open();
                    ordentrabajo = new T_C_OrdenTrabajo();
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        
                        ordentrabajo.Id_OrdenTrabajo = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_OrdenTrabajo")).ToString());
                        ordentrabajo.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion")).ToString();
                        ordentrabajo.CostoTotal = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("CostoTotal")).ToString());
                        ordentrabajo.FechaRegistro = Convert.ToDateTime(reader.GetValue(reader.GetOrdinal("FechaRegistro")));
                        ordentrabajo.UltimaFechaModificacion = Convert.ToDateTime(reader.GetValue(reader.GetOrdinal("UltimaFechaModificacion")));
                        ordentrabajo.Id_Estado = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Estado")).ToString());
                        ordentrabajo.Id_Usuario = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Usuario")).ToString());
                        
                    }
                }
                return ordentrabajo;
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

        public int BuscarEstadoTerminado()
        {
            try
            {
                Connection = new SqlConnection(ConnectionString);
                int estado = 0;
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_OrdenDeTrabajoBuscarEstadoTerminado", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Connection.Open();
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        estado = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Estado")));
                    }
                }
                return estado;
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
