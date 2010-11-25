using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.DataAccess.Base;
using SIMA.Entities;
using System.Data;
using System.Data.SqlClient;

namespace SIMA.DataAccess
{
    public class PermisosPorPerfilDataAccess:DataAccessBase
    {
       
        public PermisosPorPerfilDataAccess()
        {
        }

        public List<T_C_Permiso> SeleccionarPermisosPorPerfil(int idPerfil)
        {
            try
            {
                List<T_C_Permiso> permisos = new List<T_C_Permiso>();
                Connection = new System.Data.SqlClient.SqlConnection(ConnectionString);
                using(Command = new System.Data.SqlClient.SqlCommand("T_C_PermisoXPerfilSelectById_Perfil",Connection))
                {
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_Perfil", idPerfil);
                    Connection.Open();
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        T_C_Permiso permiso = new T_C_Permiso();
                        permiso.Id_Permiso = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Permiso")).ToString());
                        permiso = new PermisoDataAccess().SeleccionarPermiso(permiso.Id_Permiso);
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
    }
}
