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

        //public string AgregarEstado(T_C_Estado estado)
        //{
        //    try
        //    {
        //        using (Command = new System.Data.SqlClient.SqlCommand("T_C_PerfilInsert", Connection))
        //        {
        //            Command.CommandType = System.Data.CommandType.StoredProcedure;
        //            Command.Parameters.AddWithValue("@Id_Perfil", perfil.Id_Perfil);
        //            Command.Parameters.AddWithValue("@Nombre", perfil.Nombre);
        //            Command.Parameters.AddWithValue("@Descripcion", perfil.Descripcion);
        //            Connection.Open();
        //            Command.ExecuteNonQuery();
        //        }
        //        return "Registro grabado satisfactoriamente.";
        //    }
        //    catch (Exception ex)
        //    {
        //        return ex.Message;
        //    }
        //    finally
        //    {
        //        Connection.Close();
        //    }
        //}
    }
}
