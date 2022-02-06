using Ferale.SistemaDeInformacionApp.EmpleadoDal;
using Ferale.SistemaDeInformacionApp.SIFComun;
using System;
using System.Data.SqlClient;

namespace Ferale.SistemaDeInformacionApp.EmpleadoBrl
{
    /// <summary>
    /// Clase para la logica de negocios de lista de Empleados
    /// </summary>
    public class EmpleadoKeyValueListBrl
    {
        public static EmpleadoKeyValueList Obtener(string nombre, string apellido, byte cargo, byte sexo)
        {
            Operaciones.WriteLogsDebug("EmpleadoKeyValueListBrl", "Obtener", string.Format("{0} Info: {1}",
             DateTime.Now.ToString(),
             "Empezando a ejecutar el método lógica de negocio para Obtener un EmpleadoKeyValueList"));

            try
            {
                return EmpleadoKeyValueListDal.Obtener(nombre, apellido, cargo, sexo);
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
