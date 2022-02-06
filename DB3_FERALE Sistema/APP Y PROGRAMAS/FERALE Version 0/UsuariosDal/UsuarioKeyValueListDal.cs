using Ferale.SistemaDeInformacionApp.SIFComun;
using System;
using System.Data.SqlClient;

namespace Ferale.SistemaDeInformacionApp.UsuariosDal
{
    /// <summary>
    /// Clase UsuarioKeyValueListDal que sirve para interactuar con la base de datos
    /// </summary>
    public class UsuarioKeyValueListDal
    {
        /// <summary>
        /// Retorna una lista de identifificadores y logins de usuarios
        /// </summary>
        /// <param name="login">Login del usuario</param>
        /// <returns></returns>
        public static UsuarioKeyValueList Obtener(string login)
        {
            UsuarioKeyValueList lista = new UsuarioKeyValueList();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = @"SELECT U.idUsuario, U.loginUsuario
                            FROM Usuario U
                            WHERE U.estado = 1 AND U.loginUsuario LIKE @login";
            try
            {
                cmd = OperacionesSql.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@login", string.Format("%{0}%", login));
                dr = OperacionesSql.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    lista.Add(new UsuarioKeyValue()
                    {
                        IdUsuario = dr.GetInt32(0),
                        Login = dr.GetString(1)
                    });
                }
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("UsuarioKeyValueListDal", "Obtenet(Get)", string.Format("{0} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
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
