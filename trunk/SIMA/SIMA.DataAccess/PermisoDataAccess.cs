using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.DataAccess.Base;
using SIMA.Entities;

namespace SIMA.DataAccess
{
    public class PermisoDataAccess:DataAccessBase
    {
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
