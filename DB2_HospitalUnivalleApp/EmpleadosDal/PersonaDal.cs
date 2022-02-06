using System;
using System.Data.SqlClient;
using Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.Comun;

namespace Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.EmpleadosDal
{
    /// <summary>
    /// Clase que sirve para interactuar con la base de datos
    /// </summary>
    public class PersonaDal
    {
        /// <summary>
        /// Inserta una Persona a la base de datos 
        /// </summary>
        /// <param name="persona"></param>
        public static void Insertar(Persona persona)
        {
            Operaciones.WriteLogsDebug("PersonaDal", "Insertar", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para crear un persona"));

            SqlCommand command = null;

            //Consulta para insertar personas
            string queryString = @"INSERT INTO Personas(IdPersona, Nombre, PrimerApellido, SegundoApellido, IdUsuario, Eliminado) 
                                    VALUES(@idPersona, @nombre, @primerApellido, @segundoApellido, @idUsuario, @eliminado)";
            //Declaro e inicio la conexion
            SqlConnection conexion = OperacionesSql.ObtenerConexion();

            //Declaro la transaccion
            SqlTransaction transaccion = null;
            try
            {
                //Abro la conexion a la base de datos
                conexion.Open();

                //Inicio la transaccion
                transaccion = conexion.BeginTransaction();

                command = OperacionesSql.CreateBasicCommandWithTransaction(queryString, transaccion, conexion);
                if (persona.Usuario != null)
                {
                    UsuarioDal.InsertarTransaccion(persona.Usuario, transaccion, conexion);
                    command.Parameters.AddWithValue("@idUsuario", persona.Usuario.IdUsuario);
                }
                else
                {
                    command.Parameters.AddWithValue("@idUsuario", null);
                }

                command.Parameters.AddWithValue("@idPersona", persona.IdPersona);
                command.Parameters.AddWithValue("@nombre", persona.Nombre);
                command.Parameters.AddWithValue("@primerApellido", persona.PrimerApellido);
                command.Parameters.AddWithValue("@segundoApellido", persona.SegundoApellido);
                command.Parameters.AddWithValue("@eliminado", false);
                OperacionesSql.ExecuteBasicCommandWithTransaction(command);

                //Insertar telefonos
                foreach (Telefono telf in persona.Telefonos)
                {
                    TelefonoDal.InsertarConTransaccion(telf,transaccion, conexion);
                }
                transaccion.Commit();

            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("PersonaDal", "Insertar", string.Format("{0} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("PersonaDal", "Insertar", string.Format("{0} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
            Operaciones.WriteLogsDebug("PersonaDal", "Insertar", string.Format("{0} Info: {1}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "Termino de ejecutar  el metodo acceso a datos para insertar persona"));
        }

        /// <summary>
        /// Inserta una Persona a la base de datos 
        /// </summary>
        /// <param name="persona"></param>
        public static void InsertarConTransaccion(Persona persona, SqlTransaction transaccion, SqlConnection conexion)
        {
            Operaciones.WriteLogsDebug("PersonaDal", "Insertar", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para crear un persona"));

            SqlCommand command = null;

            //Consulta para insertar personas
            string queryString = @"INSERT INTO Personas(IdPersona, Nombre, PrimerApellido, SegundoApellido, IdUsuario, Eliminado) 
                                    VALUES(@idPersona, @nombre, @primerApellido, @segundoApellido, @idUsuario, @eliminado)";

            try
            {
                command = OperacionesSql.CreateBasicCommandWithTransaction(queryString, transaccion, conexion);
                if (persona.Usuario != null)
                {
                    UsuarioDal.InsertarTransaccion(persona.Usuario, transaccion, conexion);
                    command.Parameters.AddWithValue("@idUsuario", persona.Usuario.IdUsuario);
                }
                else
                {
                    command.Parameters.AddWithValue("@idUsuario", null);
                }

                command.Parameters.AddWithValue("@idPersona", persona.IdPersona);
                command.Parameters.AddWithValue("@nombre", persona.Nombre);
                command.Parameters.AddWithValue("@primerApellido", persona.PrimerApellido);
                command.Parameters.AddWithValue("@segundoApellido", persona.SegundoApellido);
                command.Parameters.AddWithValue("@eliminado", false);
                OperacionesSql.ExecuteBasicCommandWithTransaction(command);

                //Insertar telefonos
                foreach (Telefono telf in persona.Telefonos)
                {
                    TelefonoDal.InsertarConTransaccion(telf, transaccion, conexion);
                }
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("PersonaDal", "Insertar", string.Format("{0} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("PersonaDal", "Insertar", string.Format("{0} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
           
            Operaciones.WriteLogsDebug("PersonaDal", "Insertar", string.Format("{0} Info: {1}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "Termino de ejecutar  el metodo acceso a datos para insertar persona"));
        }
        /// <summary>
        /// Elimina Persona de la base de datos
        /// </summary>
        /// <param name="idPersona"></param>
        public static void EliminarConTransaccion(Guid idPersona, SqlTransaction transaccion, SqlConnection conexion)
        {
            Operaciones.WriteLogsDebug("PersonaDal", "Eliminar", string.Format("{0} Info: {1}", DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para eliminar un Persona"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Personas SET Eliminado=1
                                    WHERE IdPersona = @idPersona";
            try
            {
                command = OperacionesSql.CreateBasicCommandWithTransaction(queryString, transaccion, conexion);
                command.Parameters.AddWithValue("@idPersona", idPersona);
                OperacionesSql.ExecuteBasicCommandWithTransaction(command);

                //elimina al usuario
                UsuarioDal.EliminarPorIdPersonaConTransaccion(idPersona, transaccion, conexion);

                //Eliminar telefonos
                TelefonoDal.EliminarPorIdPersonaConTransaccion(idPersona, transaccion, conexion);

            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("PersonaDal", "Eliminar", string.Format("{0} Error: {1}",  DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("PersonaDal", "Eliminar", string.Format("{0} Error: {1}",  DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("PersonaDal", "Eliminar", string.Format("{0} Info: {1}",  DateTime.Now.ToString(), "Termino de ejecutar  el metodo acceso a datos para Eliminar un Cliente"));
        }

        /// <summary>
        /// Actualiza Persona de la base de datos
        /// </summary>
        /// <param name="Persona"></param>
        public static void Actualizar(Persona persona)
        {
            Operaciones.WriteLogsDebug("PersonaDal", "Eliminar", string.Format("{0} Info: {1}", DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para eliminar un Persona"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Personas SET Nombre=@nombre, PrimerApellido=@primerApellido, SegundoApellido=@segundoApellido, IdUsuario=@idUsuario
                                    WHERE IdPersona=@idPersona";
            try
            {

                command = OperacionesSql.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@idPersona", persona.IdPersona);
                command.Parameters.AddWithValue("@nombre", persona.Nombre);
                command.Parameters.AddWithValue("@primerApellido", persona.Nombre);
                command.Parameters.AddWithValue("@segundoApellido", persona.Nombre);
               
                //Actualizo al usuario
                if (persona.Usuario != null)
                {
                    command.Parameters.AddWithValue("@idUsuario", persona.Usuario.IdUsuario);
                    UsuarioDal.Actualizar(persona.Usuario);
                }
                else
                {
                    command.Parameters.AddWithValue("@idUsuario", DBNull.Value);
                }

                //Actualizo los telefonos
                foreach (var telefono in persona.Telefonos)
                {
                    TelefonoDal.Actualizar(telefono);
                }

                OperacionesSql.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("PersonaDal", "Eliminar", string.Format("{0} Error: {1}",  DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("PersonaDal", "Eliminar", string.Format("{0} Error: {1}",  DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("PersonaDal", "Eliminar", string.Format("{0} Info: {1}",  DateTime.Now.ToString(), "Termino de ejecutar  el metodo acceso a datos para Eliminar un Cliente"));

        }

        /// <summary>
        /// Obtiene un Persona de la base de datos
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Persona Obtener(Guid id)
        {
            Persona persona = new Persona();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = @"SELECT * FROM Personas WHERE IdPersona=@id and Eliminado=0";
            try
            {
                cmd = OperacionesSql.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@id", id);
                dr = OperacionesSql.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    persona = new Persona()
                    {
                        IdPersona = dr.GetGuid(0),
                        Nombre = dr.GetString(1),
                        PrimerApellido = dr.GetString(2),
                        SegundoApellido = dr.GetString(3),
                        Usuario = UsuarioDal.Obtener(dr.GetGuid(4)),
                        Eliminado = dr.GetBoolean(5)
                    };

                    persona.Telefonos = TelefonosListDal.Obtener(persona.IdPersona);

                }
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("PersonaDal", "Obtenet(Get)", string.Format("{0} Error: {1}",  DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return persona;
        }

        /// <summary>
        /// Obtiene un Persona de la base de datos
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Guid ObtenerIdUsuario(Guid idPersona)
        {
            Guid idUsuario = Guid.Empty;
            SqlCommand cmd = null;
            string query = @"SELECT IdUsuario FROM Personas WHERE IdPersona=@id and Eliminado=0";
            try
            {
                cmd = OperacionesSql.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@id", idPersona);
                idUsuario = new Guid( OperacionesSql.ExcecuteScalarCommand(cmd));
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("PersonaDal", "Obtenet(Get)", string.Format("{0} Error: {1}",  DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return idUsuario;
        }

        /// <summary>
        /// Obtiene un Persona de la base de datos
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Empleado ObtenerEmpleado(Guid id)
        {
            Empleado persona = new Empleado();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = @"SELECT * FROM Personas WHERE IdPersona=@id and Eliminado=0";
            try
            {
                cmd = OperacionesSql.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@id", id);
                dr = OperacionesSql.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    persona = new Empleado()
                    {
                        IdPersona = dr.GetGuid(0),
                        Nombre = dr.GetString(1),
                        PrimerApellido = dr.GetString(2),
                        SegundoApellido = dr.GetString(3),
                        Usuario = UsuarioDal.Obtener(dr.GetGuid(4)),
                        Eliminado = dr.GetBoolean(5)
                    };

                    persona.Telefonos = TelefonosListDal.Obtener(persona.IdPersona);

                }
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("PersonaDal", "Obtenet(Get)", string.Format("{0} Error: {1}",  DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return persona;
        }
    }
}
