using Ferale.SistemaDeInformacionApp.SIFComun;
using System;
using System.Data.SqlClient;

namespace Ferale.SistemaDeInformacionApp.UsuarioBrl
{
    /// <summary>
    /// Clase para manejar la logica de negocios de Usuarios
    /// </summary>
    public class UsuariosBrl
    {
        /// <summary>
        /// Metodo logica de negocio para insertar un usuario
        /// </summary>
        /// <param name="usuario"></param>
        public static void Insertar(Usuario usuario)
        {
            Operaciones.WriteLogsDebug("UsuarioBrl", "Insertar", string.Format("{0} Info: {1}",
            DateTime.Now.ToLongDateString(),
            "Empezando a ejecutar el metodo logica de negocio para crear un usuario"));

            try
            {
                UsuariosDal.UsuariosDal.Insertar(usuario);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("UsuarioBrl", "Insertar", string.Format("{0} {1} Error: {2}",
                    DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("UsuarioBrl", "Insertar", string.Format("{0} {1} Error: {2}",
                    DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("UsuarioBrl", "Insertar", string.Format("{0} {1} Info: {2}",
                DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(),
                "Termino de ejecutar  el metodo logica de negocio para insertar usuario"));

        }

        /// <summary>
        /// Metodo logica de negocio para actulizar un usuario
        /// </summary>
        /// <param name="usuario"></param>
        public static void Actualizar(Usuario usuario)
        {
            Operaciones.WriteLogsDebug("UsuariosBrl", "Actualizar", string.Format("{0} Info: {1}",
            DateTime.Now.ToLongDateString(),
            "Empezando a ejecutar el metodo logica de negocio para actualizar un usuario"));

            try
            {
                UsuariosDal.UsuariosDal.Actualizar(usuario);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("UsuariosBrl", "Actualizar", string.Format("{0} {1} Error: {2}",
                    DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("UsuariosBrl", "Actualizar", string.Format("{0} {1} Error: {2}",
                    DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("UsuariosBrl", "Actualizar", string.Format("{0} {1} Info: {2}",
                DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(),
                "Termino de ejecutar  el metodo logica de negocio para actualizar usuario"));
        }

        /// <summary>
        /// Metodo logica de negocio para eliminar un usuario
        /// </summary>
        /// <param name="usuario"></param>
        public static void Eliminar(int id)
        {
            Operaciones.WriteLogsDebug("UsuarioBrl", "Eliminar", string.Format("{0} Info: {1}",
            DateTime.Now.ToLongDateString(),
            "Empezando a ejecutar el metodo logica de negocio para Eliminar un usuario"));

            try
            {
                UsuariosDal.UsuariosDal.Eliminar(id);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("UsuarioBrl", "Eliminar", string.Format("{0} {1} Error: {2}",
                    DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("UsuarioBrl", "Eliminar", string.Format("{0} {1} Error: {2}",
                    DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("UsuarioBrl", "Eliminar", string.Format("{0} {1} Info: {2}",
                DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(),
                "Termino de ejecutar  el metodo logica de negocio para Eliminar usuario"));
        }

        /// <summary>
        /// Metodo logica de negocio para obtener un usuario
        /// </summary>
        /// <param name="usuario"></param>
        public static Usuario Obtener(int id)
        {
            Operaciones.WriteLogsDebug("UsuarioBrl", "Obtener", string.Format("{0} Info: {1}",
            DateTime.Now.ToLongDateString(),
            "Empezando a ejecutar el metodo logica de negocio para Obtener un usuario"));

            try
            {
                return UsuariosDal.UsuariosDal.Obtener(id);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("UsuarioBrl", "Obtener", string.Format("{0} {1} Error: {2}",
                    DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("UsuarioBrl", "Obtener", string.Format("{0} {1} Error: {2}",
                    DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

        }
    }
}
