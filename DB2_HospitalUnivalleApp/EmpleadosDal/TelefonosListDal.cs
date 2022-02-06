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
    /// Clase para manejar una lista telefonos en la base de datos
    /// </summary>
    public class TelefonosListDal
    {
        /// <summary>
        /// Obtiene un lista de Telefonos de la base de datos
        /// </summary>
        /// <param name="idPersona"></param>
        /// <returns>Lista de telefonos</returns>
        public static TelefonosList Obtener(Guid idPersona)
        {
            TelefonosList lista = new TelefonosList();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = @"SELECT * FROM Telefonos WHERE IdPersona=@id and Eliminado=0";
            try
            {
                cmd = OperacionesSql.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@id", idPersona);
                dr = OperacionesSql.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    Telefono telefono = new Telefono()
                    {
                        IdTelefono = dr.GetGuid(0),
                        Numero = dr.GetInt32(1),
                        TipoTelefono = TipoTelefonoDal.Get(dr.GetByte(2)),
                    };

                    lista.Add(telefono);
                }
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("TelefonosListDal", "Obtener", string.Format("{0} Error: {1}", DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("TelefonosListDal", "Obtenet(Get)", string.Format("{0} Error: {1}", DateTime.Now.ToString(), ex.Message));
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
