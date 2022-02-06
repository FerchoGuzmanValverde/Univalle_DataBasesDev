using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.ClienteDal;
using Sistema.Comun;
using System.Data.SqlClient;

namespace Sistema.ClienteBrl
{
    /// <summary>
    /// Clase para la logica de negocios de ClienteBrl
    /// </summary>
    public class ClienteBrl
    {
        /// <summary>
        /// Metodo logica de negocio para eliminar un empleado
        /// </summary>
        /// <param name="cliente"></param>
        public static Cliente Obtener(int id)
        {
            Operaciones.WriteLogsDebug("ClienteBrl", "Obtener", string.Format("{0} Info: {1}",
            DateTime.Now.ToLongDateString(),
            "Empezando a ejecutar el metodo logica de negocio para Obtener un cliente"));

            try
            {
                return ClienteDal.ClienteDal.Obtener(id);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("ClienteBrl", "Obtener", string.Format("{0} {1} Error: {2}",
                    DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("ClienteBrl", "Obtener", string.Format("{0} {1} Error: {2}",
                    DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

        }
    }
}
