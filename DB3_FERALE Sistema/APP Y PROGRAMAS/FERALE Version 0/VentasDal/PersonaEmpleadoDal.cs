using Ferale.SistemaDeInformacionApp.SIFComun;
using System;
using System.Data.SqlClient;

namespace Ferale.SistemaDeInformacionApp.ClienteDal
{
    /// <summary>
    /// Clase que sirve para interactuar con la base de datos
    /// </summary>
    public class PersonaEmpleadoDal
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
            string queryString = @"INSERT INTO Persona(nombre, primerApellido, segundoApellido, cedulaIdentidad, tipoPersona, estado, idProvincia, idDomicilio, idUsuario) 
                                    VALUES(@nombre, @primerApellido, @segundoApellido, @cedulaIdentidad, @tipoPersona, @estado, @idProcedencia, @idDomicilio, @idUsuario)";
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
                command.Parameters.AddWithValue("@nombre", persona.Nombre);
                command.Parameters.AddWithValue("@primerApellido", persona.PrimerApellido);
                command.Parameters.AddWithValue("@segundoApellido", persona.SegundoApellido);
                command.Parameters.AddWithValue("@cedulaIdentidad", persona.CedulaIdentidad);
                command.Parameters.AddWithValue("@tipoPersona", persona.TipoPersona);
                command.Parameters.AddWithValue("@estado", 1);
                command.Parameters.AddWithValue("@idProcedencia", persona.Provincia.IdProvincia);
                command.Parameters.AddWithValue("@idUsuario", OperacionesSql.GetActIdTable("Usuario"));
                command.Parameters.AddWithValue("@idDomicilio", OperacionesSql.GetActIdTable("Domicilio"));
                OperacionesSql.ExecuteBasicCommandWithTransaction(command);

                //Insertar telefonos
                foreach (Telefono telf in persona.Telefonos)
                {
                    TelefonoDal.InsertarConTransaccion(telf, transaccion, conexion);
                }
                transaccion.Commit();

            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("PersonaDal", "Insertar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("PersonaDal", "Insertar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
            Operaciones.WriteLogsDebug("PersonaDal", "Insertar", string.Format("{0} {1} Info: {2}",
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
            string queryString = @"INSERT INTO Persona(nombre, primerApellido, segundoApellido, cedulaIdentidad, tipoPersona, estado, idProvincia, idUsuario, idDomicilio) 
                                    VALUES(@nombre, @primerApellido, @segundoApellido, @cedulaIdentidad, @tipoPersona, @estado, @idProcedencia, @idUsuario, @idDomicilio)";

            try
            {
                command = OperacionesSql.CreateBasicCommandWithTransaction(queryString, transaccion, conexion);
                if (persona.Usuario != null)
                {
                    UsuarioDal.InsertarTransaccion(persona.Usuario, transaccion, conexion);
                    command.Parameters.AddWithValue("@idUsuario", OperacionesSql.GetActIdTable("Usuario"));
                }
                else
                {
                    command.Parameters.AddWithValue("@idUsuario", null);
                }
                if(persona.Domicilio != null)
                {
                    DomicilioDal.InsertarTransaccion(persona.Domicilio, transaccion, conexion);
                    command.Parameters.AddWithValue("@idDomicilio", OperacionesSql.GetActIdTable("Domicilio"));
                }
                else
                {
                    command.Parameters.AddWithValue("@idDomicilio", null);
                }
                command.Parameters.AddWithValue("@nombre", persona.Nombre);
                command.Parameters.AddWithValue("@primerApellido", persona.PrimerApellido);
                command.Parameters.AddWithValue("@segundoApellido", persona.SegundoApellido);
                command.Parameters.AddWithValue("@cedulaIdentidad", persona.CedulaIdentidad);
                command.Parameters.AddWithValue("@tipoPersona", persona.TipoPersona);
                command.Parameters.AddWithValue("@estado", 1);
                command.Parameters.AddWithValue("@idProcedencia", persona.Provincia.IdProvincia);
                OperacionesSql.ExecuteBasicCommandWithTransaction(command);
                //Insertar telefonos
                foreach (Telefono telf in persona.Telefonos)
                {
                    TelefonoDal.InsertarConTransaccion(telf, transaccion, conexion);
                }
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("PersonaDal", "Insertar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("PersonaDal", "Insertar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("PersonaDal", "Insertar", string.Format("{0} {1} Info: {2}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "Termino de ejecutar  el metodo acceso a datos para insertar persona"));
        }

        /// <summary>
        /// Eliminado Logico de Persona de la base de datos
        /// </summary>
        /// <param name="id"></param>
        public static void Eliminar(Guid id)
        {
            Operaciones.WriteLogsDebug("PersonaDal", "Eliminar", string.Format("{0} Info: {1}", DateTime.Now.ToLongDateString(), "Empezando a ejecutar el metodo acceso a datos para eliminar un Persona"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Persona SET estado=0
                                    WHERE idPersona = @idPersona";
            try
            {
                command = OperacionesSql.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@idPersona", id);
                OperacionesSql.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("PersonaDal", "Eliminar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("PersonaDal", "Eliminar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("PersonaDal", "Eliminar", string.Format("{0} {1} Info: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "Termino de ejecutar  el metodo acceso a datos para Eliminar una Persona"));
        }

        /// <summary>
        /// Actualiza Persona de la base de datos
        /// </summary>
        /// <param name="Persona"></param>
        public static void Actualizar(Persona persona, int id)
        {
            Operaciones.WriteLogsDebug("PersonaDal", "Actualizar", string.Format("{0} Info: {1}", DateTime.Now.ToLongDateString(), "Empezando a ejecutar el metodo acceso a datos para Actualizar un Persona"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Persona SET nombre=@nombre, primerApellido=@primerApellido, segundoApellido=@segundoApellido,
                                    cedulaIdentidad=@cedulaIdentidad, tipoPersona=@tipoPersona
                                    WHERE idPersona=@idPersona";
            try
            {
                command = OperacionesSql.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@idPersona", id);
                command.Parameters.AddWithValue("@nombre", persona.Nombre);
                command.Parameters.AddWithValue("@primerApellido", persona.PrimerApellido);
                command.Parameters.AddWithValue("@segundoApellido", persona.SegundoApellido);
                command.Parameters.AddWithValue("@cedulaIdentidad", persona.CedulaIdentidad);
                command.Parameters.AddWithValue("@tipoPersona", persona.TipoPersona);

                OperacionesSql.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("PersonaDal", "Actualizar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("PersonaDal", "Actualizar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("PersonaDal", "Actualizar", string.Format("{0} {1} Info: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "Termino de ejecutar  el metodo acceso a datos para Actualizar una Persona"));

        }

        /// <summary>
        /// Obtiene un Persona de la base de datos
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public static Persona Obtener(int id)
        {
            Persona persona = new Persona();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = @"SELECT * FROM Persona WHERE idPersona=@id AND estado=1";
            try
            {
                cmd = OperacionesSql.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@id", id);
                dr = OperacionesSql.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    persona = new Persona()
                    {
                        Nombre = dr.GetString(1),
                        PrimerApellido = dr.GetString(2),
                        SegundoApellido = dr.GetString(3),
                        CedulaIdentidad = dr.GetString(4),
                        TipoPersona = dr.GetByte(5)
                    };
                }
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("PersonaDal", "Obtenet(Get)", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
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
        public static Empleado ObtenerEmpleado(int id)
        {
            Empleado persona = new Empleado();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = @"SELECT * FROM Persona WHERE idPersona=@id and estado=1";
            try
            {
                cmd = OperacionesSql.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@id", id);
                dr = OperacionesSql.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    persona = new Empleado()
                    {
                        IdPersona = dr.GetInt32(0),
                        Nombre = dr.GetString(1),
                        PrimerApellido = dr.GetString(2),
                        SegundoApellido = dr.GetString(3),
                        CedulaIdentidad = dr.GetString(4),
                        TipoPersona = dr.GetByte(5),
                        Provincia = ProvinciaDal.Obtener(dr.GetInt16(7)),
                        Usuario = UsuarioDal.Obtener(dr.GetInt32(8)),
                        Domicilio = DomicilioDal.Obtener(dr.GetInt32(9))
                    };

                    persona.Telefonos = TelefonoListDal.Obtener(persona.IdPersona);

                }
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("PersonaDal", "Obtenet(Get)", string.Format("{0} Error: {1}", DateTime.Now.ToString(), ex.Message));
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
