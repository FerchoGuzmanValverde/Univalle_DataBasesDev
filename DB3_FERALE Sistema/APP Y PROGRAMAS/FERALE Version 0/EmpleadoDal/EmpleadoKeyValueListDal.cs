using Ferale.SistemaDeInformacionApp.SIFComun;
using System;
using System.Data.SqlClient;

namespace Ferale.SistemaDeInformacionApp.EmpleadoDal
{
    /// <summary>
    /// Clase EmpleadoKeyValueList que sirve para interactuar con la base de datos
    /// </summary>
    public class EmpleadoKeyValueListDal
    {
        /// <summary>
        /// Retorna una lista de identifificadores y nombre completo de empleados
        /// </summary>
        /// <param name="apellido">Apellido paterno de empleados</param>
        /// <returns></returns>
        public static EmpleadoKeyValueList Obtener(string nombre, string apellido, byte cargo, byte sexo)
        {
            EmpleadoKeyValueList lista = new EmpleadoKeyValueList();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = @"SELECT E.idEmpleado, CONCAT(p.nombre, ' ', p.primerApellido, ' ' ,p.segundoApellido) as NombreCompleto
                            FROM Empleado E INNER JOIN Persona p ON E.idEmpleado = p.idPersona
                            WHERE p.estado = 1 AND p.primerApellido LIKE @apellido AND p.nombre LIKE @nombre AND E.sexo LIKE @sexo AND E.idCargo LIKE @cargo";
            try
            {
                cmd = OperacionesSql.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@apellido", string.Format("%{0}%", apellido));
                cmd.Parameters.AddWithValue("@nombre", string.Format("%{0}%", nombre));
                cmd.Parameters.AddWithValue("@sexo", string.Format("%{0}%", sexo));
                cmd.Parameters.AddWithValue("@cargo", string.Format("%{0}%", cargo));
                dr = OperacionesSql.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    lista.Add(new EmpleadoKeyValue()
                    {
                        IdPersona = dr.GetInt32(0),
                        NombreCompleto = dr.GetString(1)
                    });
                }
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("EmpleadoKeyValueList", "Obtenet(Get)", string.Format("{0} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
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
