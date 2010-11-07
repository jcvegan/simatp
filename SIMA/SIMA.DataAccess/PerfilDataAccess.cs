using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.DataAccess.Base;
using SIMA.Entities;
using System.Data.SqlClient;

namespace SIMA.DataAccess
{
    public class PerfilDataAccess:DataAccessBase
    {
        private EstadoDataAccess estadoAccess;
        public PerfilDataAccess()
            : base()
        {
            estadoAccess = new EstadoDataAccess();
        }

        public string AgregarPerfil(T_C_Perfil perfil)
        {
            try
            {
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_PerfilInsert", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_Perfil", perfil.Id_Perfil);
                    Command.Parameters.AddWithValue("@Nombre", perfil.Nombre);
                    Command.Parameters.AddWithValue("@Descripcion", perfil.Descripcion);
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

        public string ActualizarPerfil(T_C_Perfil perfil)
        {
            try
            {
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_PerfilUpdate", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_Perfil", perfil.Id_Perfil);
                    Command.Parameters.AddWithValue("@Nombre", perfil.Nombre);
                    Command.Parameters.AddWithValue("@Descripcion", perfil.Descripcion);
                    Command.Parameters.AddWithValue("@Id_Estado", perfil.Id_Estado);
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

        public string EliminarPerfil(T_C_Perfil perfil)
        {
            try
            {
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_PerfilDelete", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_Perfil", perfil.Id_Perfil);
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

        public List<T_C_Perfil> SeleccionarTodosPerfil()
        {
            try
            {
                List<T_C_Perfil> perfiles;
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_PerfilSelectAll", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Connection.Open();
                    perfiles = new List<T_C_Perfil>();
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        T_C_Perfil perfil = new T_C_Perfil();
                        perfil.Id_Perfil = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Perfil")).ToString());
                        perfil.Nombre = reader.GetValue(reader.GetOrdinal("Nombre")).ToString();
                        perfil.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion")).ToString();
                        perfil.Id_Estado = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Estado")).ToString());
                        perfil.Estado = estadoAccess.Seleccionar(perfil.Id_Estado);
                        perfiles.Add(perfil);
                    }
                }
                return perfiles;
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
