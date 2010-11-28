using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.Entities;
using System.Data.SqlClient;
using System.Data;
using SIMA.DataAccess.Base;

namespace SIMA.DataAccess
{
    public class MantenimientoDataAccess : Base.DataAccessBase
    { 
        EstadoDataAccess estadoAccess;
        EquipoDataAccess equipoAccess;
        TipoMantenimientoDataAccess tipoMantenimientoAccess;

        public MantenimientoDataAccess()
            : base()
        {
            estadoAccess = new EstadoDataAccess();
            equipoAccess = new EquipoDataAccess();
            tipoMantenimientoAccess = new TipoMantenimientoDataAccess();
        }

        public string AgregarMantenimiento(T_C_Mantenimiento Mantenimiento)
        {
            try
            {
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_MantenimientoInsert", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_Mantenimiento", Mantenimiento.Id_Mantenimiento);
                    Command.Parameters.AddWithValue("@Id_Equipo", Mantenimiento.Id_Equipo);
                    Command.Parameters.AddWithValue("@FechaProgramacion", Mantenimiento.FechaProgramacion);
                    Command.Parameters.AddWithValue("@UsuarioRegistro", Mantenimiento.UsuarioRegistro);
                    Command.Parameters.AddWithValue("@FechaRegistro", Mantenimiento.FechaRegistro);
                    Command.Parameters.AddWithValue("@Id_TipoMantenimiento", Mantenimiento.Id_TipoMantenimiento);
                    Command.Parameters.AddWithValue("@Id_Incidencia", Mantenimiento.Id_Incidencia);
                    Command.Parameters.AddWithValue("@Id_Pedido", Mantenimiento.Id_Pedido);
                    Command.Parameters.AddWithValue("@Prioridad", Mantenimiento.Prioridad);
                    Command.Parameters.AddWithValue("@Id_OrdenTrabajo", Mantenimiento.Id_OrdenTrabajo);
                    Command.Parameters.AddWithValue("@Id_TipoMantenimientoEquipo", Mantenimiento.Id_TipoMantenimientoEquipo);
                    Command.Parameters.AddWithValue("@Id_TurnoMantenimiento", Mantenimiento.Id_TurnoMantenimiento);
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

        public string ActualizarMantenimiento(T_C_Mantenimiento Mantenimiento)
        {
            try
            {
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_MantenimientoUpdate", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_Mantenimiento", Mantenimiento.Id_Mantenimiento);
                    Command.Parameters.AddWithValue("@Id_Equipo", Mantenimiento.Id_Equipo);
                    Command.Parameters.AddWithValue("@FechaProgramacion", Mantenimiento.FechaProgramacion);
                    Command.Parameters.AddWithValue("@UsuarioRegistro", Mantenimiento.UsuarioRegistro);
                    Command.Parameters.AddWithValue("@Id_TipoMantenimiento", Mantenimiento.Id_TipoMantenimiento);
                    Command.Parameters.AddWithValue("@Id_Incidencia", Mantenimiento.Id_Incidencia);
                    Command.Parameters.AddWithValue("@Id_Pedido", Mantenimiento.Id_Pedido);
                    Command.Parameters.AddWithValue("@Prioridad", Mantenimiento.Prioridad);
                    Command.Parameters.AddWithValue("@Id_OrdenTrabajo", Mantenimiento.Id_OrdenTrabajo);
                    Command.Parameters.AddWithValue("@Id_TipoMantenimientoEquipo", Mantenimiento.Id_TipoMantenimientoEquipo);
                    Command.Parameters.AddWithValue("@Id_TurnoMantenimiento", Mantenimiento.Id_TurnoMantenimiento);
                    Command.Parameters.AddWithValue("@Id_Estado", Mantenimiento.Id_Estado);
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

        public string EliminarMantenimiento(T_C_Mantenimiento Mantenimiento)
        {
            try
            {
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_MantenimientoDelete", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_Mantenimiento", Mantenimiento.Id_Mantenimiento);
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

        public List<T_C_Mantenimiento> SeleccionarTodosMantenimiento()
        {
            try
            {
                List<T_C_Mantenimiento> Mantenimientos;
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_MantenimientoselectAll", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Connection.Open();
                    Mantenimientos = new List<T_C_Mantenimiento>();
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        T_C_Mantenimiento Mantenimiento = new T_C_Mantenimiento();
                        Mantenimiento.Id_Mantenimiento = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Mantenimiento")).ToString());
                        Mantenimiento.Id_Equipo = reader.GetValue(reader.GetOrdinal("Id_Equipo")).ToString();
                        Mantenimiento.FechaProgramacion =Convert.ToDateTime(reader.GetValue(reader.GetOrdinal("FechaProgramacion")).ToString());
                        Mantenimiento.UsuarioRegistro = reader.GetValue(reader.GetOrdinal("UsuarioRegistro")).ToString();
                        Mantenimiento.Id_TipoMantenimiento =Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_TipoMantenimiento")).ToString());
                        Mantenimiento.Id_Incidencia = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Incidencia")).ToString());
                        Mantenimiento.Id_Pedido = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Pedido")).ToString());
                        Mantenimiento.Prioridad = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Prioridad")).ToString());
                        Mantenimiento.Id_OrdenTrabajo = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_OrdenTrabajo")).ToString());
                        Mantenimiento.Id_TipoMantenimientoEquipo = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_TipoMantenimientoEquipo")).ToString());
                        Mantenimiento.Id_TurnoMantenimiento = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_TurnoMantenimiento")).ToString());
                        Mantenimiento.Id_Estado = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Estado")).ToString());
                        Mantenimiento.Estado = estadoAccess.Seleccionar(Mantenimiento.Id_Estado);
                        Mantenimientos.Add(Mantenimiento);
                    }
                }
                return Mantenimientos;
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

        public List<T_C_Mantenimiento> SeleccionarActivosMantenimiento()
        {
            try
            {
                List<T_C_Mantenimiento> Mantenimientos;
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_MantenimientoselectActivo", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Connection.Open();
                    Mantenimientos = new List<T_C_Mantenimiento>();
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        T_C_Mantenimiento Mantenimiento = new T_C_Mantenimiento();
                        Mantenimiento.Id_Mantenimiento = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Mantenimiento")).ToString());
                        Mantenimiento.Id_Equipo = reader.GetValue(reader.GetOrdinal("Id_Equipo")).ToString();
                        Mantenimiento.FechaProgramacion = Convert.ToDateTime(reader.GetValue(reader.GetOrdinal("FechaProgramacion")).ToString());
                        Mantenimiento.UsuarioRegistro = reader.GetValue(reader.GetOrdinal("UsuarioRegistro")).ToString();
                        Mantenimiento.Id_TipoMantenimiento = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_TipoMantenimiento")).ToString());
                        Mantenimiento.Id_Incidencia = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Incidencia")).ToString());
                        Mantenimiento.Id_Pedido = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Pedido")).ToString());
                        Mantenimiento.Prioridad = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Prioridad")).ToString());
                        string x=reader.GetValue(reader.GetOrdinal("Id_OrdenTrabajo")).ToString();
                        if (x!="")
                        {
                            Mantenimiento.Id_OrdenTrabajo = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_OrdenTrabajo")).ToString());
                        }
                        Mantenimiento.Id_TipoMantenimientoEquipo = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_TipoMantenimientoEquipo")).ToString());
                        Mantenimiento.Id_TurnoMantenimiento = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_TurnoMantenimiento")).ToString());
                        Mantenimiento.Id_Estado = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Estado")).ToString());
                        Mantenimiento.FechaTrabajoInicio = Convert.ToDateTime(reader.GetValue(reader.GetOrdinal("FechaTrabajoInicio")).ToString());
                        Mantenimiento.FechaTrabajoFin = Convert.ToDateTime(reader.GetValue(reader.GetOrdinal("FechaTrabajoFin")).ToString());
                        Mantenimiento.FechaRegistro = Convert.ToDateTime(reader.GetValue(reader.GetOrdinal("FechaRegistro")).ToString());
                        Mantenimientos.Add(Mantenimiento);
                        
                    }
                }
                return Mantenimientos;
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

        public List<T_C_Mantenimiento> SeleccionarActivosMantenimientoPorFecha(T_C_Mantenimiento Mantenimiento)
        {
            try
            {
                List<T_C_Mantenimiento> Mantenimientos;
                //T_C_Equipo E_id_Equipo;
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_MantenimientoselectActivoFecha", Connection))
                {
                    Command.Parameters.AddWithValue("@FechaTrabajoInicio", Mantenimiento.FechaTrabajoInicio);
                    Command.Parameters.AddWithValue("@FechaTrabajoFin", Mantenimiento.FechaTrabajoFin);
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Connection.Open();
                    Mantenimientos = new List<T_C_Mantenimiento>();
                    //E_id_Equipo = new T_C_Equipo();
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        Mantenimiento = new T_C_Mantenimiento();

                        Mantenimiento.Id_Mantenimiento = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Mantenimiento")).ToString());
                        Mantenimiento.Id_Equipo = reader.GetValue(reader.GetOrdinal("Id_Equipo")).ToString();
                        Mantenimiento.FechaProgramacion = Convert.ToDateTime(reader.GetValue(reader.GetOrdinal("FechaProgramacion")).ToString());
                        Mantenimiento.E_id_Equipo.Descripcion = equipoAccess.SeleccionarEquipo(Mantenimiento.Id_Equipo).Descripcion;
                        Mantenimiento.E_id_TipoMantenimiento.Nombre = tipoMantenimientoAccess.SeleccionarTipoMantenimiento(Mantenimiento.Id_Mantenimiento).Nombre;
                        Mantenimientos.Add(Mantenimiento);
                    }
                }
                return Mantenimientos;
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

        public T_C_Mantenimiento SeleccionarMantenimiento(int idMantenimiento)
        {
            try
            {
                T_C_Mantenimiento Mantenimiento = new T_C_Mantenimiento();
                using (Command = new SqlCommand("T_C_Mantenimientoselect", Connection))
                {
                    Command.Parameters.AddWithValue("@Id_Mantenimiento", idMantenimiento);
                    Command.CommandType = CommandType.StoredProcedure;
                    Connection.Open();
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        
                        Mantenimiento.Id_Mantenimiento = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Mantenimiento")).ToString());
                        Mantenimiento.Id_Mantenimiento = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Mantenimiento")).ToString());
                        Mantenimiento.Id_Turno = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Turno")).ToString());
                        Mantenimiento.Id_Equipo = reader.GetValue(reader.GetOrdinal("Id_Equipo")).ToString();
                        Mantenimiento.FechaProgramacion = Convert.ToDateTime(reader.GetValue(reader.GetOrdinal("FechaProgramacion")).ToString());
                        Mantenimiento.UsuarioRegistro = reader.GetValue(reader.GetOrdinal("UsuarioRegistro")).ToString();
                        Mantenimiento.Id_TipoMantenimiento = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_TipoMantenimiento")).ToString());
                        Mantenimiento.Id_Incidencia = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Incidencia")).ToString());
                        Mantenimiento.Id_Pedido = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Pedido")).ToString());
                        Mantenimiento.Prioridad = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Prioridad")).ToString());
                        Mantenimiento.Id_OrdenTrabajo = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_OrdenTrabajo")).ToString());
                        Mantenimiento.Id_TipoMantenimientoEquipo = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_TipoMantenimientoEquipo")).ToString());
                        Mantenimiento.Id_TurnoMantenimiento = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_TurnoMantenimiento")).ToString());
                        Mantenimiento.Id_Estado = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Estado")).ToString());
                        Mantenimiento.Estado = estadoAccess.Seleccionar(Mantenimiento.Id_Estado);
                        Mantenimiento.FechaTrabajoInicio = Convert.ToDateTime(reader.GetValue(reader.GetOrdinal("FechaTrabajoInicio")).ToString());
                        Mantenimiento.FechaTrabajoFin = Convert.ToDateTime(reader.GetValue(reader.GetOrdinal("FechaTrabajoFin")).ToString());
                        Mantenimiento.FechaRegistro = Convert.ToDateTime(reader.GetValue(reader.GetOrdinal("FechaRegistro")).ToString());
                        
                
                    }
                }
                return Mantenimiento;
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


        public List<T_C_Mantenimiento> SeleccionarMantenimientoEquipo()
        {
            try
            {
                List<T_C_Mantenimiento> Mantenimientos;
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_MantenimientoEquipo", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Connection.Open();
                    Mantenimientos = new List<T_C_Mantenimiento>();
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        T_C_Mantenimiento Mantenimiento = new T_C_Mantenimiento();
                        Mantenimiento.Id_Mantenimiento = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Mantenimiento")).ToString());
                        Mantenimiento.Id_Equipo = reader.GetValue(reader.GetOrdinal("Id_Equipo")).ToString();
                        Mantenimiento.FechaProgramacion = Convert.ToDateTime(reader.GetValue(reader.GetOrdinal("FechaProgramacion")).ToString());
                        Mantenimiento.FechaTrabajoInicio = Convert.ToDateTime(reader.GetValue(reader.GetOrdinal("FechaTrabajoInicio")).ToString());
                        Mantenimiento.FechaTrabajoFin = Convert.ToDateTime(reader.GetValue(reader.GetOrdinal("FechaTrabajoFin")).ToString());
                        Mantenimiento.UsuarioRegistro = reader.GetValue(reader.GetOrdinal("UsuarioRegistro")).ToString();
                        Mantenimiento.FechaRegistro = Convert.ToDateTime(reader.GetValue(reader.GetOrdinal("FechaRegistro")).ToString());
                        Mantenimiento.Id_Estado = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Estado")).ToString());
                        Mantenimiento.Id_TipoMantenimiento = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_TipoMantenimiento")).ToString());
                        Mantenimiento.Id_Incidencia = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Incidencia")).ToString());
                        Mantenimiento.Id_Pedido = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Pedido")).ToString());
                        Mantenimiento.Prioridad = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Prioridad")).ToString());
                        Mantenimiento.Id_OrdenTrabajo = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_OrdenTrabajo")).ToString());
                        Mantenimiento.Id_TipoMantenimientoEquipo = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_TipoMantenimientoEquipo")).ToString());
                        Mantenimiento.Id_TurnoMantenimiento = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_TurnoMantenimiento")).ToString());
                        Mantenimiento.E_id_Equipo.Descripcion = equipoAccess.SeleccionarEquipo(Mantenimiento.Id_Equipo).Descripcion;
                        Mantenimientos.Add(Mantenimiento);
                    }
                }
                return Mantenimientos;
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

        public string ActualizarMantenimientoEquipo(T_C_Mantenimiento Mantenimiento)
        {
            try
            {
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_MantenimientoActualizar", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_Mantenimiento", Mantenimiento.Id_Mantenimiento);
                    Command.Parameters.AddWithValue("@FechaTrabajoInicio", Mantenimiento.FechaTrabajoInicio);
                    Command.Parameters.AddWithValue("@FechaTrabajoFin", Mantenimiento.FechaTrabajoFin);
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
    }
}
