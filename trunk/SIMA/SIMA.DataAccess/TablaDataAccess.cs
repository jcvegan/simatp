using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.Entities;
using SIMA.DataAccess.Base;
using System.Data.SqlClient;

namespace SIMA.DataAccess
{
    public class TablaDataAccess:DataAccessBase
    {
        public string AgregarTabla(T_C_Tabla tabla)
        {
            try
            {
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_TablaInsert", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Nombre_Tabla", tabla.Nombre_Tabla);
                    Command.Parameters.AddWithValue("@Descripcion_Tabla", tabla.Descripcion_Tabla);
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

        public string ActualizarTabla(T_C_Tabla tabla)
        {
            try
            {
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_TablaUpdate", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_Tabla", tabla.Id_Tabla);
                    Command.Parameters.AddWithValue("@Nombre_Tabla", tabla.Nombre_Tabla);
                    Command.Parameters.AddWithValue("@Descripcion_Tabla", tabla.Descripcion_Tabla);
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

        public string EliminarTabla(T_C_Tabla tabla)
        {
            try
            {
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_TablaDelete", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_Tabla", tabla.Id_Tabla);                    
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

        public T_C_Tabla SeleccionarTabla(int idTabla)
        {
            try
            {
                T_C_Tabla tabla = new T_C_Tabla();
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_TablaSelect", Connection))
                {
                    Command.Parameters.AddWithValue("@IdTabla", idTabla);
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Connection.Open();
                    
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        
                        tabla.Id_Tabla = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Tabla")).ToString());
                        tabla.Nombre_Tabla = reader.GetValue(reader.GetOrdinal("Nombre_Tabla")).ToString();
                        tabla.Descripcion_Tabla = reader.GetValue(reader.GetOrdinal("Descripcion_Tabla")).ToString();
                    }
                }
                return tabla;
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

        public List<T_C_Tabla> SeleccionarTodosTabla()
        {
            try
            {
                List<T_C_Tabla> tablas;
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_TablaSelectAll", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Connection.Open();
                    tablas = new List<T_C_Tabla>();
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        T_C_Tabla tabla = new T_C_Tabla();
                        tabla.Id_Tabla = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Tabla")).ToString());
                        tabla.Nombre_Tabla = reader.GetValue(reader.GetOrdinal("Nombre_Tabla")).ToString();
                        tabla.Descripcion_Tabla = reader.GetValue(reader.GetOrdinal("Descripcion_Tabla")).ToString();

                        tablas.Add(tabla);
                    }
                }
                return tablas;
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
