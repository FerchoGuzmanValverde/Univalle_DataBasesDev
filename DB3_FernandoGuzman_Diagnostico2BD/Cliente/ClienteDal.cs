using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Comun;
using System.Data.SqlClient;

namespace Sistema.ClienteDal
{
    /// <summary>
    /// Clase para interactuar con la base de datos
    /// </summary>
    public class ClienteDal
    {
        public static Cliente Obtener(int id)
        {
            Cliente cliente = new Cliente();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = @"SELECT * FROM Cliente WHERE ClienteID=@id";
            try
            {
                cmd = OperacionesSql.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@id", id);
                dr = OperacionesSql.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    cliente = new Cliente()
                    {
                        NombreCliente = dr.GetString(1),
                        Direccion = dr.GetString(2),
                        Compras = CompraDal.Obtener(id)
                    };
                }
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("ClienteDal", "Obtenet(Get)", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return cliente;
        }
    }
}
