using Ferale.SistemaDeInformacionApp.SIFComun;
using System;
using System.Data.SqlClient;

namespace Ferale.SistemaDeInformacionApp.EmpleadoBrl
{
    /// <summary>
    /// Clase para manejar la logica de negocios de Empleados
    /// </summary>
    public class EmpleadoBrl
    {
        /// <summary>
        /// Metodo logica de negocio para insertar un empleado
        /// </summary>
        /// <param name="empleado"></param>
        public static void Insertar(Empleado empleado)
        {
            Operaciones.WriteLogsDebug("EmpleadoBrl", "Insertar", string.Format("{0} Info: {1}",
            DateTime.Now.ToLongDateString(),
            "Empezando a ejecutar el metodo logica de negocio para crear un empleado"));

            try
            {
                EmpleadoDal.EmpleadoDal.Insertar(empleado);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("EmpleadoBrl", "Insertar", string.Format("{0} {1} Error: {2}",
                    DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("EmpleadoBrl", "Insertar", string.Format("{0} {1} Error: {2}",
                    DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("EmpleadoBrl", "Insertar", string.Format("{0} {1} Info: {2}",
                DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(),
                "Termino de ejecutar  el metodo logica de negocio para insertar empleados"));

        }

        /// <summary>
        /// Metodo logica de negocio para actulizar un empleado
        /// </summary>
        /// <param name="empleado"></param>
        public static void Actualizar(Empleado empleado)
        {
            Operaciones.WriteLogsDebug("EmpleadoBrl", "Actualizar", string.Format("{0} Info: {1}",
            DateTime.Now.ToLongDateString(),
            "Empezando a ejecutar el metodo logica de negocio para actualizar un empleado"));

            try
            {
                EmpleadoDal.EmpleadoDal.Actualizar(empleado);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("EmpleadoBrl", "Actualizar", string.Format("{0} {1} Error: {2}",
                    DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("EmpleadoBrl", "Actualizar", string.Format("{0} {1} Error: {2}",
                    DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("EmpleadoBrl", "Actualizar", string.Format("{0} {1} Info: {2}",
                DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(),
                "Termino de ejecutar  el metodo logica de negocio para actualizar empleado"));
        }

        /// <summary>
        /// Metodo logica de negocio para eliminar un empleado
        /// </summary>
        /// <param name="empleado"></param>
        public static void Eliminar(int id)
        {
            Operaciones.WriteLogsDebug("EmpleadoBrl", "Eliminar", string.Format("{0} Info: {1}",
            DateTime.Now.ToLongDateString(),
            "Empezando a ejecutar el metodo logica de negocio para Eliminar un empleado"));

            try
            {
                EmpleadoDal.EmpleadoDal.Eliminar(id);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("EmpleadoBrl", "Eliminar", string.Format("{0} {1} Error: {2}",
                    DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("EmpleadoBrl", "Eliminar", string.Format("{0} {1} Error: {2}",
                    DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("EmpleadoBrl", "Eliminar", string.Format("{0} {1} Info: {2}",
                DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(),
                "Termino de ejecutar  el metodo logica de negocio para Eliminar empleado"));
        }

        /// <summary>
        /// Metodo logica de negocio para eliminar un empleado
        /// </summary>
        /// <param name="empleado"></param>
        public static Empleado Obtener(int id)
        {
            Operaciones.WriteLogsDebug("EmpleadoBrl", "Obtener", string.Format("{0} Info: {1}",
            DateTime.Now.ToLongDateString(),
            "Empezando a ejecutar el metodo logica de negocio para Obtener un empleado"));

            try
            {
                return EmpleadoDal.EmpleadoDal.Obtener(id);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("EmpleadoBrl", "Obtener", string.Format("{0} {1} Error: {2}",
                    DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("EmpleadoBrl", "Obtener", string.Format("{0} {1} Error: {2}",
                    DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

        }
    }
}
