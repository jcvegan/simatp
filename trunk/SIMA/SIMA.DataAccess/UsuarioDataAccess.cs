using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.DataAccess.Base;
using SIMA.Entities;
using SIMA.DataAccess.Extensiones;

namespace SIMA.DataAccess
{
    public class UsuarioDataAccess:DataAccessBase
    {

        public UsuarioDataAccess()
            : base()
        {
        }

        public string AgregarUsuario(T_C_Usuario usuario)
        {
            try
            {
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_UsuarioInsert", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_Usuario", usuario.Id_Usuario);
                    Command.Parameters.AddWithValue("@Nombres", usuario.Nombres);
                    Command.Parameters.AddWithValue("@Apellidos", usuario.Apellidos);
                    Command.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                    Command.Parameters.AddWithValue("@Direccion", usuario.Direccion);
                    Command.Parameters.AddWithValue("@Fecha_Registro", DateTime.Now);
                    Command.Parameters.AddWithValue("@Fecha_Nacimiento", usuario.Fecha_Nacimiento);
                    Command.Parameters.AddWithValue("@Email", usuario.Email);
                    Command.Parameters.AddWithValue("@Contraseña", usuario.Contraseña.Encriptar());
                    Command.Parameters.AddWithValue("@Id_Perfil", usuario.Id_Perfil);
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
