using Ferale.SistemaDeInformacionApp.SIFComun;
using System;
using System.Data.SqlClient;

namespace Ferale.SistemaDeInformacionApp.ClienteDal
{
    /// <summary>
    /// Clase que sirve para interactuar con la base de datos
    /// </summary>
    public class DomicilioDal
    {
        /// <summary>
        /// Inserta una domicilio a la base de datos 
        /// </summary>
        /// <param name="domicilio"></param>
        public static void Insertar(Domicilio domicilio)
        {
            Operaciones.WriteLogsDebug("DomicilioDal", "Insertar", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para crear una domicilio"));

            SqlCommand command = null;

            //Consulta para insertar domicilios
            string queryString = @"INSERT INTO Domicilio(descripcion, estado) 
                                    VALUES(@descripcion, @estado)";
            try
            {
                command = OperacionesSql.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@descripcion", domicilio.Descripcion);
                command.Parameters.AddWithValue("@estado", 1);
                OperacionesSql.ExecuteBasicCommand(command);

            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("DomicilioDal", "Insertar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("DomicilioDal", "Insertar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("DomicilioDal", "Insertar", string.Format("{0} {1} Info: {2}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "Termino de ejecutar  el metodo acceso a datos para insertar domicilio"));
        }

        /// <summary>
        /// Inserta un domicilio a la base de datos con transaccion
        /// </summary>
        /// <param name="domicilio">Objeto usuario </param>
        /// <param name="transaccion">Objeto transaccion</param>
        /// <param name="conexion">Objeto conexion</param>
        public static void InsertarTransaccion(Domicilio domicilio, SqlTransaction transaccion, SqlConnection conexion)
        {
            Operaciones.WriteLogsDebug("DomicilioDal", "InsertarTransaccion", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para crear una domicilio"));

            SqlCommand command = null;

            //Consulta para insertar domicilioes
            string queryString = @"INSERT INTO Domicilio(descripcion, estado) 
                                    VALUES(@descripcion, @estado)";
            try
            {
                command = OperacionesSql.CreateBasicCommandWithTransaction(queryString, transaccion, conexion);
                command.Parameters.AddWithValue("@descripcion", domicilio.Descripcion);
                command.Parameters.AddWithValue("@estado", 1);
                OperacionesSql.ExecuteBasicCommandWithTransaction(command);

            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("DomicilioDal", "InsertarTransaccion", string.Format("{0} {1} Error: {2}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("DomicilioDal", "InsertarTransaccion", string.Format("{0} {1} Error: {2}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("DomicilioDal", "InsertarTransaccion", string.Format("{0} {1} Info: {2}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "Termino de ejecutar  el metodo acceso a datos para insertar domicilio"));
        }

        /// <summary>
        /// Elimina Domicilio de la base de datos
        /// </summary>
        /// <param name="id"></param>
        public static void Eliminar(int id)
        {
            Operaciones.WriteLogsDebug("DomicilioDal", "Eliminar", string.Format("{0} Info: {1}", DateTime.Now.ToLongDateString(), "Empezando a ejecutar el metodo acceso a datos para eliminar un Domicilio"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Domicilio SET estado=0
                                    WHERE idDomicilio = @idDomicilio";
            try
            {
                command = OperacionesSql.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@idDomicilio", id);
                OperacionesSql.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("DomicilioDal", "Eliminar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("DomicilioDal", "Eliminar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("DomicilioDal", "Eliminar", string.Format("{0} {1} Info: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "Termino de ejecutar  el metodo acceso a datos para Eliminar un Domicilio"));
        }

        /// <summary>
        /// Actualiza Domicilio de la base de datos
        /// </summary>
        /// <param name="Domicilio"></param>
        public static void Actualizar(Domicilio domicilio)
        {
            Operaciones.WriteLogsDebug("DomicilioDal", "Actualizar", string.Format("{0} Info: {1}", DateTime.Now.ToLongDateString(), "Empezando a ejecutar el metodo acceso a datos para actualizar un Domicilio"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Domicilio SET descripcion=@descripcion
                                    WHERE idDomicilio=@idDomicilio";
            try
            {

                command = OperacionesSql.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@descripcion", domicilio.Descripcion);
                OperacionesSql.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("DomicilioDal", "Actualizar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("DomicilioDal", "Actualizar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("DomicilioDal", "Actualizar", string.Format("{0} {1} Info: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "Termino de ejecutar  el metodo acceso a datos para Actualizar un Domicilio"));

        }

        /// <summary>
        /// Obtiene un Domicilio de la base de datos
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Domicilio Obtener(int id)
        {
            Domicilio res = new Domicilio();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = @"SELECT * FROM Domicilio WHERE idDomicilio=@id and estado=1";
            try
            {
                cmd = OperacionesSql.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@id", id);
                dr = OperacionesSql.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    res = new Domicilio()
                    {
                        Descripcion = dr.GetString(1),
                        Estado = dr.GetByte(2)
                    };
                }
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("DomicilioDal", "Obtenet(Get)", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return res;
        }
    }
}
