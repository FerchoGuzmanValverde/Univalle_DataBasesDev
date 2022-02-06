using Ferale.SistemaDeInformacionApp.SIFComun;
using System;
using System.Data.SqlClient;

namespace Ferale.SistemaDeInformacionApp.ClienteBrl
{
    /// <summary>
    /// Clase para manejar la logica de negocios de Clientes
    /// </summary>
    public class ClienteBrl
    {
        /// <summary>
        /// Metodo logica de negocio para insertar un cliente
        /// </summary>
        /// <param name="cliente"></param>
        public static void Insertar(Cliente cliente)
        {
            Operaciones.WriteLogsDebug("ClienteBrl", "Insertar", string.Format("{0} Info: {1}",
            DateTime.Now.ToLongDateString(),
            "Empezando a ejecutar el metodo logica de negocio para crear un cliente"));

            try
            {
                ClienteDal.ClienteDal.Insertar(cliente);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("ClienteBrl", "Insertar", string.Format("{0} {1} Error: {2}",
                    DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("ClienteBrl", "Insertar", string.Format("{0} {1} Error: {2}",
                    DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("ClienteBrl", "Insertar", string.Format("{0} {1} Info: {2}",
                DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(),
                "Termino de ejecutar  el metodo logica de negocio para insertar clientes"));

        }

        /// <summary>
        /// Metodo logica de negocio para actulizar un empleado
        /// </summary>
        /// <param name="cliente"></param>
        public static void Actualizar(Cliente cliente)
        {
            Operaciones.WriteLogsDebug("ClienteBrl", "Actualizar", string.Format("{0} Info: {1}",
            DateTime.Now.ToLongDateString(),
            "Empezando a ejecutar el metodo logica de negocio para actualizar un cliente"));

            try
            {
                ClienteDal.ClienteDal.Actualizar(cliente);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("ClienteBrl", "Actualizar", string.Format("{0} {1} Error: {2}",
                    DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("ClienteBrl", "Actualizar", string.Format("{0} {1} Error: {2}",
                    DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("ClienteBrl", "Actualizar", string.Format("{0} {1} Info: {2}",
                DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(),
                "Termino de ejecutar  el metodo logica de negocio para actualizar cliente"));
        }

        /// <summary>
        /// Metodo logica de negocio para eliminar un empleado
        /// </summary>
        /// <param name="cliente"></param>
        public static void Eliminar(int id)
        {
            Operaciones.WriteLogsDebug("ClienteBrl", "Eliminar", string.Format("{0} Info: {1}",
            DateTime.Now.ToLongDateString(),
            "Empezando a ejecutar el metodo logica de negocio para Eliminar un cliente"));

            try
            {
                ClienteDal.ClienteDal.Eliminar(id);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("ClienteBrl", "Eliminar", string.Format("{0} {1} Error: {2}",
                    DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("ClienteBrl", "Eliminar", string.Format("{0} {1} Error: {2}",
                    DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("ClienteBrl", "Eliminar", string.Format("{0} {1} Info: {2}",
                DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(),
                "Termino de ejecutar  el metodo logica de negocio para Eliminar cliente"));
        }

        /// <summary>
        /// Metodo logica de negocio para eliminar un empleado
        /// </summary>
        /// <param name="cliente"></param>
        public static Cliente Obtener(int id)
        {
            Operaciones.WriteLogsDebug("ClienteBrl", "Obtener", string.Format("{0} Info: {1}",
            DateTime.Now.ToLongDateString(),
            "Empezando a ejecutar el metodo logica de negocio para Obtener un cliente"));

            try
            {
                return ClienteDal.ClienteDal.Obtener(id);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("ClienteBrl", "Obtener", string.Format("{0} {1} Error: {2}",
                    DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("ClienteBrl", "Obtener", string.Format("{0} {1} Error: {2}",
                    DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

        }
    }
}
