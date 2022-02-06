using Sistema.Comun;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.ClienteDal
{
    /// <summary>
    /// Clase para interactuar con la base de datos
    /// </summary>
    public class CompraDal
    {
        /// <summary>
        /// Metodo para obtener una lista de Compras
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static List<Compra> Obtener(int id)
        {
            List<Compra> lista = new List<Compra>();
            Compra compra = new Compra();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = @"SELECT * FROM Compra WHERE ClienteID=@id";
            try
            {
                cmd = OperacionesSql.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@id", id);
                dr = OperacionesSql.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    compra = new Compra()
                    {
                        TotalCompra = dr.GetInt32(3)
                    };
                    lista.Add(compra);
                }
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("CompraDal", "Obtenet(Get)", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
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
