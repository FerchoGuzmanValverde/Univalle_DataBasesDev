using Ferale.SistemaDeInformacionApp.SIFComun;
using System;
using System.Data.SqlClient;

namespace Ferale.SistemaDeInformacionApp.ProductosDal
{
    /// <summary>
    /// Clase Productos Dal que sirve para interactuar con la base de datos
    /// </summary>
    public class ProductosDal
    {
        /// <summary>
        /// Inserta un Producto a la base de datos 
        /// </summary>
        /// <param name="producto"></param>
        public static void Insertar(Producto producto)
        {
            Operaciones.WriteLogsDebug("ProductoDal", "Insertar", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para crear un producto"));

            SqlCommand command = null;

            //Consulta para insertar productos
            string queryString = @"INSERT INTO Producto(nombreProducto, precioBase, variedad, areaProducto) 
                                    VALUES(@nombreProducto, @precioBase, @variedad, @areaProducto)";
            //Declaro e inicio la conexion
            SqlConnection conexion = OperacionesSql.ObtenerConexion();

            //Declaro la transaccion
            SqlTransaction transaccion = null;
            try
            {
                //Abro la conexion a la base de datos
                conexion.Open();

                //Inicio la transaccion
                transaccion = conexion.BeginTransaction();

                //Inserto al empleado
                command = OperacionesSql.CreateBasicCommandWithTransaction(queryString, transaccion, conexion);
                command.Parameters.AddWithValue("@nombreProducto", producto.NombreProducto);
                command.Parameters.AddWithValue("@precioBase", producto.PrecioBase);
                command.Parameters.AddWithValue("@variedad", producto.Variedad);
                command.Parameters.AddWithValue("@areaProducto", producto.AreaProducto);
                OperacionesSql.ExecuteBasicCommandWithTransaction(command);

                transaccion.Commit();

            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("ProductoDal", "Insertar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("ProductoDal", "Insertar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
            Operaciones.WriteLogsDebug("ProductoDal", "Insertar", string.Format("{0} {1} Info: {2}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "Termino de ejecutar  el metodo acceso a datos para insertar producto"));
        }

        /// <summary>
        /// Actualiza Producto de la base de datos
        /// </summary>
        /// <param name="Producto"></param>
        public static void Actualizar(Producto producto)
        {
            Operaciones.WriteLogsDebug("ProductoDal", "Actualizar", string.Format("{0} Info: {1}", DateTime.Now.ToLongDateString(), "Empezando a ejecutar el metodo acceso a datos para actualizar un Producto"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Producto SET nombreProducto=@nombreProducto, precioBase=@precioBase, variedad=@variedad, areaProducto=@areaProducto
                                    WHERE idProducto=@idProducto";

            try
            {
                command = OperacionesSql.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@idProducto", producto.IdProducto);
                command.Parameters.AddWithValue("@nombreProducto", producto.NombreProducto);
                command.Parameters.AddWithValue("@precioBase", producto.PrecioBase);
                command.Parameters.AddWithValue("@variedad", producto.Variedad);
                command.Parameters.AddWithValue("@areaProducto", producto.AreaProducto);
                OperacionesSql.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("ProductoDal", "Actualizar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("ProductoDal", "Actualizar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("ProductoDal", "Actualizar", string.Format("{0} {1} Info: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "Termino de ejecutar  el metodo acceso a datos para Actualizar un Producto"));

        }

        /// <summary>
        /// Eliminar un producto de la base de datos
        /// </summary>
        /// <param name="id"></param>
        public static void Eliminar(int id)
        {
            Operaciones.WriteLogsDebug("ProductoDal", "Eliminar", string.Format("{0} Info: {1}", DateTime.Now.ToLongDateString(), "Empezando a ejecutar el metodo acceso a datos para eliminar un Producto"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Producto SET estado=0
                                    WHERE idProducto = @idProducto";
            try
            {
                command = OperacionesSql.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@idProducto", id);
                OperacionesSql.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("ProductoDal", "Eliminar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("ProductoDal", "Eliminar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("ProductoDal", "Eliminar", string.Format("{0} {1} Info: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "Termino de ejecutar  el metodo acceso a datos para Eliminar un Producto"));
        }


        /// <summary>
        /// Obtener un Producto
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Producto Obtener(int id)
        {
            Producto producto = new Producto();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = @"SELECT * FROM Producto WHERE idProducto=@id";
            try
            {
                cmd = OperacionesSql.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@id", id);
                dr = OperacionesSql.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    producto.NombreProducto = dr.GetString(1);
                    producto.PrecioBase = dr.GetByte(2);
                    producto.Variedad = dr.GetString(3);
                    producto.AreaProducto = dr.GetByte(4);
                }
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("ProductoDal", "Obtenet(Get)", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return producto;
        }
    }
}
