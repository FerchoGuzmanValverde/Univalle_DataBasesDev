
using System;
using System.Data.SqlClient;
using Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.Comun;

namespace Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.EmpleadosBrl
{
    /// <summary>
    /// Clase para manejar la lógica de negocio de la empleado
    /// </summary>
    public class EmpleadoBrl
    {
        /// <summary>
        /// Método lógica de negocio para insertar un empleado
        /// </summary>
        /// <param name="empleado"></param>
        public static void Insertar(Empleado empleado)
        {
            Operaciones.WriteLogsDebug("EmpleadoBrl", "Insertar", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(),
            "Empezando a ejecutar el método lógica de negocio para crear un empleado"));

            try
            {
                EmpleadosDal.EmpleadoDal.Insertar(empleado);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("EmpleadoBrl", "Insertar", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("EmpleadoBrl", "Insertar", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("EmpleadoBrl", "Insertar", string.Format("{0} Info: {1}",
                DateTime.Now.ToString(),
                "Termino de ejecutar  el método lógica de negocio para insertar empleado"));

        }

        /// <summary>
        /// Método para obtener  un empleado
        /// </summary>
        /// <param name="id">Identificado del empleado </param>
        /// <returns>Empleado</returns>
        public static Empleado Obtener(Guid id)
        {
            Operaciones.WriteLogsDebug("EmpleadoBrl", "Insertar", string.Format("{0} Info: {1}",
          DateTime.Now.ToString(),
          "Empezando a ejecutar el método lógica de negocio para obtener un empleado"));
            Empleado empleado = null;
            try
            {
                empleado = EmpleadosDal.EmpleadoDal.Obtener(id);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("EmpleadoBrl", "obtener", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("EmpleadoBrl", "obtener", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("EmpleadoBrl", "obtener", string.Format("{0} Info: {1}",
                DateTime.Now.ToString(),
                "Termino de ejecutar  el método lógica de negocio para obtener empleado"));

            return empleado;
        }


        /// <summary>
        /// Método lógica de negocio para crear un empleado en la lógica de negocio
        /// </summary>
        /// <param name="empleado"></param>
        public static void Actualizar(Empleado empleado)
        {
            Operaciones.WriteLogsDebug("EmpleadoBrl", "Actualizar", string.Format("{0} Info: {1}",
                DateTime.Now.ToString(),
                "Empezando a ejecutar el método lógica de negocio para Actualizar un empleado"));

            try
            {
                EmpleadosDal.EmpleadoDal.Actualizar(empleado);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("EmpleadoBrl", "Actualizar", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("EmpleadoBrl", "Actualizar", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("EmpleadoBrl", "Actualizar", string.Format("{0} Info: {1}",
                DateTime.Now.ToString(),
                "Termino de ejecutar  el método lógica de negocio para Actualizar empleado"));
        }

        public static void Eliminar(Guid idEmpleado)
        {
            Operaciones.WriteLogsDebug("EmpleadoBrl", "Eliminar", string.Format("{0} Info: {1}",
               DateTime.Now.ToString(),
               "Empezando a ejecutar el método lógica de negocio para Eliminar un empleado"));

            try
            {
                EmpleadosDal.EmpleadoDal.Eliminar(idEmpleado);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("EmpleadoBrl", "Eliminar", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("EmpleadoBrl", "Eliminar", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("EmpleadoBrl", "Eliminar", string.Format("{0} Info: {1}",
                DateTime.Now.ToString(),
                "Termino de ejecutar  el método lógica de negocio para Actualizar empleado"));

        }
    }
}
