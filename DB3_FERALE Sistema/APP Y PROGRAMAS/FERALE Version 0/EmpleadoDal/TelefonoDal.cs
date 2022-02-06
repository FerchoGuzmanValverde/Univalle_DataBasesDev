using Ferale.SistemaDeInformacionApp.SIFComun;
using System;
using System.Data.SqlClient;

namespace Ferale.SistemaDeInformacionApp.EmpleadoDal
{
    /// <summary>
    /// Clase para interactuar con la base de datos
    /// </summary>
    public class TelefonoDal
    {
        /// <summary>
        /// Inserta un telefono a la base de datos 
        /// </summary>
        /// <param name="telefono"></param>
        /// <param name="idPersona"></param>
        /// <param name="idProveedor"></param>
        public static void Insertar(Telefono telefono)
        {
            Operaciones.WriteLogsDebug("TelefonoDal", "Insertar", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para crear un telefono"));

            SqlCommand command = null;

            //Consulta para insertar telefonos
            string queryString = @"INSERT INTO Telefono(nroTelefono, idPersona) 
                                    VALUES(@numero, @idPersona)";
            try
            {
                command = OperacionesSql.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@numero", telefono.NroTelefono);
                command.Parameters.AddWithValue("@idPersona", telefono.Persona.IdPersona);
                OperacionesSql.ExecuteBasicCommand(command);

            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("TelefonoDal", "Insertar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("TelefonoDal", "Insertar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("TelefonoDal", "Insertar", string.Format("{0} {1} Info: {2}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "Termino de ejecutar  el metodo acceso a datos para insertar telefono"));
        }

        public static void InsertarConTransaccion(Telefono telefono, SqlTransaction transaccion, SqlConnection conexion)
        {
            Operaciones.WriteLogsDebug("TelefonoDal", "Insertar", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para crear un telefono"));

            SqlCommand command = null;

            //Consulta para insertar telefonos
            string queryString = @"INSERT INTO Telefono(nroTelefono, idPersona) 
                                    VALUES(@numero, @idPersona)";
            try
            {
                command = OperacionesSql.CreateBasicCommandWithTransaction(queryString, transaccion, conexion);
                command.Parameters.AddWithValue("@numero", telefono.NroTelefono);
                command.Parameters.AddWithValue("@idPersona", OperacionesSql.GetActIdTable("Persona"));
                OperacionesSql.ExecuteBasicCommandWithTransaction(command);

            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("TelefonoDal", "Insertar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("TelefonoDal", "Insertar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("TelefonoDal", "Insertar", string.Format("{0} {1} Info: {2}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "Termino de ejecutar  el metodo acceso a datos para insertar telefono"));
        }

        /// <summary>
        /// Elimina telefono de la base de datos
        /// </summary>
        /// <param name="id"></param>
        /*public static void Eliminar(int id)
        {
            Operaciones.WriteLogsDebug("TelefonoDal", "Eliminar", string.Format("{0} Info: {1}", DateTime.Now.ToLongDateString(), "Empezando a ejecutar el metodo acceso a datos para eliminar un Telefono"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Telefono SET estado=0
                                    WHERE idTelefono = @idTelefono";
            try
            {
                command = OperacionesSql.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@idTelefono", id);
                OperacionesSql.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("TelefonoDal", "Eliminar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("TelefonoDal", "Eliminar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("TelefonoDal", "Eliminar", string.Format("{0} {1} Info: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "Termino de ejecutar  el metodo acceso a datos para Eliminar un Cliente"));
        }
        */
        /// <summary>
        /// Actualiza telefono de la base de datos
        /// </summary>
        /// <param name="telefono"></param>
        public static void Actualizar(Telefono telefono)
        {
            Operaciones.WriteLogsDebug("TelefonoDal", "Actualizar", string.Format("{0} Info: {1}", DateTime.Now.ToLongDateString(), "Empezando a ejecutar el metodo acceso a datos para actualizar un Telefono"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Telefono SET nroTelefono=@numero
                                    WHERE idPersona=@idPersona";
            try
            {

                command = OperacionesSql.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@numero", telefono.NroTelefono);
                command.Parameters.AddWithValue("@idPersona", telefono.Persona.IdPersona);
                OperacionesSql.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("TelefonoDal", "Actualizar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("TelefonoDal", "Actualizar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("TelefonoDal", "Actualizar", string.Format("{0} {1} Info: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "Termino de ejecutar  el metodo acceso a datos para Actualizar un Telefono"));

        }

        /// <summary>
        /// Obtiene un Telefono de la base de datos
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Telefono Obtener(int id)
        {
            Telefono res = new Telefono();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = @"SELECT * FROM Telefono WHERE idTelefono=@id";
            try
            {
                cmd = OperacionesSql.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@id", id);
                dr = OperacionesSql.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    res = new Telefono()
                    {
                        IdTelefono = dr.GetInt32(0),
                        NroTelefono = dr.GetString(1),
                        Persona = PersonaDal.Obtener(dr.GetInt32(3))
                    };
                }
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("TelefonoDal", "Obtenet(Get)", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
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
