using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.DataAccess.Base;
using SIMA.Entities;
using System.Data.SqlClient;

namespace SIMA.DataAccess
{
    public class EquipoDataAccess: DataAccessBase
    {
        EstadoDataAccess estadoAccess;
        MarcaDataAccess marcaAccess;
        ModeloDataAccess modeloAccess;
        AreaDataAccess areaAccess;

        public EquipoDataAccess()
        {
            estadoAccess = new EstadoDataAccess();
            marcaAccess = new MarcaDataAccess();
            modeloAccess = new ModeloDataAccess();
            areaAccess = new AreaDataAccess();
        }

        public string AgregarEquipo(T_C_Equipo equipo)
        {
            try
            {
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_EquipoInsert", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@EquipoPadre", equipo.EquipoPadre);
                    Command.Parameters.AddWithValue("@Descripcion", equipo.Descripcion);
                    Command.Parameters.AddWithValue("@Id_Marca", equipo.Id_Marca);
                    Command.Parameters.AddWithValue("@Id_Modelo", equipo.Id_Modelo);
                    Command.Parameters.AddWithValue("@Serie", equipo.Serie);
                    Command.Parameters.AddWithValue("@Costo", equipo.Costo);
                    Command.Parameters.AddWithValue("@Fecha_Registro", DateTime.Now);
                    Command.Parameters.AddWithValue("@Fecha_Adquisicion", equipo.Fecha_Adquisicion);
                    Command.Parameters.AddWithValue("@Id_Area", equipo.Id_Area);
                    Command.Parameters.AddWithValue("@MaxHoras", equipo.MaxHoras);
                    Command.Parameters.AddWithValue("@UsoUnico", equipo.UsoUnico);
                    Command.Parameters.AddWithValue("@Nivel", equipo.Nivel);
                    Command.Parameters.AddWithValue("@Stock", equipo.Stock);
                    Command.Parameters.AddWithValue("@CapacidadOperacion", equipo.CapacidadOperacion);
                    Command.Parameters.AddWithValue("@DiamteroInterno", equipo.DiamteroInterno);
                    Command.Parameters.AddWithValue("@RevestimientoInterior", equipo.RevestimientoInterior);
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

        public string ActualizarEquipo(T_C_Equipo equipo)
        {
            try
            {
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_EquipoUpdate", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_Equipo", equipo.Id_Equipo);
                    Command.Parameters.AddWithValue("@EquipoPadre", equipo.EquipoPadre);
                    Command.Parameters.AddWithValue("@Descripcion", equipo.Descripcion);
                    Command.Parameters.AddWithValue("@Id_Marca", equipo.Id_Marca);
                    Command.Parameters.AddWithValue("@Id_Modelo", equipo.Id_Modelo);
                    Command.Parameters.AddWithValue("@Serie", equipo.Serie);
                    Command.Parameters.AddWithValue("@Costo", equipo.Costo);
                    Command.Parameters.AddWithValue("@Id_Estado", equipo.Id_Estado);
                    Command.Parameters.AddWithValue("@Fecha_Registro", DateTime.Now);
                    Command.Parameters.AddWithValue("@Fecha_Adquisicion", equipo.Fecha_Adquisicion);
                    Command.Parameters.AddWithValue("@Id_Area", equipo.Id_Area);
                    Command.Parameters.AddWithValue("@MaxHoras", equipo.MaxHoras);
                    Command.Parameters.AddWithValue("@UsoUnico", equipo.UsoUnico);
                    Command.Parameters.AddWithValue("@Nivel", equipo.Nivel);
                    Command.Parameters.AddWithValue("@Stock", equipo.Stock);
                    Command.Parameters.AddWithValue("@CapacidadOperacion", equipo.CapacidadOperacion);
                    Command.Parameters.AddWithValue("@DiamteroInterno", equipo.DiamteroInterno);
                    Command.Parameters.AddWithValue("@RevestimientoInterior", equipo.RevestimientoInterior);
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

        public string EliminarEquipo(T_C_Equipo equipo)
        {
            try
            {
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_EquipoDelete", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_Equipo", equipo.Id_Equipo);
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

        public List<T_C_Equipo> ListarEquipos()
        {
            try
            {
                List<T_C_Equipo> equipos;
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_EquipoSelectAll", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Connection.Open();
                    equipos = new List<T_C_Equipo>();
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        T_C_Equipo equipo = new T_C_Equipo();
                        equipo.Id_Equipo = reader.GetValue(reader.GetOrdinal("Id_Equipo")).ToString();
                        equipo.EquipoPadre = reader.GetValue(reader.GetOrdinal("EquipoPadre")).ToString();
                        if (equipo.EquipoPadre != string.Empty)
                        {
                            equipo.Padre = SeleccionarEquipo(equipo.EquipoPadre);
                        }
                        equipo.CapacidadOperacion = Convert.ToDecimal(reader.GetValue(reader.GetOrdinal("CapacidadOperacion")).ToString());
                        equipo.Costo = Convert.ToDouble(reader.GetValue(reader.GetOrdinal("Costo")).ToString());
                        equipo.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion")).ToString();
                        equipo.DiamteroInterno = Convert.ToDecimal(reader.GetValue(reader.GetOrdinal("DiamteroInterno")).ToString());
                        equipo.Fecha_Adquisicion = Convert.ToDateTime(reader.GetValue(reader.GetOrdinal("Fecha_Adquisicion")).ToString());
                        equipo.Fecha_Registro = Convert.ToDateTime(reader.GetValue(reader.GetOrdinal("Fecha_Registro")).ToString());
                        equipo.Id_Area = reader.GetValue(reader.GetOrdinal("Id_Area")).ToString();
                        equipo.Area = areaAccess.SeleccionarArea(equipo.Id_Area);
                        equipo.Id_Estado = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Estado")).ToString());
                        equipo.Estado = estadoAccess.Seleccionar(equipo.Id_Estado);
                        equipo.Id_Marca = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Marca")).ToString());
                        equipo.Marca = marcaAccess.SeleccionarMarca(equipo.Id_Marca);
                        equipo.Id_Modelo = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Modelo")).ToString());
                        equipo.Modelo = modeloAccess.SeleccionarModelo(equipo.Id_Modelo);
                        equipo.MaxHoras = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("MaxHoras")).ToString());
                        equipo.Nivel = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Nivel")).ToString());
                        equipo.RevestimientoInterior = reader.GetValue(reader.GetOrdinal("RevestimientoInterior")).ToString();
                        equipo.Serie = reader.GetValue(reader.GetOrdinal("Serie")).ToString();
                        equipos.Add(equipo);
                    }
                }
                return equipos;
            }
            catch(Exception ex)
            {
                return null;
            }
            finally
            {
                Connection.Close();
            }
        }

        public List<T_C_Equipo> ListarEquiposActivos()
        {
            try
            {
                List<T_C_Equipo> equipos;
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_EquipoSelectActivo", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Connection.Open();
                    equipos = new List<T_C_Equipo>();
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        T_C_Equipo equipo = new T_C_Equipo();
                        equipo.Id_Equipo = reader.GetValue(reader.GetOrdinal("Id_Equipo")).ToString();
                        equipo.EquipoPadre = reader.GetValue(reader.GetOrdinal("EquipoPadre")).ToString();
                        if (equipo.EquipoPadre != string.Empty)
                        {
                            equipo.Padre = SeleccionarEquipo(equipo.EquipoPadre);
                        }
                        equipo.CapacidadOperacion = Convert.ToDecimal(reader.GetValue(reader.GetOrdinal("CapacidadOperacion")).ToString());
                        equipo.Costo = Convert.ToDouble(reader.GetValue(reader.GetOrdinal("Costo")).ToString());
                        equipo.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion")).ToString();
                        equipo.DiamteroInterno = Convert.ToDecimal(reader.GetValue(reader.GetOrdinal("DiamteroInterno")).ToString());
                        equipo.Fecha_Adquisicion = Convert.ToDateTime(reader.GetValue(reader.GetOrdinal("Fecha_Adquisicion")).ToString());
                        equipo.Fecha_Registro = Convert.ToDateTime(reader.GetValue(reader.GetOrdinal("Fecha_Registro")).ToString());
                        equipo.Id_Area = reader.GetValue(reader.GetOrdinal("Id_Area")).ToString();
                        equipo.Area = areaAccess.SeleccionarArea(equipo.Id_Area);
                        equipo.Id_Estado = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Estado")).ToString());
                        equipo.Estado = estadoAccess.Seleccionar(equipo.Id_Estado);
                        equipo.Id_Marca = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Marca")).ToString());
                        equipo.Marca = marcaAccess.SeleccionarMarca(equipo.Id_Marca);
                        equipo.Id_Modelo = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Modelo")).ToString());
                        equipo.Modelo = modeloAccess.SeleccionarModelo(equipo.Id_Modelo);
                        equipo.MaxHoras = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("MaxHoras")).ToString());
                        equipo.Nivel = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Nivel")).ToString());
                        equipo.RevestimientoInterior = reader.GetValue(reader.GetOrdinal("RevestimientoInterior")).ToString();
                        equipo.Serie = reader.GetValue(reader.GetOrdinal("Serie")).ToString();
                        equipos.Add(equipo);
                    }
                }
                return equipos;
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

        public T_C_Equipo SeleccionarEquipo(string idEquipo)
        {
            try
            {
                T_C_Equipo equipo;
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_EquipoSelectAllById_Equipo", Connection))
                {
                    Command.Parameters.AddWithValue("@Id_Equipo", idEquipo);
                    Command.CommandType = System.Data.CommandType.StoredProcedure;

                    Connection.Open();
                    equipo = new T_C_Equipo();
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {

                        equipo = new T_C_Equipo();
                        equipo.Id_Equipo = reader.GetValue(reader.GetOrdinal("Id_Equipo")).ToString();
                        equipo.EquipoPadre = reader.GetValue(reader.GetOrdinal("EquipoPadre")).ToString();
                        if (equipo.EquipoPadre != string.Empty)
                        {
                            equipo.Padre = SeleccionarEquipo(equipo.EquipoPadre);
                        }
                        equipo.CapacidadOperacion = Convert.ToDecimal(reader.GetValue(reader.GetOrdinal("CapacidadOperacion")).ToString());
                        equipo.Costo = Convert.ToDouble(reader.GetValue(reader.GetOrdinal("Costo")).ToString());
                        equipo.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion")).ToString();
                        equipo.DiamteroInterno = Convert.ToDecimal(reader.GetValue(reader.GetOrdinal("DiamteroInterno")).ToString());
                        equipo.Fecha_Adquisicion = Convert.ToDateTime(reader.GetValue(reader.GetOrdinal("Fecha_Adquisicion")).ToString());
                        equipo.Fecha_Registro = Convert.ToDateTime(reader.GetValue(reader.GetOrdinal("Fecha_Registro")).ToString());
                        equipo.Id_Area = reader.GetValue(reader.GetOrdinal("Id_Area")).ToString();
                        equipo.Area = areaAccess.SeleccionarArea(equipo.Id_Area);
                        equipo.Id_Estado = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Estado")).ToString());
                        equipo.Estado = estadoAccess.Seleccionar(equipo.Id_Estado);
                        equipo.Id_Marca = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Marca")).ToString());
                        equipo.Marca = marcaAccess.SeleccionarMarca(equipo.Id_Marca);
                        equipo.Id_Modelo = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Modelo")).ToString());
                        equipo.Modelo = modeloAccess.SeleccionarModelo(equipo.Id_Modelo);
                        equipo.MaxHoras = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("MaxHoras")).ToString());
                        equipo.Nivel = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Nivel")).ToString());
                        equipo.RevestimientoInterior = reader.GetValue(reader.GetOrdinal("RevestimientoInterior")).ToString();
                        equipo.Serie = reader.GetValue(reader.GetOrdinal("Serie")).ToString();
                        equipo.Stock = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Stock")).ToString());
                    }
                }
                return equipo;
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
