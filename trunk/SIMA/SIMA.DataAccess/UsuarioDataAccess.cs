using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.DataAccess.Base;
using SIMA.Entities;
using SIMA.DataAccess.Extensiones;
using System.Data.SqlClient;

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

        public string ActualizarUsuario(T_C_Usuario usuario)
        {
            try
            {
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_UsuarioUpdate", Connection))
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
                    Command.Parameters.AddWithValue("@Id_Estado", usuario.Id_Estado);
                    Command.Parameters.AddWithValue("@Id_Perfil", usuario.Id_Perfil);
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



        public T_C_Usuario SeleccionarTabla(string Id_Usuario, string Contrasenia)
        {
            try
            {
                T_C_Usuario usuario = new T_C_Usuario();
               
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_UsuarioIniciarSesion", Connection))
                {
                    Command.Parameters.AddWithValue("@Id_Usuario", Id_Usuario);
                    Command.Parameters.AddWithValue("@Contraseña", Contrasenia);
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Connection.Open();

                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        usuario.Id_Perfil = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Perfil")).ToString());
                    }
                }
                return usuario;
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
