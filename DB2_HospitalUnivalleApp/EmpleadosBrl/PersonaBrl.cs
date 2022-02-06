
using System;
using System.Data.SqlClient;
using Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.Comun;

namespace Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.EmpleadosBrl
{
    /// <summary>
    /// Clase para manejar la lógica de negocio de la persona
    /// </summary>
    public class PersonaBrl
    {
        /// <summary>
        /// método lógica de negocio para insertar un persona
        /// </summary>
        /// <param name="persona"></param>
        public static void Insertar(Persona persona)
        {
            Operaciones.WriteLogsDebug("PersonaBrl", "Insertar", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(),
            "Empezando a ejecutar el método lógica de negocio para crear un persona"));

            try
            {
              EmpleadosDal.PersonaDal.Insertar(persona);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("PersonaBrl", "Insertar", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("PersonaBrl", "Insertar", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("PersonaBrl", "Insertar", string.Format("{0} Info: {1}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "Termino de ejecutar  el método lógica de negocio para insertar persona"));

        }

    }
}
