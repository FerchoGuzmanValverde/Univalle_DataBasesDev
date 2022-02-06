using Ferale.SistemaDeInformacionApp.SIFComun;
using Ferale.SistemaDeInformacionApp.VentasDal;
using System;
using System.Data.SqlClient;

namespace Ferale.SistemaDeInformacionApp.VentasBrl
{
    /// <summary>
    /// Clase para manejar la logica de negocios de Venta
    /// </summary>
    public class VentaBrl
    {
        /// <summary>
        /// Metodo logica de negocio para insertar una Venta
        /// </summary>
        /// <param name="venta"></param>
        public static void Insertar(Venta venta)
        {
            Operaciones.WriteLogsDebug("VentaBrl", "Insertar", string.Format("{0} Info: {1}",
            DateTime.Now.ToLongDateString(),
            "Empezando a ejecutar el metodo logica de negocio para crear una venta"));

            try
            {
                VentaDal.Insertar(venta);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("VentaBrl", "Insertar", string.Format("{0} {1} Error: {2}",
                    DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("VentaBrl", "Insertar", string.Format("{0} {1} Error: {2}",
                    DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("VentaBrl", "Insertar", string.Format("{0} {1} Info: {2}",
                DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(),
                "Termino de ejecutar  el metodo logica de negocio para insertar venta"));

        }

        /// <summary>
        /// Metodo logica de negocio para actulizar una venta
        /// </summary>
        /// <param name="venta"></param>
        public static void Actualizar(Venta venta, int id)
        {
            Operaciones.WriteLogsDebug("VentaBrl", "Actualizar", string.Format("{0} Info: {1}",
            DateTime.Now.ToLongDateString(),
            "Empezando a ejecutar el metodo logica de negocio para actualizar una venta"));

            try
            {
                VentaDal.Actualizar(venta, id);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("VentaBrl", "Actualizar", string.Format("{0} {1} Error: {2}",
                    DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("VentaBrl", "Actualizar", string.Format("{0} {1} Error: {2}",
                    DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("VentaBrl", "Actualizar", string.Format("{0} {1} Info: {2}",
                DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(),
                "Termino de ejecutar  el metodo logica de negocio para actualizar venta"));
        }

        /// <summary>
        /// Metodo logica de negocio para eliminar una venta
        /// </summary>
        /// <param name="venta"></param>
        public static void Eliminar(int id)
        {
            Operaciones.WriteLogsDebug("VentaBrl", "Eliminar", string.Format("{0} Info: {1}",
            DateTime.Now.ToLongDateString(),
            "Empezando a ejecutar el metodo logica de negocio para Eliminar un cliente"));

            try
            {
                VentaDal.Eliminar(id);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("VentaBrl", "Eliminar", string.Format("{0} {1} Error: {2}",
                    DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("VentaBrl", "Eliminar", string.Format("{0} {1} Error: {2}",
                    DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("VentaBrl", "Eliminar", string.Format("{0} {1} Info: {2}",
                DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(),
                "Termino de ejecutar  el metodo logica de negocio para Eliminar venta"));
        }

        /// <summary>
        /// Metodo logica de negocio para obtener una venta
        /// </summary>
        /// <param name="venta"></param>
        public static Venta Obtener(int id)
        {
            Operaciones.WriteLogsDebug("VentaBrl", "Obtener", string.Format("{0} Info: {1}",
            DateTime.Now.ToLongDateString(),
            "Empezando a ejecutar el metodo logica de negocio para Obtener una venta"));

            try
            {
                return VentaDal.Obtener(id);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("VentaBrl", "Obtener", string.Format("{0} {1} Error: {2}",
                    DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("VentaBrl", "Obtener", string.Format("{0} {1} Error: {2}",
                    DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

        }
    }
}
