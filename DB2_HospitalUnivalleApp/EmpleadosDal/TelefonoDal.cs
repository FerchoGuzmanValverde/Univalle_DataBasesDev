using System;
using System.Data.SqlClient;
using Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.Comun;

namespace Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.EmpleadosDal
{
    /// <summary>
    /// Clase TelefonoDal que sive para ejecutar consultas a la base de datos
    /// </summary>
    public class TelefonoDal
    {
        /// <summary>
        /// Inserta un telefono a la base de datos 
        /// </summary>
        /// <param name="telefono"></param>
        /// <param name="idPersona"></param>
        public static void Insertar(Telefono telefono)
        {
            Operaciones.WriteLogsDebug("TelefonoDal", "Insertar", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para crear un telefono"));

            SqlCommand command = null;

            //Consulta para insertar telefonos
            string queryString = @"INSERT INTO Telefonos(IdTelefono, Numero, IdTipoTelefono, IdPersona, Eliminado) 
                                    VALUES(@idTelefono, @numero, @tipo, @idPersona, @eliminado)";
            try
            {
                command = OperacionesSql.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@idTelefono", telefono.IdTelefono);
                command.Parameters.AddWithValue("@numero", telefono.Numero);
                command.Parameters.AddWithValue("@tipo", telefono.TipoTelefono.IdTipoTelefono);
                command.Parameters.AddWithValue("@idPersona", telefono.Persona.IdPersona);
                command.Parameters.AddWithValue("@eliminado", false);
                OperacionesSql.ExecuteBasicCommand(command);

            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("TelefonoDal", "Insertar", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("TelefonoDal", "Insertar", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("TelefonoDal", "Insertar", string.Format("{0} {1} Info: {1}", 
                DateTime.Now.ToString(), DateTime.Now.ToString(), 
                "Termino de ejecutar  el metodo acceso a datos para insertar telefono"));
        }

        public static void InsertarConTransaccion(Telefono telefono, SqlTransaction transaccion, SqlConnection conexion)
        {
            Operaciones.WriteLogsDebug("TelefonoDal", "Insertar", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para crear un telefono"));

            SqlCommand command = null;

            //Consulta para insertar telefonos
            string queryString = @"INSERT INTO Telefonos(IdTelefono, Numero, IdTipoTelefono, IdPersona, Eliminado) 
                                    VALUES(@idTelefono, @numero, @tipo, @idPersona, @eliminado)";
            try
            {
                command = OperacionesSql.CreateBasicCommandWithTransaction(queryString, transaccion, conexion);
                command.Parameters.AddWithValue("@idTelefono", telefono.IdTelefono);
                command.Parameters.AddWithValue("@numero", telefono.Numero);
                command.Parameters.AddWithValue("@tipo", telefono.TipoTelefono.IdTipoTelefono);
                command.Parameters.AddWithValue("@idPersona", telefono.Persona.IdPersona);
                command.Parameters.AddWithValue("@eliminado", false);
                OperacionesSql.ExecuteBasicCommandWithTransaction(command);

            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("TelefonoDal", "Insertar", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("TelefonoDal", "Insertar", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("TelefonoDal", "Insertar", string.Format("{0} {1} Info: {1}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "Termino de ejecutar  el metodo acceso a datos para insertar telefono"));
        }

        /// <summary>
        /// Elimina telefono de la base de datos
        /// </summary>
        /// <param name="id"></param>
        public static void Eliminar(Guid id)
        {
            Operaciones.WriteLogsDebug("TelefonoDal", "Eliminar", string.Format("{0} Info: {1}", DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para eliminar un Telefono"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Telefonos SET Eliminado=1
                                    WHERE IdTelefono = @idTelefono";
            try
            {
                command = OperacionesSql.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@idTelefono", id);
                OperacionesSql.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("TelefonoDal", "Eliminar", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("TelefonoDal", "Eliminar", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("TelefonoDal", "Eliminar", string.Format("{0} {1} Info: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), "Termino de ejecutar  el metodo acceso a datos para Eliminar un Cliente"));
        }

        /// <summary>
        /// Elimina los telefonos de una persona
        /// </summary>
        /// <param name="idPersona"></param>
        public static void EliminarPorIdPersonaConTransaccion(Guid idPersona, SqlTransaction transaccion, SqlConnection conexion)
        {
            Operaciones.WriteLogsDebug("TelefonoDal", "EliminarPorIdPersona", string.Format("{0} Info: {1}", DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para eliminar un Telefono"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Telefonos SET Eliminado=1
                                    WHERE IdPersona = @idPersona";
            try
            {
                command = OperacionesSql.CreateBasicCommandWithTransaction(queryString, transaccion, conexion);
                command.Parameters.AddWithValue("@idPersona", idPersona);
                OperacionesSql.ExecuteBasicCommandWithTransaction(command);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("TelefonoDal", "EliminarPorIdPersona", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("TelefonoDal", "EliminarPorIdPersona", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("TelefonoDal", "EliminarPorIdPersona", string.Format("{0} {1} Info: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), "Termino de ejecutar  el metodo acceso a datos para Eliminar un Cliente"));
        }

        /// <summary>
        /// Actualiza telefono de la base de datos
        /// </summary>
        /// <param name="telefono"></param>
        public static void Actualizar(Telefono telefono)
        {
            Operaciones.WriteLogsDebug("TelefonoDal", "Eliminar", string.Format("{0} Info: {1}", DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para eliminar un Telefono"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Telefonos SET Numero=@numero, IdTipoTelefono=@tipo
                                    WHERE IdTelefono=@idTelefono";
            try
            {

                command = OperacionesSql.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@numero", telefono.Numero);
                command.Parameters.AddWithValue("@tipo", telefono.TipoTelefono.IdTipoTelefono);
                command.Parameters.AddWithValue("@idTelefono", telefono.IdTelefono);
                OperacionesSql.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("TelefonoDal", "Eliminar", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("TelefonoDal", "Eliminar", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("TelefonoDal", "Eliminar", string.Format("{0} {1} Info: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), "Termino de ejecutar  el metodo acceso a datos para Eliminar un Cliente"));

        }

        /// <summary>
        /// Obtiene un Telefono de la base de datos
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Telefono Obtener(Guid id)
        {
            Telefono res = new Telefono();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = @"SELECT * FROM Telefonos WHERE IdTelefono=@id and Eliminado=0";
            try
            {
                cmd = OperacionesSql.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@id", id);
                dr = OperacionesSql.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    res = new Telefono()
                    {
                        IdTelefono = dr.GetGuid(0),
                        Numero = dr.GetInt32(1),
                        TipoTelefono = TipoTelefonoDal.Get(dr.GetByte(2)),
                        Persona = PersonaDal.Obtener(dr.GetGuid(3))
                    };
                }
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("TelefonoDal", "Obtenet", string.Format("{0} Error: {1}", DateTime.Now.ToString(),  ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("TelefonoDal", "Obtenet(Get)", string.Format("{0} Error: {1}", DateTime.Now.ToString(),  ex.Message));
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
