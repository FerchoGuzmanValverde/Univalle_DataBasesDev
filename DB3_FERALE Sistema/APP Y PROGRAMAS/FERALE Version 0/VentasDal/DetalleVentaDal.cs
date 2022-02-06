using Ferale.SistemaDeInformacionApp.SIFComun;
using System;
using System.Data.SqlClient;

namespace Ferale.SistemaDeInformacionApp.VentasDal
{
    /// <summary>
    /// Clase para interactuar con la base de datos
    /// </summary>
    public class DetalleVentaDal
    {
        /// <summary>
        /// Inserta un detalle de venta a la base de datos 
        /// </summary>
        /// <param name="DetalleVenta"></param>
        public static void Insertar(DetalleVenta detalle)
        {
            Operaciones.WriteLogsDebug("DetalleVentaDal", "Insertar", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para insertar un detalle de venta"));

            SqlCommand command = null;

            //Consulta para insertar detalles
            string queryString = @"INSERT INTO DetalleVenta(idProducto, idVenta, cantidad, precioUnitario) 
                                    VALUES(@idProducto, @idVenta, @cantidad, @precioUnitario)";
            try
            {
                command = OperacionesSql.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@idProducto", detalle.Producto.IdProducto);
                command.Parameters.AddWithValue("@idVenta", detalle.Venta.IdVenta);
                command.Parameters.AddWithValue("@cantidad", detalle.cantidad);
                command.Parameters.AddWithValue("@precioUnitario", detalle.PrecioUnitario);
                OperacionesSql.ExecuteBasicCommand(command);

            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("DetalleVentaDal", "Insertar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("DetalleVentaDal", "Insertar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("DetalleVentaDal", "Insertar", string.Format("{0} {1} Info: {2}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "Termino de ejecutar  el metodo acceso a datos para insertar un detalle de venta"));
        }

        public static void InsertarConTransaccion(DetalleVenta detalle, SqlTransaction transaccion, SqlConnection conexion)
        {
            Operaciones.WriteLogsDebug("DetalleVentaDal", "Insertar", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para insertar un detalle de venta"));

            SqlCommand command = null;

            //Consulta para insertar detalles
            string queryString = @"INSERT INTO DetalleVenta(idProducto, idVenta, cantidad, precioUnitario) 
                                    VALUES(@idProducto, @idVenta, @cantidad, @precioUnitario)";
            try
            {
                command = OperacionesSql.CreateBasicCommandWithTransaction(queryString, transaccion, conexion);
                command.Parameters.AddWithValue("@idProducto", detalle.Producto.IdProducto);
                command.Parameters.AddWithValue("@idVenta", OperacionesSql.GetActIdTable("Venta"));
                command.Parameters.AddWithValue("@cantidad", detalle.cantidad);
                command.Parameters.AddWithValue("@precioUnitario", detalle.PrecioUnitario);
                OperacionesSql.ExecuteBasicCommandWithTransaction(command);

            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("DetalleVentaDal", "Insertar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("DetalleVentaDal", "Insertar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("DetalleVentaDal", "Insertar", string.Format("{0} {1} Info: {2}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "Termino de ejecutar  el metodo acceso a datos para insertar un detalle de venta"));
        }

        /// <summary>
        /// Actualiza detalle de venta de la base de datos
        /// </summary>
        /// <param name="detalle"></param>
        public static void Actualizar(DetalleVenta detalle)
        {
            Operaciones.WriteLogsDebug("DetalleVentaDal", "Actualizar", string.Format("{0} Info: {1}", DateTime.Now.ToLongDateString(), "Empezando a ejecutar el metodo acceso a datos para actualizar un detalle de venta"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE DetalleVenta SET idProducto=@idProducto, cantidad=@cantidad, precioUnitario=@precioUnitario
                                    WHERE idVenta=@idVenta";
            try
            {

                command = OperacionesSql.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@idProducto", detalle.Producto.IdProducto);
                command.Parameters.AddWithValue("@idVenta", OperacionesSql.GetActIdTable("Venta"));
                command.Parameters.AddWithValue("@cantidad", detalle.cantidad);
                command.Parameters.AddWithValue("@precioUnitario", detalle.PrecioUnitario);
                OperacionesSql.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("DetalleVentaDal", "Actualizar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("DetalleVentaDal", "Actualizar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("DetalleVentaDal", "Actualizar", string.Format("{0} {1} Info: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "Termino de ejecutar  el metodo acceso a datos para Actualizar un Detalle de venta"));

        }
    }
}
