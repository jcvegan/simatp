using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.DataAccess.Base;
using SIMA.Entities;

namespace SIMA.DataAccess
{
    public class EquipoDataAccess: DataAccessBase
    {
        EstadoDataAccess estadoAccess;
        MarcaDataAccess marcaAccess;
        ModeloDataAccess modeloAccess;

        public EquipoDataAccess()
        {
            estadoAccess = new EstadoDataAccess();
            marcaAccess = new MarcaDataAccess();
        }

        public string AgregarEquipo(T_C_Equipo equipo)
        {
            try
            {
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_EquipoUpdate", Connection))
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

        }
    }
}
