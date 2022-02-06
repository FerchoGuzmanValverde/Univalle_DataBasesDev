using System;
using System.Data.SqlClient;
using Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.Comun;

namespace Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.EmpleadosDal
{
    /// <summary>
    /// Clase que sirve para interactuar con la base de datos
    /// </summary>
    public class UsuarioDal
    {
        /// <summary>
        /// Inserta un Usuario a la base de datos 
        /// </summary>
        /// <param name="usuario"></param>
        public static void Insertar(Usuario usuario)
        {
            Operaciones.WriteLogsDebug("UsuarioDal", "Insertar", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para crear un usuario"));

            SqlCommand command = null;

            //Consulta para insertar usuarios
            string queryString = @"INSERT INTO Usuarios(IdUsuario, Nombre, Contrasenia, Eliminado) 
                                    VALUES(@idUsuario, @nombre, @contrasenia, @eliminado)";
            try
            {
                command = OperacionesSql.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@idUsuario", usuario.IdUsuario);
                command.Parameters.AddWithValue("@nombre", usuario.Nombre);
                command.Parameters.AddWithValue("@contrasenia", usuario.Contrasenia);
                command.Parameters.AddWithValue("@eliminado", false);
                OperacionesSql.ExecuteBasicCommand(command);

            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("UsuarioDal", "Insertar", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("UsuarioDal", "Insertar", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("UsuarioDal", "Insertar", string.Format("{0} {1} Info: {1}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "Termino de ejecutar  el metodo acceso a datos para insertar usuario"));
        }

        /// <summary>
        /// Inserta un usaurio a la base de datos con transaccion
        /// </summary>
        /// <param name="usuario">Objeto usuario </param>
        /// <param name="transaccion">Objeto transaccion</param>
        /// <param name="conexion">Objeto conexion</param>
        public static void InsertarTransaccion(Usuario usuario, SqlTransaction transaccion, SqlConnection conexion)
        {
            Operaciones.WriteLogsDebug("UsuarioDal", "InsertarTransaccion", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para crear un usuario"));

            SqlCommand command = null;

            //Consulta para insertar usuarios
            string queryString = @"INSERT INTO Usuarios(IdUsuario, Nombre, Contrasenia, Eliminado) 
                                    VALUES(@idUsuario, @nombre, @contrasenia, @eliminado)";
            try
            {
                command = OperacionesSql.CreateBasicCommandWithTransaction(queryString, transaccion, conexion);
                command.Parameters.AddWithValue("@idUsuario", usuario.IdUsuario);
                command.Parameters.AddWithValue("@nombre", usuario.Nombre);
                command.Parameters.AddWithValue("@contrasenia", usuario.Contrasenia);
                command.Parameters.AddWithValue("@eliminado", false);
                OperacionesSql.ExecuteBasicCommandWithTransaction(command);

            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("UsuarioDal", "InsertarTransaccion", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("UsuarioDal", "InsertarTransaccion", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("UsuarioDal", "InsertarTransaccion", string.Format("{0} {1} Info: {1}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "Termino de ejecutar  el metodo acceso a datos para insertar usuario"));
        }

        /// <summary>
        /// Elimina Usuario de la base de datos
        /// </summary>
        /// <param name="idUsuario"></param>
        public static void Eliminar(Guid idUsuario)
        {
            Operaciones.WriteLogsDebug("UsuarioDal", "Eliminar", string.Format("{0} Info: {1}", DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para eliminar un Usuario"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Usuarios SET Eliminado=1
                                    WHERE IdUsuario = @idUsuario";
            try
            {
                command = OperacionesSql.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@idUsuario", idUsuario);
                OperacionesSql.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("UsuarioDal", "Eliminar", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("UsuarioDal", "Eliminar", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("UsuarioDal", "Eliminar", string.Format("{0} {1} Info: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), "Termino de ejecutar  el metodo acceso a datos para Eliminar un Cliente"));
        }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="idPersona"></param>
        public static void EliminarPorIdPersonaConTransaccion(Guid idPersona, SqlTransaction transaccion,SqlConnection conexion)
        {
            Operaciones.WriteLogsDebug("UsuarioDal", "EliminarPorIdPersona", string.Format("{0} Info: {1}", DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para eliminar un Usuario"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Usuarios SET Eliminado=1
                                    WHERE IdUsuario = (Select IdUsuario FROM Personas WHERE IdPersona = @idPersona)";
            try
            {
                command = OperacionesSql.CreateBasicCommandWithTransaction(queryString, transaccion, conexion);
                command.Parameters.AddWithValue("@idPersona", idPersona);
                OperacionesSql.ExecuteBasicCommandWithTransaction(command);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("UsuarioDal", "EliminarPorIdPersona", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("UsuarioDal", "EliminarPorIdPersona", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("UsuarioDal", "EliminarPorIdPersona", string.Format("{0} {1} Info: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), "Termino de ejecutar  el metodo acceso a datos para Eliminar un Cliente"));
        }

        /// <summary>
        /// Actualiza Usuario de la base de datos
        /// </summary>
        /// <param name="Usuario"></param>
        public static void Actualizar(Usuario usuario)
        {
            Operaciones.WriteLogsDebug("UsuarioDal", "Actualizar", string.Format("{0} Info: {1}", DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para eliminar un Usuario"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Usuarios SET Nombre=@nombre, Contrasenia=@contrasenia
                                    WHERE IdUsuario=@idUsuario";
            try
            {

                command = OperacionesSql.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@nombre", usuario.Nombre);
                command.Parameters.AddWithValue("@contrasenia", usuario.Contrasenia);
                command.Parameters.AddWithValue("@idUsuario", usuario.IdUsuario);
                OperacionesSql.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("UsuarioDal", "Actualizar", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("UsuarioDal", "Actualizar", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("UsuarioDal", "Actualizar", string.Format("{0} {1} Info: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), "Termino de ejecutar  el metodo acceso a datos para Eliminar un Cliente"));

        }

        /// <summary>
        /// Obtiene un Usuario de la base de datos
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Usuario Obtener(Guid id)
        {
            Usuario res = new Usuario();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = @"SELECT * FROM Usuarios WHERE IdUsuario=@id and Eliminado=0";
            try
            {
                cmd = OperacionesSql.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@id", id);
                dr = OperacionesSql.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    res = new Usuario()
                    {
                        IdUsuario = dr.GetGuid(0),
                        Contrasenia = dr.GetString(2),
                        Nombre = dr.GetString(1),
                        Eliminado = dr.GetBoolean(3)
                    };
                }
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("UsuarioDal", "Obtenet(Get)", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
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
