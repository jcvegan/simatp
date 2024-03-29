﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.Entities;
using SIMA.DataAccess.Base;
using System.Data.SqlClient;

namespace SIMA.DataAccess
{
    public class TipoMantenimientoDataAccess:DataAccessBase
    {   
        private EstadoDataAccess estadoAccess;
        public TipoMantenimientoDataAccess()
            : base()
        {
            estadoAccess = new EstadoDataAccess();
        }
        public string AgregarTipoMantenimiento(T_C_TipoMantenimiento TipoMantenimiento)
        {
            try
            {
                Connection = new SqlConnection(ConnectionString);
                using (Command=new System.Data.SqlClient.SqlCommand("T_C_TipoMantenimientoInsert",Connection))
                {
                    Command.CommandType=System.Data.CommandType.StoredProcedure;                    
                    Command.Parameters.AddWithValue("@Nombre", TipoMantenimiento.Nombre);
                    Command.Parameters.AddWithValue("@Descripcion", TipoMantenimiento.Descripcion);                    
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

        public string ActualizarTipoMantenimiento(T_C_TipoMantenimiento TipoMantenimiento) {
            try
            {
                Connection = new SqlConnection(ConnectionString);
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_TipoMantenimientoUpdate", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_Tipo", TipoMantenimiento.Id_Tipo);
                    Command.Parameters.AddWithValue("@Nombre", TipoMantenimiento.Nombre);
                    Command.Parameters.AddWithValue("@Descripcion", TipoMantenimiento.Descripcion);
                    Command.Parameters.AddWithValue("@Id_Estado", TipoMantenimiento.Id_Estado);
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

        public string EliminarTipoMantenimiento(T_C_TipoMantenimiento TipoMantenimiento)
        {
            try
            {
                Connection = new SqlConnection(ConnectionString);
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_TipoMantenimientoDelete", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_Tipo", TipoMantenimiento.Id_Tipo);
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

        public T_C_TipoMantenimiento SeleccionarTipoMantenimiento(int idMantenimiento)
        {
            try
            {
                Connection = new SqlConnection(ConnectionString);
                T_C_TipoMantenimiento TipoMantenimiento;
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_TipoMantenimientoSelectAll", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Connection.Open();
                    TipoMantenimiento = new T_C_TipoMantenimiento();
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {                        
                        TipoMantenimiento.Id_Tipo = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Tipo")).ToString());
                        TipoMantenimiento.Nombre = reader.GetValue(reader.GetOrdinal("Nombre")).ToString();
                        TipoMantenimiento.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion")).ToString();
                        TipoMantenimiento.Id_Estado = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Estado")).ToString());
                        TipoMantenimiento.Estado = estadoAccess.Seleccionar(TipoMantenimiento.Id_Estado);
                        
                    }
                }
                return TipoMantenimiento;
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

        public List<T_C_TipoMantenimiento> SeleccionarTodosTipoMantenimiento()
        {
            try
            {
                Connection = new SqlConnection(ConnectionString);
                List<T_C_TipoMantenimiento> TipoMantenimientos;
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_TipoMantenimientoSelectAll", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Connection.Open();
                    TipoMantenimientos = new List<T_C_TipoMantenimiento>();
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        T_C_TipoMantenimiento TipoMantenimiento = new T_C_TipoMantenimiento();
                        TipoMantenimiento.Id_Tipo= Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Tipo")).ToString());
                        TipoMantenimiento.Nombre = reader.GetValue(reader.GetOrdinal("Nombre")).ToString();
                        TipoMantenimiento.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion")).ToString();
                        TipoMantenimiento.Id_Estado = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Estado")).ToString());
                        TipoMantenimiento.Estado = estadoAccess.Seleccionar(TipoMantenimiento.Id_Estado);
                        TipoMantenimientos.Add(TipoMantenimiento);
                    }
                }
                return TipoMantenimientos;
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

        public List<T_C_TipoMantenimiento> SeleccionarActivosTipoMantenimiento()
        {
            try
            {
                Connection = new SqlConnection(ConnectionString);
                List<T_C_TipoMantenimiento> TipoMantenimientos;
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_TipoMantenimientoSelectActivo", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Connection.Open();
                    TipoMantenimientos = new List<T_C_TipoMantenimiento>();
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        T_C_TipoMantenimiento TipoMantenimiento = new T_C_TipoMantenimiento();
                        TipoMantenimiento.Id_Tipo = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Tipo")).ToString());
                        TipoMantenimiento.Nombre = reader.GetValue(reader.GetOrdinal("Nombre")).ToString();
                        TipoMantenimiento.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion")).ToString();
                        TipoMantenimiento.Id_Estado = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Estado")).ToString());
                        TipoMantenimiento.Estado = estadoAccess.Seleccionar(TipoMantenimiento.Id_Estado);
                        TipoMantenimientos.Add(TipoMantenimiento);
                    }
                }
                return TipoMantenimientos;
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
