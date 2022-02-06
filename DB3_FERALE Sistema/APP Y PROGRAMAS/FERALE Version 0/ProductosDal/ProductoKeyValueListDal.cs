using Ferale.SistemaDeInformacionApp.SIFComun;
using System;
using System.Data.SqlClient;

namespace Ferale.SistemaDeInformacionApp.ProductosDal
{
    /// <summary>
    /// Clase ProductoKeyValueListDal que sirve para interactuar con la base de datos
    /// </summary>
    public class ProductoKeyValueListDal
    {
        /// <summary>
        /// Retorna una lista de identifificadores y nombre completo de productos
        /// </summary>
        /// <param name="nombreProducto">Nombre del producto</param>
        /// <returns></returns>
        public static ProductoKeyValueList Obtener(string nombre, byte area)
        {
            ProductoKeyValueList lista = new ProductoKeyValueList();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = @"SELECT P.idProducto, P.nombreProducto as NombreCompleto
                            FROM Producto P
                            WHERE P.estado = 1 and P.nombreProducto LIKE @nombre AND P.areaProducto LIKE @area";
            try
            {
                cmd = OperacionesSql.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@nombre", string.Format("%{0}%", nombre));
                cmd.Parameters.AddWithValue("@area", string.Format("%{0}%", area));
                dr = OperacionesSql.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    lista.Add(new ProductoKeyValue()
                    {
                        IdProducto = dr.GetInt16(0),
                        NombreCompleto = dr.GetString(1)
                    });
                }
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("ProductoKeyValueListDal", "Obtenet(Get)", string.Format("{0} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
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
