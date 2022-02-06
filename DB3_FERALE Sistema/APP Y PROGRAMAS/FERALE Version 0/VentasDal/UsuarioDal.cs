using Ferale.SistemaDeInformacionApp.SIFComun;
using System;
using System.Data.SqlClient;

namespace Ferale.SistemaDeInformacionApp.ClienteDal
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
            string queryString = @"INSERT INTO Usuario(loginUsuario, passwordUsuario) 
                                    VALUES(@nombre, @contrasenia)";
            try
            {
                command = OperacionesSql.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@nombre", usuario.LoginUsuario);
                command.Parameters.AddWithValue("@contrasenia", usuario.PasswordUsuario);
                OperacionesSql.ExecuteBasicCommand(command);

            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("UsuarioDal", "Insertar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("UsuarioDal", "Insertar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("UsuarioDal", "Insertar", string.Format("{0} {1} Info: {2}",
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
            string queryString = @"INSERT INTO Usuario(loginUsuario, passwordUsuario)
                                    VALUES(@nombre, @contrasenia)";
            try
            {
                command = OperacionesSql.CreateBasicCommandWithTransaction(queryString, transaccion, conexion);
                command.Parameters.AddWithValue("@nombre", usuario.LoginUsuario);
                command.Parameters.AddWithValue("@contrasenia", usuario.PasswordUsuario);
                OperacionesSql.ExecuteBasicCommandWithTransaction(command);

            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("UsuarioDal", "InsertarTransaccion", string.Format("{0} {1} Error: {2}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("UsuarioDal", "InsertarTransaccion", string.Format("{0} {1} Error: {2}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("UsuarioDal", "InsertarTransaccion", string.Format("{0} {1} Info: {2}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "Termino de ejecutar  el metodo acceso a datos para insertar usuario"));
        }

        /// <summary>
        /// Elimina Usuario de la base de datos
        /// </summary>
        /// <param name="id"></param>
        /*public static void Eliminar(int id)
        {
            Operaciones.WriteLogsDebug("UsuarioDal", "Eliminar", string.Format("{0} Info: {1}", DateTime.Now.ToLongDateString(), "Empezando a ejecutar el metodo acceso a datos para eliminar un Usuario"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Usuario SET estado=0
                                    WHERE idUsuario = @idUsuario";
            try
            {
                command = OperacionesSql.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@idUsuario", id);
                OperacionesSql.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("UsuarioDal", "Eliminar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("UsuarioDal", "Eliminar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("UsuarioDal", "Eliminar", string.Format("{0} {1} Info: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "Termino de ejecutar  el metodo acceso a datos para Eliminar un Cliente"));
        }*/

        /// <summary>
        /// Actualiza Usuario de la base de datos
        /// </summary>
        /// <param name="Usuario"></param>
        public static void Actualizar(Usuario usuario)
        {
            Operaciones.WriteLogsDebug("UsuarioDal", "Actualizar", string.Format("{0} Info: {1}", DateTime.Now.ToLongDateString(), "Empezando a ejecutar el metodo acceso a datos para actualizar un Usuario"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Usuario SET loginUsuario=@nombre, passwordUsuario=@contrasenia
                                    WHERE idUsuario=@idUsuario";
            try
            {

                command = OperacionesSql.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@nombre", usuario.LoginUsuario);
                command.Parameters.AddWithValue("@contrasenia", usuario.PasswordUsuario);
                command.Parameters.AddWithValue("@idUsuario", usuario.IdUsuario);
                OperacionesSql.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("UsuarioDal", "Actualizar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("UsuarioDal", "Actualizar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("UsuarioDal", "Actualizar", string.Format("{0} {1} Info: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "Termino de ejecutar  el metodo acceso a datos para Actualizar un Usuario"));

        }

        /// <summary>
        /// Obtiene un Usuario de la base de datos
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Usuario Obtener(int id)
        {
            Usuario res = new Usuario();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = @"SELECT * FROM Usuario WHERE idUsuario=@id";
            try
            {
                cmd = OperacionesSql.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@id", id);
                dr = OperacionesSql.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    res = new Usuario()
                    {
                        IdUsuario = dr.GetInt32(0),
                        LoginUsuario = dr.GetString(1),
                        PasswordUsuario = dr.GetString(2)
                    };
                }
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("UsuarioDal", "Obtenet(Get)", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
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
