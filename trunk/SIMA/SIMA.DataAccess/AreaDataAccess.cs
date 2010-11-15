using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.DataAccess.Base;
using SIMA.Entities;
using System.Data.SqlClient;

namespace SIMA.DataAccess
{
    public class AreaDataAccess:DataAccessBase
    {
        private EstadoDataAccess estadoAccess;

        public AreaDataAccess()
            : base()
        {
            estadoAccess = new EstadoDataAccess();
        }

        public string AgregarArea(T_C_Area area)
        {
            try
            {
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_AreaInsert", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_Area", area.Id_Area);
                    Command.Parameters.AddWithValue("@Descripcion", area.Descripcion);
                    Command.Parameters.AddWithValue("@Nombre", area.Nombre);
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

        public string ActualizarArea(T_C_Area area)
        {
            try
            {
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_AreaUpdate", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_Area", area.Id_Area);
                    Command.Parameters.AddWithValue("@Nombre", area.Nombre);
                    Command.Parameters.AddWithValue("@Descripcion", area.Descripcion);
                    Command.Parameters.AddWithValue("@Id_Estado", area.Id_Estado);
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

        public string EliminarArea(T_C_Area area)
        {
            try
            {
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_AreaDelete", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_Area", area.Id_Area);
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

        public List<T_C_Area> SeleccionarTodosArea()
        {
            try
            {
                List<T_C_Area> areas;
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_AreaSelectAll", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Connection.Open();
                    areas = new List<T_C_Area>();
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        T_C_Area area = new T_C_Area();
                        area.Id_Area = reader.GetValue(reader.GetOrdinal("Id_Area")).ToString();
                        area.Nombre = reader.GetValue(reader.GetOrdinal("Nombre")).ToString();
                        area.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion")).ToString();
                        area.Id_Estado = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Estado")).ToString());
                        area.Estado = estadoAccess.Seleccionar(area.Id_Estado);
                        areas.Add(area);
                    }
                }
                return areas;
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

        public List<T_C_Area> SeleccionarActivosArea()
        {
            try
            {
                List<T_C_Area> areas;
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_AreaSelectActivo", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Connection.Open();
                    areas = new List<T_C_Area>();
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        T_C_Area area = new T_C_Area();
                        area.Id_Area = reader.GetValue(reader.GetOrdinal("Id_Area")).ToString();
                        area.Nombre = reader.GetValue(reader.GetOrdinal("Nombre")).ToString();
                        area.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion")).ToString();
                        area.Id_Estado = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Estado")).ToString());
                        area.Estado = estadoAccess.Seleccionar(area.Id_Estado);
                        areas.Add(area);
                    }
                }
                return areas;
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

        public T_C_Area SeleccionarArea(string idArea)
        {
           
            try
            {
                T_C_Area area;
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_AreaSelect", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_Area", idArea);
                    Connection.Open();
                    
                    SqlDataReader reader = Command.ExecuteReader();
                    area = new T_C_Area();
                    while (reader.Read())
                    {
                        
                        area.Id_Area = reader.GetValue(reader.GetOrdinal("Id_Area")).ToString();
                        area.Nombre = reader.GetValue(reader.GetOrdinal("Nombre")).ToString();
                        area.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion")).ToString();
                        area.Id_Estado = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Estado")).ToString());
                        area.Estado = estadoAccess.Seleccionar(area.Id_Estado);
                        
                    }
                }
                return area;
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
