using Ferale.SistemaDeInformacionApp.SIFComun;
using System;
using System.Data.SqlClient;

namespace Ferale.SistemaDeInformacionApp.EmpleadoDal
{
    /// <summary>
    /// Clase para interactuar con una lista de telefonos de cliente
    /// </summary>
    public class TelefonoListDal
    {
        /// <summary>
        /// Obtiene un lista de Telefonos de la base de datos
        /// </summary>
        /// <param name="idPersona"></param>
        /// <returns>Lista de telefonos</returns>
        public static TelefonosList Obtener(int idPersona)
        {
            TelefonosList lista = new TelefonosList();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = @"SELECT * FROM Telefono WHERE idPersona=@id";
            try
            {
                cmd = OperacionesSql.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@id", idPersona);
                dr = OperacionesSql.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    Telefono telefono = new Telefono()
                    {
                        NroTelefono = dr.GetString(1)
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
