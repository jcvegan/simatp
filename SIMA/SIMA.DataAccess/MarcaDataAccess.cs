﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.Entities;
using SIMA.DataAccess.Base;
using System.Data.SqlClient;
using System.Data;

namespace SIMA.DataAccess
{
    public class MarcaDataAccess : DataAccessBase
    {
        EstadoDataAccess estadoAccess;

        public MarcaDataAccess()
            : base()
        {
            estadoAccess = new EstadoDataAccess();
        }

        public string AgregarMarca(T_C_Marca marca)
        {
            try
            {
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_MarcaInsert", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Descripcion", marca.Descripcion);
                    Command.Parameters.AddWithValue("@Nombre", marca.Nombre);
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

        public string ActualizarMarca(T_C_Marca marca)
        {
            try
            {
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_MarcaUpdate", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_Marca", marca.Id_Marca);
                    Command.Parameters.AddWithValue("@Descripcion", marca.Descripcion);
                    Command.Parameters.AddWithValue("@Nombre", marca.Nombre);
                    Command.Parameters.AddWithValue("@Id_Estado", marca.Id_Estado);
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

        public string EliminarMarca(T_C_Marca marca)
        {
            try
            {
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_MarcaDelete", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_Marca", marca.Id_Marca);
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

        public List<T_C_Marca> SeleccionarTodosMarca()
        {
            try
            {
                Connection = new SqlConnection(ConnectionString);
                List<T_C_Marca> marcas;
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_MarcaSelectAll", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Connection.Open();
                    marcas = new List<T_C_Marca>();
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        T_C_Marca marca = new T_C_Marca();
                        marca.Id_Marca = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Marca")).ToString());
                        marca.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion")).ToString();
                        marca.Nombre = reader.GetValue(reader.GetOrdinal("Nombre")).ToString();
                        marca.Id_Estado = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Estado")).ToString());
                        marca.Estado = estadoAccess.Seleccionar(marca.Id_Estado);
                        marcas.Add(marca);
                    }
                }
                return marcas;
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

        public List<T_C_Marca> SeleccionarActivosMarca()
        {
            try
            {
                Connection = new SqlConnection(ConnectionString);
                List<T_C_Marca> marcas;
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_MarcaSelectActivo", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Connection.Open();
                    marcas = new List<T_C_Marca>();
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        T_C_Marca marca = new T_C_Marca();
                        marca.Id_Marca = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Marca")).ToString());
                        marca.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion")).ToString();
                        marca.Nombre = reader.GetValue(reader.GetOrdinal("Nombre")).ToString();
                        marca.Id_Estado = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Estado")).ToString());
                        marca.Estado = estadoAccess.Seleccionar(marca.Id_Estado);
                        marcas.Add(marca);
                    }
                }
                return marcas;
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

        public T_C_Marca SeleccionarMarca(int idMarca)
        {
            try
            {
                Connection = new SqlConnection(ConnectionString);
                T_C_Marca marca = new T_C_Marca();
                using (Command = new SqlCommand("T_C_MarcaSelect", Connection))
                {
                    Command.Parameters.AddWithValue("@Id_Marca", idMarca);
                    Command.CommandType = CommandType.StoredProcedure;
                    Connection.Open();
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        marca.Id_Marca = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Marca")).ToString());
                        marca.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion")).ToString();
                        marca.Nombre = reader.GetValue(reader.GetOrdinal("Nombre")).ToString();
                        marca.Id_Estado = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Estado")).ToString());
                        marca.Estado = estadoAccess.Seleccionar(marca.Id_Estado);
                    }
                }
                return marca;
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
