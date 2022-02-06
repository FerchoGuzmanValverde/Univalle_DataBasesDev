using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.Comun;

namespace Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.EmpleadosDal
{
    /// <summary>
    /// Clase que sirve para interacturar en la base de datos 
    /// </summary>
    public class TipoTelefonoListDal
    {
        /// <summary>
        /// Obtiene una lista de tipo de telefono
        /// </summary>
        /// <returns>Lista d etipos telefon</returns>
        public static TipoTelefonoList Get()
        {
            TipoTelefonoList lista = new TipoTelefonoList();
            TipoTelefono telefono = null;
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = "Select IdTipoTelefono, Nombre From TipoTelefonos ";
            try
            {
                cmd = OperacionesSql.CreateBasicCommand(query);
                dr = OperacionesSql.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    lista.Add(telefono = new TipoTelefono()
                    {
                        IdTipoTelefono = dr.GetByte(0),
                        Nombre = dr.GetString(1),
                    });
                }
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("TipoTelefonoList", "Obtener", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(),  ex.Message));
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
