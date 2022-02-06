using Ferale.SistemaDeInformacionApp.SIFComun;
using System;
using System.Data.SqlClient;

namespace Ferale.SistemaDeInformacionApp.UsuarioBrl
{
    /// <summary>
    /// Clase para la logica de negocios de Usuarios
    /// </summary>
    public class UsuarioKeyValueListBrl
    {
        public static UsuarioKeyValueList Obtener(string login)
        {
            Operaciones.WriteLogsDebug("UsuarioKeyValueListBrl", "Obtener", string.Format("{0} Info: {1}",
             DateTime.Now.ToString(),
             "Empezando a ejecutar el método lógica de negocio para Obtener un UsuarioKeyValueList"));

            try
            {
                return UsuariosDal.UsuarioKeyValueListDal.Obtener(login);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("UsuarioKeyValueListBrl", "Obtener", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("UsuarioKeyValueListBrl", "Obtener", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

        }
    }
}
