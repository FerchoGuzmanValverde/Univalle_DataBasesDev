using System;
using System.Data.SqlClient;
using Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.Comun;
using Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.EmpleadosDal.HospitalDataSetTableAdapters;

namespace Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.EmpleadosDal
{
    /// <summary>
    /// Clase que me sirve para maipular una lista de empleados
    /// </summary>
    public class EmpleadoListDal
    {
        /// <summary>
        /// Metodo que sirve para obtener una lista de empleados para el reporte
        /// </summary>
        /// <returns></returns>
        public static HospitalDataSet ObtenerListaEmpleadosReporte()
        {
            Operaciones.WriteLogsDebug("EmpleadoListDal", "ObtenerListaEmpleadosReporte", 
                string.Format("{0} Info: {1}", DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para obtener una lista de empleados"));


            HospitalDataSet hospitaldataSet = new HospitalDataSet();
            EmpleadosListaReporteTableAdapter empleadosTableAdapter = new EmpleadosListaReporteTableAdapter();
            try
            {
                empleadosTableAdapter.Fill(hospitaldataSet.Tables["EmpleadosListaReporte"] as HospitalDataSet.EmpleadosListaReporteDataTable);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("EmpleadoListDal", "ObtenerListaEmpleadosReporte", string.Format("{0} Error: {1}", DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("EmpleadoListDal", "ObtenerListaEmpleadosReporte", string.Format("{0} Error: {1}", DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("EmpleadoListDal", "ObtenerListaEmpleadosReporte", string.Format("{0}  Info: {1}", DateTime.Now.ToString(), 
                "Termino de ejecutar  el metodo acceso a datos para  obtener una lista de empleados"));


            return hospitaldataSet;

        }

    }
}
