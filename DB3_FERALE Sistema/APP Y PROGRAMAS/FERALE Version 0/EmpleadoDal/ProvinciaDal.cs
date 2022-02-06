using Ferale.SistemaDeInformacionApp.SIFComun;
using System;
using System.Data.SqlClient;

namespace Ferale.SistemaDeInformacionApp.EmpleadoDal
{
    /// <summary>
    /// Clase que sirve para interactuar con la base de datos
    /// </summary>
    public class ProvinciaDal
    {
        /// <summary>
        /// Obtiene un Provincia de la base de datos
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Provincia Obtener(int id)
        {
            Provincia res = new Provincia();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = @"SELECT * FROM Provincia WHERE idProvincia=@id";
            try
            {
                cmd = OperacionesSql.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@id", id);
                dr = OperacionesSql.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    res = new Provincia()
                    {
                        IdProvincia = dr.GetInt16(0),
                        NombreProvincia = dr.GetString(1)
                    };
                }
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("ProvinciaDal", "Obtenet(Get)", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return res;
        }
    }
}
