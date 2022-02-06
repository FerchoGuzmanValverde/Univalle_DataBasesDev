using Ferale.SistemaDeInformacionApp.SIFComun;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferale.SistemaDeInformacionApp.VentasDal
{
    /// <summary>
    /// Clase para interactuar con la base de datos
    /// </summary>
    public class VentaDal
    {
        /// <summary>
        /// Inserta una Venta a la base de datos
        /// </summary>
        /// <param name="venta"></param>
        public static void Insertar(Venta venta)
        {
            Operaciones.WriteLogsDebug("VentaDal", "Insertar", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para insertar una venta"));

            SqlCommand command = null;

            //Consulta para insertar ventas
            string queryString = @"INSERT INTO Venta(fechaHoraVenta, montoTotalFinal, descuento, tipoVenta, idCliente, idEmpleado) 
                                    VALUES(@fechaHoraVenta, @montoTotalFinal, @descuento, @tipoVenta, @idCliente, @idEmpleado)";
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

                command = OperacionesSql.CreateBasicCommandWithTransaction(queryString, transaccion, conexion);
                command.Parameters.AddWithValue("@fechaHoraVenta", venta.FechaHoraVenta);
                command.Parameters.AddWithValue("@montoTotalFinal", venta.MontoTotalFinal);
                command.Parameters.AddWithValue("@descuento", venta.Descuento);
                command.Parameters.AddWithValue("@tipoVenta", venta.TipoVenta);
                command.Parameters.AddWithValue("@idCliente", venta.Cliente.IdCliente);
                command.Parameters.AddWithValue("@idEmpleado", venta.Empleado.IdEmpleado);
                OperacionesSql.ExecuteBasicCommandWithTransaction(command);

                //Insertar detalles de productos
                foreach (DetalleVenta pro in venta.Detalles)
                {
                    DetalleVentaDal.InsertarConTransaccion(pro, transaccion, conexion);
                }
                transaccion.Commit();

            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("VentaDal", "Insertar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("VentaDal", "Insertar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
            Operaciones.WriteLogsDebug("VentaDal", "Insertar", string.Format("{0} {1} Info: {2}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "Termino de ejecutar  el metodo acceso a datos para insertar una venta"));
        }

        /// <summary>
        /// Eliminado Logico de Venta de la base de datos
        /// </summary>
        /// <param name="id"></param>
        public static void Eliminar(int id)
        {
            Operaciones.WriteLogsDebug("VentaDal", "Eliminar", string.Format("{0} Info: {1}", DateTime.Now.ToLongDateString(), "Empezando a ejecutar el metodo acceso a datos para eliminar una Venta"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Venta SET estado=0
                                    WHERE idVenta = @idVenta";
            try
            {
                command = OperacionesSql.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@idVenta", id);
                OperacionesSql.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("VentaDal", "Eliminar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("VentaDal", "Eliminar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("VentaDal", "Eliminar", string.Format("{0} {1} Info: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "Termino de ejecutar  el metodo acceso a datos para Eliminar una Venta"));
        }

        /// <summary>
        /// Actualiza Venta de la base de datos
        /// </summary>
        /// <param name="Persona"></param>
        public static void Actualizar(Venta venta, int id)
        {
            Operaciones.WriteLogsDebug("VentaDal", "Actualizar", string.Format("{0} Info: {1}", DateTime.Now.ToLongDateString(), "Empezando a ejecutar el metodo acceso a datos para Actualizar una Venta"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Venta SET montoTotalFinal=@montoTotal, descuento=@descuento, tipoVenta=@tipoVenta,
                                    idCliente=@idCliente, idEmpleado=@idEmpleado
                                    WHERE idVenta=@idVenta";
            try
            {
                command = OperacionesSql.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@idVenta", id);
                command.Parameters.AddWithValue("@montoTotal", venta.MontoTotalFinal);
                command.Parameters.AddWithValue("@descuento", venta.Descuento);
                command.Parameters.AddWithValue("@tipoVenta", venta.TipoVenta);
                command.Parameters.AddWithValue("@idCliente", venta.Cliente.IdCliente);
                command.Parameters.AddWithValue("@idEmpleado", venta.Empleado.IdEmpleado);

                //Actualizar detalles de productos
                foreach (DetalleVenta pro in venta.Detalles)
                {
                    DetalleVentaDal.Actualizar(pro);
                }

                OperacionesSql.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("VentaDal", "Actualizar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("VentaDal", "Actualizar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("VentaDal", "Actualizar", string.Format("{0} {1} Info: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "Termino de ejecutar  el metodo acceso a datos para Actualizar una Venta"));

        }

        /// <summary>
        /// Obtiene una Venta de la base de datos
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public static Venta Obtener(int id)
        {
            Venta venta = new Venta();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = @"SELECT * FROM Venta WHERE idVenta=@id AND estado=1";
            try
            {
                cmd = OperacionesSql.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@id", id);
                dr = OperacionesSql.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    venta = new Venta()
                    {
                        FechaHoraVenta = dr.GetDateTime(1),
                        MontoTotalFinal = dr.GetInt32(2),
                        Descuento = dr.GetByte(3),
                        TipoVenta = dr.GetByte(4),
                        Cliente = ClienteDal.ClienteDal.Obtener(dr.GetInt32(6)),
                        Empleado = EmpleadoDal.EmpleadoDal.Obtener(dr.GetInt32(7))
                    };

                    venta.Detalles = DetalleVentaListDal.Obtener(venta.IdVenta);
                }
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("VentaDal", "Obtenet(Get)", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return venta;
        }

        /// <summary>
        /// Obtiene una Venta de la base de datos
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Venta ObtenerVenta(int id)
        {
            Venta venta = new Venta();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = @"SELECT * FROM Venta WHERE idVenta=@id and estado=1";
            try
            {
                cmd = OperacionesSql.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@id", id);
                dr = OperacionesSql.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    venta = new Venta()
                    {
                        IdVenta = dr.GetInt32(0),
                        FechaHoraVenta = dr.GetDateTime(1),
                        MontoTotalFinal = dr.GetInt32(2),
                        Descuento = dr.GetByte(3),
                        TipoVenta = dr.GetByte(4),
                        Cliente = ClienteDal.ClienteDal.Obtener(dr.GetInt32(7)),
                        Empleado = EmpleadoDal.EmpleadoDal.Obtener(dr.GetInt32(8))
                    };

                    venta.Detalles = DetalleVentaListDal.Obtener(venta.IdVenta);

                }
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("VentaDal", "Obtenet(Get)", string.Format("{0} Error: {1}", DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return venta;
        }
    }
}
