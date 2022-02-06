using Ferale.SistemaDeInformacionApp.SIFComun;
using System;
using System.Data.SqlClient;

namespace Ferale.SistemaDeInformacionApp.ClienteDal
{
    /// <summary>
    /// Clase ClienteKeyValueList que sirve para interactuar con la base de datos
    /// </summary>
    public class ClienteKeyValueListDal
    {
        /// <summary>
        /// Retorna una lista de identifificadores y nombre completo de clientes
        /// </summary>
        /// <param name="apellido">Apellido paterno de clientes</param>
        /// <returns></returns>
        public static ClienteKeyValueList Obtener(string nombre, string apellido, byte idProvincia)
        {
            ClienteKeyValueList lista = new ClienteKeyValueList();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = @"SELECT C.idCliente, CONCAT(p.nombre, ' ', p.primerApellido, ' ' ,p.segundoApellido) as NombreCompleto
                            FROM Cliente C INNER JOIN Persona p ON C.idCliente = p.idPersona
                            WHERE p.estado = 1 and p.primerApellido LIKE @apellido AND p.nombre LIKE @nombre AND p.idProvincia LIKE @idProvincia";
            try
            {
                cmd = OperacionesSql.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@apellido", string.Format("%{0}%", apellido));
                cmd.Parameters.AddWithValue("@nombre", string.Format("%{0}%", nombre));
                cmd.Parameters.AddWithValue("@idProvincia", string.Format("%{0}%", idProvincia));
                dr = OperacionesSql.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    lista.Add(new ClienteKeyValue()
                    {
                        IdPersona = dr.GetInt32(0),
                        NombreCompleto = dr.GetString(1)
                    });
                }
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("ClienteKeyValueListDal", "Obtenet(Get)", string.Format("{0} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
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
