using System;
using System.Data.SqlClient;
using Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.Comun;
using Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.EmpleadosDal;

namespace Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.EmpleadosBrl
{
    /// <summary>
    /// Clase para manejar la lógica de negocio de la EmpleadoKeyValueList
    /// </summary>
    public class EmpleadoKeyValueListBrl
    {
        public static EmpleadoKeyValueList Obtener(string apellido)
        {
            Operaciones.WriteLogsDebug("EmpleadoKeyValueListBrl", "Obtener", string.Format("{0} Info: {1}",
             DateTime.Now.ToString(),
             "Empezando a ejecutar el método lógica de negocio para Obtener un EmpleadoKeyValueList"));

            try
            {
                return EmpleadoKeyValueListDal.Obtener(apellido);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("EmpleadoKeyValueListBrl", "Obtener", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("EmpleadoKeyValueListBrl", "Obtener", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

        }
    }
}
