using Ferale.SistemaDeInformacionApp.SIFComun;
using System;
using System.Data.SqlClient;

namespace Ferale.SistemaDeInformacionApp.EmpleadoDal
{
    /// <summary>
    /// Clase que sirve para interactuar con la base de datos
    /// </summary>
    public class CargoDal
    {
        /// <summary>
        /// Obtiene un Cargo de la base de datos
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Cargo Obtener(int id)
        {
            Cargo res = new Cargo();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = @"SELECT * FROM Cargo WHERE idCargo=@id";
            try
            {
                cmd = OperacionesSql.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@id", id);
                dr = OperacionesSql.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    res = new Cargo()
                    {
                        IdCargo = dr.GetByte(0),
                        NombreCargo = dr.GetString(1)
                    };
                }
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("CargoDal", "Obtenet(Get)", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
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
