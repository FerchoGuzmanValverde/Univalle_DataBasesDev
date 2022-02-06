using Ferale.SistemaDeInformacionApp.SIFComun;
using System;
using System.Data.SqlClient;

namespace Ferale.SistemaDeInformacionApp.ClienteDal
{
    /// <summary>
    /// Clase Cliente Dal que sirve para interactuar con la base de datos
    /// </summary>
    public class ClienteDal
    {
        /// <summary>
        /// Inserta un Cliente a la base de datos 
        /// </summary>
        /// <param name="cliente"></param>
        public static void Insertar(Cliente cliente)
        {
            Operaciones.WriteLogsDebug("ClienteDal", "Insertar", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para crear un cliente"));

            SqlCommand command = null;

            //Consulta para insertar clientes
            string queryString = @"INSERT INTO Cliente(idCliente, razonSocial) 
                                    VALUES(@idCliente, @razonSocial)";
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

                //Iserto a la persona
                PersonaDal.InsertarConTransaccion(cliente as Persona, transaccion, conexion);

                //Inserto al empleado
                command = OperacionesSql.CreateBasicCommandWithTransaction(queryString, transaccion, conexion);
                command.Parameters.AddWithValue("@idCliente", OperacionesSql.GetActIdTable("Persona"));
                command.Parameters.AddWithValue("@razonSocial", cliente.RazonSocial);
                OperacionesSql.ExecuteBasicCommandWithTransaction(command);

                transaccion.Commit();

            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("ClienteDal", "Insertar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("ClienteDal", "Insertar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
            Operaciones.WriteLogsDebug("ClienteDal", "Insertar", string.Format("{0} {1} Info: {2}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "Termino de ejecutar  el metodo acceso a datos para insertar cliente"));
        }

        /// <summary>
        /// Actualiza Empleado de la base de datos
        /// </summary>
        /// <param name="Cliente"></param>
        public static void Actualizar(Cliente cliente)
        {
            Operaciones.WriteLogsDebug("ClienteDal", "Actualizar", string.Format("{0} Info: {1}", DateTime.Now.ToLongDateString(), "Empezando a ejecutar el metodo acceso a datos para actualizar un Cliente"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Cliente SET razonSocial=@razonSocial
                                    WHERE idCliente=@idCliente";

            try
            {

                //Iserto a la persona
                PersonaDal.Actualizar(cliente as Persona, cliente.IdCliente);

                command = OperacionesSql.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@idCliente", cliente.IdCliente);
                command.Parameters.AddWithValue("@razonSocial", cliente.RazonSocial);
                OperacionesSql.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("ClienteDal", "Actualizar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("ClienteDal", "Actualizar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("ClienteDal", "Actualizar", string.Format("{0} {1} Info: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "Termino de ejecutar  el metodo acceso a datos para Actualizar un Cliente"));

        }

        /// <summary>
        /// Eliminar un cliente de la base de datos
        /// </summary>
        /// <param name="id"></param>
        public static void Eliminar(int id)
        {
            Operaciones.WriteLogsDebug("ClienteDal", "Eliminar", string.Format("{0} Info: {1}", DateTime.Now.ToLongDateString(), "Empezando a ejecutar el metodo acceso a datos para eliminar un Cliente"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Persona SET estado=0
                                    WHERE idPersona = @idCliente";
            try
            {
                command = OperacionesSql.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@idCliente", id);
                OperacionesSql.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("ClienteDal", "Eliminar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("ClienteDal", "Eliminar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("ClienteDal", "Eliminar", string.Format("{0} {1} Info: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "Termino de ejecutar  el metodo acceso a datos para Eliminar un Cliente"));
        }


        /// <summary>
        /// Obtener un Cliente
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Cliente Obtener(int id)
        {
            Cliente cliente = new Cliente();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = @"SELECT * FROM Cliente WHERE idCliente=@id";
            try
            {
                cliente = PersonaDal.ObtenerCliente(id);
                cmd = OperacionesSql.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@id", id);
                dr = OperacionesSql.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    cliente.RazonSocial = dr.GetString(1);
                }
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("ClienteDal", "Obtenet(Get)", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return cliente;
        }
    }
}
