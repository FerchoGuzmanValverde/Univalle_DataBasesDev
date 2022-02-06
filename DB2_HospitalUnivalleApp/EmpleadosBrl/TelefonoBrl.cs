using System;
using System.Data.SqlClient;
using Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.Comun;

namespace Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.EmpleadosBrl
{
    /// <summary>
    /// Clase para manejar la lógica de negocio del telefono
    /// </summary>
    public class TelefonoBrl
    {
        /// <summary>
        /// método lógica de negocio para insertar un telefono
        /// </summary>
        /// <param name="telefono"></param>
        public static void Insertar(Telefono telefono)
        {
             Operaciones.WriteLogsDebug("TelefonoBrl", "Insertar", string.Format("{0} Info: {1}",
             DateTime.Now.ToString(), 
             "Empezando a ejecutar el método lógica de negocio para crear un telefono"));

            try
            {
                EmpleadosDal.TelefonoDal.Insertar(telefono);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("TelefonoBrl", "Insertar", string.Format("{0} Error: {1}", 
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("TelefonoBrl", "Insertar", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("TelefonoBrl", "Insertar", string.Format("{0} Info: {1}", 
                DateTime.Now.ToString(), DateTime.Now.ToString(), 
                "Termino de ejecutar  el método lógica de negocio para insertar telefono"));

        }

        /// <summary>
        /// método lógica de negocio para actulizar un telefono
        /// </summary>
        /// <param name="telefono"></param>
        public static void Actualizar(Telefono telefono)
        {
            Operaciones.WriteLogsDebug("TelefonoBrl", "Actualizar", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(), 
            "Empezando a ejecutar el método lógica de negocio para crear un telefono"));

            try
            {
                EmpleadosDal.TelefonoDal.Actualizar(telefono);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("TelefonoBrl", "Actualizar", string.Format("{0} Error: {1}", 
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("TelefonoBrl", "Actualizar", string.Format("{0} Error: {1}", 
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("TelefonoBrl", "Actualizar", string.Format("{0} Info: {1}", 
                DateTime.Now.ToString(), DateTime.Now.ToString(), 
                "Termino de ejecutar  el método lógica de negocio para actualizar telefono"));
        }

        /// <summary>
        /// método lógica de negocio para eliminar un telefono
        /// </summary>
        /// <param name="telefono"></param>
        public static void Eliminar(Guid idTelefono)
        {
            Operaciones.WriteLogsDebug("TelefonoBrl", "Eliminar", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(), 
            "Empezando a ejecutar el método lógica de negocio para Eliminar un telefono"));

            try
            {
                EmpleadosDal.TelefonoDal.Eliminar(idTelefono);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("TelefonoBrl", "Eliminar", string.Format("{0} Error: {1}", 
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("TelefonoBrl", "Eliminar", string.Format("{0} Error: {1}", 
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("TelefonoBrl", "Eliminar", string.Format("{0} Info: {1}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "Termino de ejecutar  el método lógica de negocio para Eliminar telefono"));
        }

        /// <summary>
        /// método lógica de negocio para eliminar un telefono
        /// </summary>
        /// <param name="telefono"></param>
        public static Telefono Obtener(Guid id)
        {
            Operaciones.WriteLogsDebug("TelefonoBrl", "Obtener", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(),
            "Empezando a ejecutar el método lógica de negocio para Obtener un telefono"));

            try
            {
                return EmpleadosDal.TelefonoDal.Obtener(id);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("TelefonoBrl", "Obtener", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("TelefonoBrl", "Obtener", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

         }
    }
}
