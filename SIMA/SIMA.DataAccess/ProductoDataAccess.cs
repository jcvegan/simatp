using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.DataAccess.Base;
using SIMA.Entities;
using System.Data.SqlClient;

namespace SIMA.DataAccess
{
    public class ProductoDataAccess : DataAccessBase
    {
        EstadoDataAccess estadoAccess;

        public ProductoDataAccess()
        {
            estadoAccess = new EstadoDataAccess();
        }

        public string AgregarProducto(T_C_Producto producto)
        {
            try
            {
                Connection = new SqlConnection(ConnectionString);
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_ProductoInsert", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Descripcion", producto.Descripción);

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

        public string ActualizarProducto(T_C_Producto producto)
        {
            try
            {
                Connection = new SqlConnection(ConnectionString);
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_ProductoUpdate", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Descripcion", producto.Descripción);

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

        public string EliminarProducto(T_C_Producto producto)
        {
            try
            {
                Connection = new SqlConnection(ConnectionString);
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_ProductoDelete", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@Id_Producto", producto.Id_Producto);
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

        public List<T_C_Producto> SeleccionarTodos()
        {
            try
            {
                Connection = new SqlConnection(ConnectionString);
                List<T_C_Producto> productos;
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_AreaSelectAll", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Connection.Open();
                    productos = new List<T_C_Producto>();
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        T_C_Producto producto = new T_C_Producto();
                        producto.Id_Producto = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Producto")).ToString());
                        producto.Descripción = reader.GetValue(reader.GetOrdinal("Descripción")).ToString();
                        producto.Id_Estado = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Estado")).ToString());
                        producto.Estado = estadoAccess.Seleccionar(producto.Id_Estado);
                        productos.Add(producto);
                    }
                }
                return productos;
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

        public List<T_C_Producto> SeleccionarActivos()
        {
            try
            {
                Connection = new SqlConnection(ConnectionString);
                List<T_C_Producto> productos;
                using (Command = new System.Data.SqlClient.SqlCommand("T_C_ProductoSelectActivo", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Connection.Open();
                    productos = new List<T_C_Producto>();
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        T_C_Producto producto = new T_C_Producto();
                        producto.Id_Producto = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Producto")).ToString());
                        producto.Descripción = reader.GetValue(reader.GetOrdinal("Descripción")).ToString();
                        producto.Id_Estado = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Id_Estado")).ToString());
                        producto.Estado = estadoAccess.Seleccionar(producto.Id_Estado);
                        productos.Add(producto);
                    }
                }
                return productos;
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

     
       // public List<T_C_Producto> SeleccionarProductosActivos()
       //{

       //}

        //public T_C_Producto SeleccionarProducto(int idProducto)
        //{
        //}
    }
}
