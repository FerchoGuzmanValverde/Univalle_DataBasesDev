using System;
using System.Data.SqlClient;
using Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.Comun;

namespace Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.EmpleadosDal
{
    /// <summary>
    ///  Clase EmpleadoKeyValueListDal que sirve para interactuar con la base de datos
    /// </summary>
    public class EmpleadoKeyValueListDal
    {
        /// <summary>
        /// Retorna una lista de identifificadores y nombre completo de empleados
        /// </summary>
        /// <param name="apellido">Apellido paterno de empleados</param>
        /// <returns></returns>
        public static EmpleadoKeyValueList Obtener(string apellido)
        {
            EmpleadoKeyValueList lista = new EmpleadoKeyValueList();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = @"Select e.IdPersona, CONCAT(p.Nombre, ' ', p.PrimerApellido, ' ' ,p.SegundoApellido) as NombreCompleto
                            from EMPLEADOS e inner join PERSONAS p on e.IdPersona = p.IdPersona
                            Where e.Eliminado = 0 and p.PrimerApellido like @apellido";
            try
            {
                cmd = OperacionesSql.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@apellido", string.Format("%{0}%", apellido));
                dr = OperacionesSql.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    lista.Add(new EmpleadoKeyValue()
                    {
                        IdPersona = dr.GetGuid(0),
                        NombreCompleto = dr.GetString(1)
                    });
                }
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("TelefonoDal", "Obtenet(Get)", string.Format("{0} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
    }
}
