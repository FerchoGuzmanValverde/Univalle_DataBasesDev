using Ferale.SistemaDeInformacionApp.ClienteDal;
using Ferale.SistemaDeInformacionApp.SIFComun;
using System;
using System.Data.SqlClient;

namespace Ferale.SistemaDeInformacionApp.ClienteBrl
{
    /// <summary>
    /// Clase para la logica de negocios de lista de Clientes
    /// </summary>
    public class ClienteKeyValueListBrl
    {
        public static ClienteKeyValueList Obtener(string nombre, string apellido, byte idProvincia)
        {
            Operaciones.WriteLogsDebug("ClienteKeyValueListBrl", "Obtener", string.Format("{0} Info: {1}",
             DateTime.Now.ToString(),
             "Empezando a ejecutar el método lógica de negocio para Obtener un ClienteKeyValueList"));

            try
            {
                return ClienteKeyValueListDal.Obtener(nombre, apellido, idProvincia);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("ClienteKeyValueListBrl", "Obtener", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("ClienteKeyValueListBrl", "Obtener", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

        }
    }
}
