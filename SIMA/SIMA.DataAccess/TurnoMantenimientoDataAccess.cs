using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.Entities;
using SIMA.DataAccess.Base;
using System.Data.SqlClient;

namespace SIMA.DataAccess
{
    public class TurnoMantenimientoDataAccess:DataAccessBase
    {
        private EstadoDataAccess estadoAccess;
        public TurnoMantenimientoDataAccess()
            : base()
        {
            estadoAccess = new EstadoDataAccess();
        }
        public string AgregarTurnoMantenimiento(T_C_TurnoMantenimiento TurnoMantenimiento)
        {
            try
            {
                using (Command=new System.Data.SqlClient.SqlCommand("T_C_TurnoMantenimientoInsert",Connection))
                {
                    Command.CommandType=System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_TurnoMantenimiento", TurnoMantenimiento.Id_TurnoMantenimiento);
                    Command.Parameters.AddWithValue("@Descripcion", TurnoMantenimiento.Descripcion);
                    Command.Parameters.AddWithValue("@HoraInicio", TurnoMantenimiento.HoraInicio);
                    Command.Parameters.AddWithValue("@HoraFin", TurnoMantenimiento.HoraFin);                    
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

        public string ActualizarTurnoMantenimiento(T_C_TurnoMantenimiento TurnoMantenimiento) {
            try 
            {
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_TurnoMantenimientoUpdate", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_TurnoMantenimiento", TurnoMantenimiento.Id_TurnoMantenimiento);
                    Command.Parameters.AddWithValue("@Descripcion", TurnoMantenimiento.Descripcion);
                    Command.Parameters.AddWithValue("@HoraInicio", TurnoMantenimiento.HoraInicio);
                    Command.Parameters.AddWithValue("@HoraFin", TurnoMantenimiento.HoraFin);
                    Command.Parameters.AddWithValue("@Id_Estado", TurnoMantenimiento.Id_Estado);
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

        public string EliminarTurnoMantenimiento(T_C_TurnoMantenimiento TurnoMantenimiento)
        {
            try
            {
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_TurnoMantenimientoDelete", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_TurnoMantenimiento", TurnoMantenimiento.Id_TurnoMantenimiento);
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

        public T_C_TurnoMantenimiento SeleccionarTurnoMantenimiento(int idMantenimiento)
        {
            try
            {
                T_C_TurnoMantenimiento TurnoMantenimiento;
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_TurnoMantenimientoselectAll", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Connection.Open();
                    TurnoMantenimiento = new T_C_TurnoMantenimiento();
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        TurnoMantenimiento.Id_TurnoMantenimiento = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_TurnoMantenimiento")).ToString());
                        TurnoMantenimiento.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion")).ToString();
                        TurnoMantenimiento.HoraInicio = Convert.ToDouble(reader.GetValue(reader.GetOrdinal("HoraInicio")).ToString());
                        TurnoMantenimiento.HoraFin = Convert.ToDouble(reader.GetValue(reader.GetOrdinal("HoraFin")).ToString());
                        TurnoMantenimiento.Id_Estado = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Estado")).ToString());
                        TurnoMantenimiento.Estado = estadoAccess.Seleccionar(TurnoMantenimiento.Id_Estado);
                        
                    }
                }
                return TurnoMantenimiento;
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

        public List<T_C_TurnoMantenimiento> SeleccionarTodosTurnoMantenimiento()
        {
            try
            {
                List<T_C_TurnoMantenimiento> TurnoMantenimientos;
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_TurnoMantenimientoselectAll", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Connection.Open();
                    TurnoMantenimientos = new List<T_C_TurnoMantenimiento>();
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        T_C_TurnoMantenimiento TurnoMantenimiento = new T_C_TurnoMantenimiento();
                        TurnoMantenimiento.Id_TurnoMantenimiento = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_TurnoMantenimiento")).ToString());
                        TurnoMantenimiento.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion")).ToString();
                        TurnoMantenimiento.HoraInicio = Convert.ToDouble(reader.GetValue(reader.GetOrdinal("HoraInicio")).ToString());
                        TurnoMantenimiento.HoraFin = Convert.ToDouble(reader.GetValue(reader.GetOrdinal("HoraInicio")).ToString());
                        TurnoMantenimiento.Id_Estado = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Estado")).ToString());
                        TurnoMantenimiento.Estado = estadoAccess.Seleccionar(TurnoMantenimiento.Id_Estado);
                        TurnoMantenimientos.Add(TurnoMantenimiento);
                    }
                }
                return TurnoMantenimientos;
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

        public List<T_C_TurnoMantenimiento> ListarTurnoMantenimientosActivos()
        {
            try
            {
                List<T_C_TurnoMantenimiento> TurnoMantenimientos;
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_TurnoMantenimientoselectActivos", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Connection.Open();
                    TurnoMantenimientos = new List<T_C_TurnoMantenimiento>();
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        T_C_TurnoMantenimiento TurnoMantenimiento = new T_C_TurnoMantenimiento();
                        TurnoMantenimiento.Id_TurnoMantenimiento = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_TurnoMantenimiento")).ToString());
                        TurnoMantenimiento.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion")).ToString();
                        TurnoMantenimiento.HoraInicio = Convert.ToDouble(reader.GetValue(reader.GetOrdinal("HoraInicio")).ToString());
                        TurnoMantenimiento.HoraFin = Convert.ToDouble(reader.GetValue(reader.GetOrdinal("HoraInicio")).ToString());
                        TurnoMantenimiento.Id_Estado = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Estado")).ToString());
                        TurnoMantenimiento.Estado = estadoAccess.Seleccionar(TurnoMantenimiento.Id_Estado);
                        TurnoMantenimientos.Add(TurnoMantenimiento);
                    }
                }
                return TurnoMantenimientos;
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
