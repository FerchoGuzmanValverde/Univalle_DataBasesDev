using System;
using System.Data.SqlClient;
using Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.Comun;
using Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.EmpleadosDal;

namespace Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.EmpleadosBrl
{
    /// <summary>
    /// Clase para manejar la lógica de negocio del usuario
    /// </summary>
    public class UsuarioBrl
    {
        /// <summary>
        /// método lógica de negocio para insertar un usuario
        /// </summary>
        /// <param name="usuario"></param>
        public static void Insertar(Usuario usuario)
        {
            Operaciones.WriteLogsDebug("UsuarioBrl", "Insertar", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(),
            "Empezando a ejecutar el método lógica de negocio para crear un usuario"));

            try
            {
                UsuarioDal.Insertar(usuario);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("UsuarioBrl", "Insertar", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("UsuarioBrl", "Insertar", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("UsuarioBrl", "Insertar", string.Format("{0} Info: {1}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "Termino de ejecutar  el método lógica de negocio para insertar usuario"));

        }

        /// <summary>
        /// método lógica de negocio para actulizar un usuario
        /// </summary>
        /// <param name="usuario"></param>
        public static void Actualizar(Usuario usuario)
        {
            Operaciones.WriteLogsDebug("UsuarioBrl", "Actualizar", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(),
            "Empezando a ejecutar el método lógica de negocio para crear un usuario"));

            try
            {
                EmpleadosDal.UsuarioDal.Actualizar(usuario);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("UsuarioBrl", "Actualizar", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("UsuarioBrl", "Actualizar", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("UsuarioBrl", "Actualizar", string.Format("{0} Info: {1}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "Termino de ejecutar  el método lógica de negocio para actualizar usuario"));
        }

        /// <summary>
        /// método lógica de negocio para eliminar un usuario
        /// </summary>
        /// <param name="usuario"></param>
        public static void Eliminar(Guid id)
        {
            Operaciones.WriteLogsDebug("UsuarioBrl", "Eliminar", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(),
            "Empezando a ejecutar el método lógica de negocio para Eliminar un usuario"));

            try
            {
                EmpleadosDal.UsuarioDal.Eliminar(id);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("UsuarioBrl", "Eliminar", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("UsuarioBrl", "Eliminar", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("UsuarioBrl", "Eliminar", string.Format("{0} Info: {1}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "Termino de ejecutar  el método lógica de negocio para Eliminar usuario"));
        }

        /// <summary>
        /// método lógica de negocio para eliminar un usuario
        /// </summary>
        /// <param name="usuario"></param>
        public static Usuario Obtener(Guid id)
        {
            Operaciones.WriteLogsDebug("UsuarioBrl", "Obtener", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(),
            "Empezando a ejecutar el método lógica de negocio para Obtener un usuario"));

            try
            {
                return EmpleadosDal.UsuarioDal.Obtener(id);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("UsuarioBrl", "Obtener", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("UsuarioBrl", "Obtener", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

        }

        /// <summary>
        /// Validar Pasword
        /// Validar Pasword
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <param name="contrsenia"></param>
        /// <returns></returns>
        public static bool ValidarContrsena(string nombreUsuario, string contrsenia)
        {
            Operaciones.WriteLogsDebug("UsuarioBrl", "Obtener", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(),
            "Empezando a ejecutar el método lógica de negocio para Obtener un usuario"));

            try
            {
                if (nombreUsuario.Equals("admin") && contrsenia.Equals("123"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("UsuarioBrl", "Obtener", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("UsuarioBrl", "Obtener", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

        }
    }
}
