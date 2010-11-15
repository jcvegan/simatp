using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using SIMA.DataAccess.Base;
using SIMA.Entities;


namespace SIMA.DataAccess
{
    public class ModeloDataAccess : DataAccessBase
    {
        EstadoDataAccess estadoAccess;
        MarcaDataAccess marcaAccess;

        public ModeloDataAccess()
        {
            estadoAccess = new EstadoDataAccess();
            marcaAccess = new MarcaDataAccess();
        }

        public string AgregarModelo(T_C_Modelo modelo)
        {
            try
            {
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_ModeloInsert", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Descripcion", modelo.Descripcion);
                    Command.Parameters.AddWithValue("@Año", modelo.Año);
                    Command.Parameters.AddWithValue("@Id_Marca", modelo.Id_Marca);
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

        public string ActualizarModelo(T_C_Modelo modelo)
        {
            try
            {
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_ModeloUpdate", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_Modelo", modelo.Id_Modelo);
                    Command.Parameters.AddWithValue("@Descripcion", modelo.Descripcion);
                    Command.Parameters.AddWithValue("@Año", modelo.Año);
                    Command.Parameters.AddWithValue("@Id_Marca", modelo.Id_Marca);
                    Command.Parameters.AddWithValue("@Id_Estado", modelo.Id_Estado);
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

        public string EliminarModelo(T_C_Modelo modelo)
        {
            try
            {
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_ModeloDelete", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_Modelo", modelo.Id_Modelo);
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

        public List<T_C_Modelo> SeleccionarTodosModelo()
        {
            try
            {
                List<T_C_Modelo> modelos;
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_ModeloSelectAll", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Connection.Open();
                    modelos = new List<T_C_Modelo>();
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        T_C_Modelo modelo = new T_C_Modelo();
                        modelo.Id_Modelo=Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Modelo")).ToString());
                        modelo.Id_Marca = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Marca")).ToString());
                        modelo.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion")).ToString();
                        modelo.Año = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Año")).ToString());
                        modelo.Id_Estado = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Estado")).ToString());
                        modelo.Estado = estadoAccess.Seleccionar(modelo.Id_Estado);
                        modelo.Marca = marcaAccess.SeleccionarMarca(modelo.Id_Marca);
                        modelos.Add(modelo);
                    }
                }
                return modelos;
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

        public List<T_C_Modelo> SeleccionarModeloActivo()
        {
            try
            {
                List<T_C_Modelo> modelos;
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_ModeloSelectActivo", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Connection.Open();
                    modelos = new List<T_C_Modelo>();
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        T_C_Modelo modelo = new T_C_Modelo();
                        modelo.Id_Modelo = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Modelo")).ToString());
                        modelo.Id_Marca = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Marca")).ToString());
                        modelo.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion")).ToString();
                        modelo.Año = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Año")).ToString());
                        modelo.Id_Estado = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Estado")).ToString());
                        modelo.Estado = estadoAccess.Seleccionar(modelo.Id_Estado);
                        modelo.Marca = marcaAccess.SeleccionarMarca(modelo.Id_Marca);
                        modelos.Add(modelo);
                    }
                }
                return modelos;
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

        public List<T_C_Modelo> SeleccionarModeloPorMarca(int id_Marca)
        {
            try
            {
                List<T_C_Modelo> modelos;
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_ModeloSelectById_Marca", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_Marca", id_Marca);
                    Connection.Open();
                    modelos = new List<T_C_Modelo>();
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        T_C_Modelo modelo = new T_C_Modelo();
                        modelo.Id_Modelo = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Modelo")).ToString());
                        modelo.Id_Marca = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Marca")).ToString());
                        modelo.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion")).ToString();
                        modelo.Año = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Año")).ToString());
                        modelo.Id_Estado = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Estado")).ToString());
                        modelo.Estado = estadoAccess.Seleccionar(modelo.Id_Estado);
                        modelo.Marca = marcaAccess.SeleccionarMarca(modelo.Id_Marca);
                        modelos.Add(modelo);
                    }
                }
                return modelos;
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

        public T_C_Modelo SeleccionarModelo(int idModelo)
        {
            try
            {
                T_C_Modelo modelo;
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_ModeloSelect", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_Modelo", idModelo);
                    Connection.Open();
                    modelo = new T_C_Modelo();
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        modelo.Id_Modelo = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Modelo")).ToString());
                        modelo.Id_Marca = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Marca")).ToString());
                        modelo.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion")).ToString();
                        modelo.Año = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Año")).ToString());
                        modelo.Id_Estado = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Estado")).ToString());
                        modelo.Estado = estadoAccess.Seleccionar(modelo.Id_Estado);
                        modelo.Marca = marcaAccess.SeleccionarMarca(modelo.Id_Marca);
                    }
                }
                return modelo;
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
