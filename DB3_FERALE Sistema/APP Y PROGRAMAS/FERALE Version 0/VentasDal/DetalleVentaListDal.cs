using Ferale.SistemaDeInformacionApp.SIFComun;
using System;
using System.Data.SqlClient;

namespace Ferale.SistemaDeInformacionApp.VentasDal
{
    /// <summary>
    /// Clase para interactuar con la base de datos
    /// </summary>
    public class DetalleVentaListDal
    {
        /// <summary>
        /// Obtiene un lista de Detalles de Venta de la base de datos
        /// </summary>
        /// <param name="idVenta"></param>
        /// <returns>Lista de Detalles de venta</returns>
        public static DetalleVentaList Obtener(int idVenta)
        {
            DetalleVentaList lista = new DetalleVentaList();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = @"SELECT * FROM DetalleVenta WHERE idVenta=@id";
            try
            {
                cmd = OperacionesSql.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@id", idVenta);
                dr = OperacionesSql.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    DetalleVenta detalle = new DetalleVenta()
                    {
                        Producto = ProductosDal.ProductosDal.Obtener(dr.GetInt16(1)),
                        cantidad = dr.GetByte(2),
                        PrecioUnitario = dr.GetByte(3)
                    };
                    lista.Add(detalle);
                }
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("DetalleVentaListDal", "Obtener", string.Format("{0} Error: {1}", DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("DetalleVentaListDal", "Obtenet(Get)", string.Format("{0} Error: {1}", DateTime.Now.ToString(), ex.Message));
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
