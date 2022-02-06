using Ferale.SistemaDeInformacionApp.SIFComun;
using System;
using System.Data.SqlClient;

namespace Ferale.SistemaDeInformacionApp.ProductosBrl
{
    /// <summary>
    /// Clase para la logica de negocios de lista de Productos
    /// </summary>
    public class ProductoKeyValueListBrl
    {
        public static ProductoKeyValueList Obtener(string nombre, byte area)
        {
            Operaciones.WriteLogsDebug("ProductoKeyValueListBrl", "Obtener", string.Format("{0} Info: {1}",
             DateTime.Now.ToString(),
             "Empezando a ejecutar el método lógica de negocio para Obtener un ProductoKeyValueList"));

            try
            {
                return ProductosDal.ProductoKeyValueListDal.Obtener(nombre, area);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("ProductoKeyValueListBrl", "Obtener", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("ProductoKeyValueListBrl", "Obtener", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

        }
    }
}
