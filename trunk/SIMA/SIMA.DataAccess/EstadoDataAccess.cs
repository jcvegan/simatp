using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.DataAccess.Base;
using SIMA.Entities;

namespace SIMA.DataAccess
{
    public class EstadoDataAccess:DataAccessBase
    {
        public EstadoDataAccess()
            : base()
        {
        }

        public string AgregarEstado(T_C_Estado estado)
        {
            try
            {
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_PerfilInsert", Connection))
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
    }
}
