using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.DataAccess.Base;
using SIMA.Entities;
using SIMA.DataAccess.Extensiones;
using System.Data.SqlClient;

namespace SIMA.DataAccess
{
    public class PermisoDataAccess:DataAccessBase
    {
        private EstadoDataAccess estadoAccess;

        public PermisoDataAccess()
            : base()
        {
            estadoAccess = new EstadoDataAccess();
        }

        public string AgregarPermiso(T_C_Permiso permiso)
        {
            try
            {
                Connection = new SqlConnection(ConnectionString);
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_PermisoInsert", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Nombre", permiso.Nombre);
                    Command.Parameters.AddWithValue("@Descripcion", permiso.Descripcion);
                    Connection.Open();
                    Command.ExecuteNonQuery();
                }
                return "Registro grabado satisfactoriamente.";
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

        public string ActualizarPermiso(T_C_Permiso permiso)
        {
            try
            {
                Connection = new SqlConnection(ConnectionString);
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_PermisoUpdate", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_Permiso", permiso.Id_Permiso);
                    Command.Parameters.AddWithValue("@Nombre", permiso.Nombre);
                    Command.Parameters.AddWithValue("@Descripcion", permiso.Descripcion);
                    Command.Parameters.AddWithValue("@Id_Estado", permiso.Id_Estado);
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

        public string EliminarPermiso(T_C_Permiso permiso)
        {
            try
            {
                Connection = new SqlConnection(ConnectionString);
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_PermisoDelete", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_Permiso", permiso.Id_Permiso);
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

        public List<T_C_Permiso> SeleccionarTodosPermisos()
        {
            try
            {
                Connection = new SqlConnection(ConnectionString);
                List<T_C_Permiso> permisos;
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_PermisoSelectAll", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Connection.Open();
                    permisos = new List<T_C_Permiso>();
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        T_C_Permiso permiso = new T_C_Permiso();
                        permiso.Id_Permiso = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Permiso")).ToString());
                        permiso.Nombre = reader.GetValue(reader.GetOrdinal("Nombre")).ToString();
                        permiso.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion")).ToString();
                        permiso.Id_Estado = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Estado")).ToString());
                        permiso.Estado = estadoAccess.Seleccionar(permiso.Id_Estado);

                        permisos.Add(permiso);
                    }
                }
                return permisos;
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

        public List<T_C_Permiso> SeleccionarPermisosActivos()
        {
            try
            {
                Connection = new SqlConnection(ConnectionString);
                List<T_C_Permiso> permisos;
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_PermisoSelectActivo", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Connection.Open();
                    permisos = new List<T_C_Permiso>();
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        T_C_Permiso permiso = new T_C_Permiso();
                        permiso.Id_Permiso = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Permiso")).ToString());
                        permiso.Nombre = reader.GetValue(reader.GetOrdinal("Nombre")).ToString();
                        permiso.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion")).ToString();
                        permiso.Id_Estado = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Estado")).ToString());
                        permiso.Estado = estadoAccess.Seleccionar(permiso.Id_Estado);

                        permisos.Add(permiso);
                    }
                }
                return permisos;
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
       

        public T_C_Permiso SeleccionarPermiso(int idPermiso)
        {
            try
            {
                T_C_Permiso permiso = new T_C_Permiso();
                Connection = new System.Data.SqlClient.SqlConnection(ConnectionString);
                using(Command = new System.Data.SqlClient.SqlCommand("T_C_PermisoSelect",Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_Permiso", idPermiso);
                    Connection.Open();
                    System.Data.SqlClient.SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        permiso.Id_Permiso = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Permiso")));
                        permiso.Nombre = reader.GetValue(reader.GetOrdinal("Nombre")).ToString();
                        permiso.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion")).ToString();
                        permiso.Id_Estado = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Estado")));
                        permiso.Estado = new EstadoDataAccess().Seleccionar(permiso.Id_Estado);
                    }
                }
                return permiso;
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
