using Ferale.SistemaDeInformacionApp.SIFComun;
using System;
using System.Data.SqlClient;

namespace Ferale.SistemaDeInformacionApp.UsuariosDal
{
    /// <summary>
    /// Clase Usuarios Dal que sirve para interactuar con la base de datos
    /// </summary>
    public class UsuariosDal
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

            //Consulta para insertar productos
            string queryString = @"INSERT INTO Usuario(loginUsuario, passwordUsuario) 
                                    VALUES(@loginUsuario, @passwordUsuario)";
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

                //Inserto al usuario
                command = OperacionesSql.CreateBasicCommandWithTransaction(queryString, transaccion, conexion);
                command.Parameters.AddWithValue("@loginUsuario", usuario.LoginUsuario);
                command.Parameters.AddWithValue("@passwordUsuario", usuario.PasswordUsuario);
                OperacionesSql.ExecuteBasicCommandWithTransaction(command);

                transaccion.Commit();

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
            finally
            {
                conexion.Close();
            }
            Operaciones.WriteLogsDebug("UsuarioDal", "Insertar", string.Format("{0} {1} Info: {2}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "Termino de ejecutar  el metodo acceso a datos para insertar usuario"));
        }

        /// <summary>
        /// Actualiza Usuario de la base de datos
        /// </summary>
        /// <param name="Usuario"></param>
        public static void Actualizar(Usuario usuario)
        {
            Operaciones.WriteLogsDebug("UsuarioDal", "Actualizar", string.Format("{0} Info: {1}", DateTime.Now.ToLongDateString(), "Empezando a ejecutar el metodo acceso a datos para actualizar un Usuario"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Usuario SET loginUsuario=@loginUsuario, passwordUsuario=@passwordUsuario
                                    WHERE idUsuario=@idUsuario";

            try
            {
                command = OperacionesSql.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@idUsuario", usuario.IdUsuario);
                command.Parameters.AddWithValue("@loginUsuario", usuario.LoginUsuario);
                command.Parameters.AddWithValue("@passwordUsuario", usuario.PasswordUsuario);
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
        /// Eliminar un usuario de la base de datos
        /// </summary>
        /// <param name="id"></param>
        public static void Eliminar(int id)
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

            Operaciones.WriteLogsDebug("UsuarioDal", "Eliminar", string.Format("{0} {1} Info: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "Termino de ejecutar  el metodo acceso a datos para Eliminar un Usuario"));
        }


        /// <summary>
        /// Obtener un Usuario
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Usuario Obtener(int id)
        {
            Usuario usuario = new Usuario();
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
                    usuario.IdUsuario = dr.GetInt32(0);
                    usuario.LoginUsuario = dr.GetString(1);
                    usuario.PasswordUsuario = dr.GetString(2);
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
            return usuario;
        }
    }
}
