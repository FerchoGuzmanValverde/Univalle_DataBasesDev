
using System;
using System.Data.SqlClient;
using Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.Comun;

namespace Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.EmpleadosDal
{
    public class TipoTelefonoDal
    {
        /// <summary>
        /// Obtiene un un tipo de telefono
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static TipoTelefono Get(int id)
        {
            TipoTelefono res = new TipoTelefono();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = "Select * From TipoTelefonos  WHERE  IdTipoTelefono = @id";
            try
            {
                cmd = OperacionesSql.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@id", id);
                dr = OperacionesSql.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    res = new TipoTelefono()
                    {
                        IdTipoTelefono = dr.GetByte(0),
                        Nombre = dr.GetString(1),
                    };
                }
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("TipoDal", "Obtener", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
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
