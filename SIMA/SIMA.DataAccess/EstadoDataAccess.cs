using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.DataAccess.Base;
using SIMA.Entities;
using System.Data.SqlClient;

namespace SIMA.DataAccess
{
    public class EstadoDataAccess:DataAccessBase
    {
        private TablaDataAccess tablaAccess;

        public EstadoDataAccess()
            : base()
        {
            tablaAccess = new TablaDataAccess();
        }

        public string AgregarEstado(T_C_Estado estado)
        {
            try
            {
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_EstadoInsert", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_Tabla", estado.Id_Tabla);
                    Command.Parameters.AddWithValue("@Nombre_Estado", estado.Nombre_Estado);
                    Command.Parameters.AddWithValue("@Descripcion_Estado", estado.Descripcion_Estado);
                    Command.Parameters.AddWithValue("@Por_Defecto", estado.Por_Defecto);
                    Command.Parameters.AddWithValue("@Muestra_Informacion", estado.Muestra_Informacion);
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

        public string ActualizarEstado(T_C_Estado estado)
        {
            try
            {
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_EstadoUpdate", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_Estado", estado.Id_Estado);
                    Command.Parameters.AddWithValue("@Id_Tabla", estado.Id_Tabla);
                    Command.Parameters.AddWithValue("@Nombre_Estado", estado.Nombre_Estado);
                    Command.Parameters.AddWithValue("@Descripcion_Estado", estado.Descripcion_Estado);
                    Command.Parameters.AddWithValue("@Por_Defecto", estado.Por_Defecto);
                    Command.Parameters.AddWithValue("@Muestra_Informacion", estado.Muestra_Informacion);
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

        public string EliminarEstado(T_C_Estado estado)
        {
            try
            {
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_EstadoDelete", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_Estado", estado.Id_Estado);

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

        public List<T_C_Estado> SeleccionarTodosEstado()
        {
            try
            {
                Connection = new SqlConnection(ConnectionString);
                List<T_C_Estado> estados;
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_EstadoSelectAll", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Connection.Open();
                    estados = new List<T_C_Estado>();
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        T_C_Estado estado = new T_C_Estado();
                        estado.Id_Estado = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Estado")).ToString());
                        estado.Id_Tabla = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Tabla")).ToString());
                        estado.Nombre_Estado = reader.GetValue(reader.GetOrdinal("Nombre_Estado")).ToString();
                        estado.Descripcion_Estado = reader.GetValue(reader.GetOrdinal("Descripcion_Estado")).ToString();
                        estado.Por_Defecto = Convert.ToBoolean(reader.GetValue(reader.GetOrdinal("Por_Defecto")).ToString());
                        estado.Muestra_Informacion = Convert.ToBoolean(reader.GetValue(reader.GetOrdinal("Muestra_Informacion")).ToString());
                        estado.Tabla = tablaAccess.SeleccionarTabla(estado.Id_Tabla);
                        estados.Add(estado);
                    }
                }
                return estados;
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

        public List<T_C_Estado> SeleccionarPorTabla(string nombretabla)
        {
            try
            {
                Connection = new SqlConnection(ConnectionString);
                List<T_C_Estado> estados;
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_EstadoSelectByNombre_Tabla", Connection))
                {
                    Command.Parameters.AddWithValue("@NombreTabla", nombretabla);
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Connection.Open();
                    estados = new List<T_C_Estado>();
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        T_C_Estado estado = new T_C_Estado();
                        estado.Id_Estado = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Estado")).ToString());
                        estado.Id_Tabla = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Tabla")).ToString());
                        estado.Nombre_Estado = reader.GetValue(reader.GetOrdinal("Nombre_Estado")).ToString();
                        estado.Descripcion_Estado = reader.GetValue(reader.GetOrdinal("Descripcion_Estado")).ToString();
                        estado.Por_Defecto = Convert.ToBoolean(reader.GetValue(reader.GetOrdinal("Por_Defecto")).ToString());
                        estado.Muestra_Informacion = Convert.ToBoolean(reader.GetValue(reader.GetOrdinal("Muestra_Informacion")).ToString());
                        estado.Tabla = tablaAccess.SeleccionarTabla(estado.Id_Tabla);
                        estados.Add(estado);
                    }
                }
                return estados;
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

        public T_C_Estado Seleccionar(int idEstado)
        {
            try
            {
                Connection = new SqlConnection(ConnectionString);
                T_C_Estado estado = new T_C_Estado(); 
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_EstadoSelect", Connection))
                {
                    Command.Parameters.AddWithValue("@Id_Estado", idEstado);
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Connection.Open();
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {                        
                        estado.Id_Estado = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Estado")).ToString());
                        estado.Id_Tabla = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Tabla")).ToString());
                        estado.Nombre_Estado = reader.GetValue(reader.GetOrdinal("Nombre_Estado")).ToString();
                        estado.Descripcion_Estado = reader.GetValue(reader.GetOrdinal("Descripcion_Estado")).ToString();
                        estado.Por_Defecto = Convert.ToBoolean(reader.GetValue(reader.GetOrdinal("Por_Defecto")).ToString());
                        estado.Muestra_Informacion = Convert.ToBoolean(reader.GetValue(reader.GetOrdinal("Muestra_Informacion")).ToString());
                        estado.Tabla = tablaAccess.SeleccionarTabla(estado.Id_Tabla);
                    }
                }
                return estado;
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
