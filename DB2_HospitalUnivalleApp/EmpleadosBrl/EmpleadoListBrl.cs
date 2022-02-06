

using System;
using System.Data.SqlClient;
using Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.Comun;
using Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.EmpleadosDal;

namespace Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.EmpleadosBrl
{
    /// <summary>
    /// Clase para manejar la lógica de negocio de lista de empleados
    /// </summary>
    public class EmpleadoListBrl
    {
        /// <summary>
        /// Método lógica de negocio para insertar una lista de empleados
        /// </summary>
        /// <returns></returns>
        public static HospitalDataSet ObtenerListaEmpleadosReporte()
        {
            Operaciones.WriteLogsDebug("EmpleadoListBrl", "ObtenerListaEmpleadosReporte", string.Format("{0} Info: {1}",
          DateTime.Now.ToString(),
          "Empezando a ejecutar el método lógica de negocio para Obtener Lista Empleados Reporte"));
            HospitalDataSet empleadosDatSet = null;
            try
            {
                empleadosDatSet = EmpleadosDal.EmpleadoListDal.ObtenerListaEmpleadosReporte();
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("EmpleadoListBrl", "ObtenerListaEmpleadosReporte", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("EmpleadoListBrl", "ObtenerListaEmpleadosReporte", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("EmpleadoListBrl", "ObtenerListaEmpleadosReporte", string.Format("{0} Info: {1}",
                DateTime.Now.ToString(),
                "Termino de ejecutar  el método lógica de negocio para Obtener Lista Empleados Reporte"));

            return empleadosDatSet;
        }
    }
}
