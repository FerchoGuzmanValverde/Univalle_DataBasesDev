using Ferale.SistemaDeInformacionApp.SIFComun;
using System;
using System.Data.SqlClient;

namespace Ferale.SistemaDeInformacionApp.ProductosBrl
{
    /// <summary>
    /// Clase para manejar la logica de negocios de Productos
    /// </summary>
    public class ProductoBrl
    {
        /// <summary>
        /// Metodo logica de negocio para insertar un producto
        /// </summary>
        /// <param name="producto"></param>
        public static void Insertar(Producto producto)
        {
            Operaciones.WriteLogsDebug("ProductoBrl", "Insertar", string.Format("{0} Info: {1}",
            DateTime.Now.ToLongDateString(),
            "Empezando a ejecutar el metodo logica de negocio para crear un producto"));

            try
            {
                ProductosDal.ProductosDal.Insertar(producto);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("ProductoBrl", "Insertar", string.Format("{0} {1} Error: {2}",
                    DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("ProductoBrl", "Insertar", string.Format("{0} {1} Error: {2}",
                    DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("ProductoBrl", "Insertar", string.Format("{0} {1} Info: {2}",
                DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(),
                "Termino de ejecutar  el metodo logica de negocio para insertar producto"));

        }

        /// <summary>
        /// Metodo logica de negocio para actulizar un producto
        /// </summary>
        /// <param name="producto"></param>
        public static void Actualizar(Producto producto)
        {
            Operaciones.WriteLogsDebug("ProductoBrl", "Actualizar", string.Format("{0} Info: {1}",
            DateTime.Now.ToLongDateString(),
            "Empezando a ejecutar el metodo logica de negocio para actualizar un producto"));

            try
            {
                ProductosDal.ProductosDal.Actualizar(producto);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("ProductoBrl", "Actualizar", string.Format("{0} {1} Error: {2}",
                    DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("ProductoBrl", "Actualizar", string.Format("{0} {1} Error: {2}",
                    DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("ProductoBrl", "Actualizar", string.Format("{0} {1} Info: {2}",
                DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(),
                "Termino de ejecutar  el metodo logica de negocio para actualizar producto"));
        }

        /// <summary>
        /// Metodo logica de negocio para eliminar un producto
        /// </summary>
        /// <param name="producto"></param>
        public static void Eliminar(int id)
        {
            Operaciones.WriteLogsDebug("ProductoBrl", "Eliminar", string.Format("{0} Info: {1}",
            DateTime.Now.ToLongDateString(),
            "Empezando a ejecutar el metodo logica de negocio para Eliminar un producto"));

            try
            {
                ProductosDal.ProductosDal.Eliminar(id);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("ProductoBrl", "Eliminar", string.Format("{0} {1} Error: {2}",
                    DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("ProductoBrl", "Eliminar", string.Format("{0} {1} Error: {2}",
                    DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("ProductoBrl", "Eliminar", string.Format("{0} {1} Info: {2}",
                DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(),
                "Termino de ejecutar  el metodo logica de negocio para Eliminar producto"));
        }

        /// <summary>
        /// Metodo logica de negocio para obtener un producto
        /// </summary>
        /// <param name="producto"></param>
        public static Producto Obtener(int id)
        {
            Operaciones.WriteLogsDebug("ProductoBrl", "Obtener", string.Format("{0} Info: {1}",
            DateTime.Now.ToLongDateString(),
            "Empezando a ejecutar el metodo logica de negocio para Obtener un producto"));

            try
            {
                return ProductosDal.ProductosDal.Obtener(id);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("ProductoBrl", "Obtener", string.Format("{0} {1} Error: {2}",
                    DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("ProductoBrl", "Obtener", string.Format("{0} {1} Error: {2}",
                    DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

        }
    }
}
