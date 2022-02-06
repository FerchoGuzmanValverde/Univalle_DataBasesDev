using System;
using System.Data.SqlClient;
using Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.Comun;

namespace Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.EmpleadosDal
{
    /// <summary>
    ///  Clase EmpleadoDal que sirve para interactuar con la base de datos
    /// </summary>
    public class EmpleadoDal
    {
        /// <summary>
        /// Inserta una Empleado a la base de datos 
        /// </summary>
        /// <param name="empleado"></param>
        public static void Insertar(Empleado empleado)
        {
            Operaciones.WriteLogsDebug("EmpleadoDal", "Insertar", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para crear un empleado"));

            SqlCommand command = null;

            //Consulta para insertar empleados
            string queryString = @"INSERT INTO Empleados(IdPersona, FechaContratacion, Eliminado) 
                                    VALUES(@idEmpleado, @fechaContratacion, @eliminado)";
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

                //Inserto a la persona
                PersonaDal.InsertarConTransaccion(empleado as Persona, transaccion, conexion);

                //Inserto al empleado
                command = OperacionesSql.CreateBasicCommandWithTransaction(queryString, transaccion, conexion);
                command.Parameters.AddWithValue("@idEmpleado", empleado.IdPersona);
                command.Parameters.AddWithValue("@fechaContratacion", empleado.FechaContratacion);
                command.Parameters.AddWithValue("@eliminado", false);
                OperacionesSql.ExecuteBasicCommandWithTransaction(command);

                transaccion.Commit();

            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("EmpleadoDal", "Insertar", string.Format("{0} Error: {1} ", 
                    DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("EmpleadoDal", "Insertar", string.Format("{0} Error: {1}", 
                    DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
            Operaciones.WriteLogsDebug("EmpleadoDal", "Insertar", string.Format("{0} Info: {1}",
                DateTime.Now.ToString(), 
                "Termino de ejecutar  el metodo acceso a datos para insertar empleado"));
        }
     
        /// <summary>
        /// Metodo para obtener  un empleado
        /// </summary>
        /// <param name="id">Identificado del empleado </param>
        /// <returns>Empleado</returns>
        public static Empleado Obtener(Guid id)
        {
            Empleado empleado = null;
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = @"SELECT IdPersona,FechaContratacion, Eliminado FROM EMPLEADOS WHERE IdPersona=@id and Eliminado=0";
            try
            {
                cmd = OperacionesSql.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@id", id);
                dr = OperacionesSql.ExecuteDataReaderCommand(cmd);
                empleado = PersonaDal.ObtenerEmpleado(id);
                 while (dr.Read())
                {
                    empleado.FechaContratacion = dr.GetDateTime(1);
                    empleado.Eliminado = dr.GetBoolean(2);
                }

            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("EmpleadoDal", "Obtenet", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("EmpleadoDal", "Obtenet", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return empleado;
        }

        /// <summary>
        /// Método para actulizar a un empleado
        /// </summary>
        /// <param name="empleado"></param>
        public static void Actualizar(Empleado empleado)
        {
            Operaciones.WriteLogsDebug("EmpleadoDal", "Actualizar", string.Format("{0} Info: {1}", DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para eliminar un Persona"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Empleados SET FechaContratacion=@fecha
                                    WHERE IdPersona=@idPersona";
            try
            {

                command = OperacionesSql.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@fecha", empleado.FechaContratacion);
                command.Parameters.AddWithValue("@idPersona", empleado.IdPersona);

                //Actualizo a la persona
                PersonaDal.Actualizar(empleado as Persona);

                OperacionesSql.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("EmpleadoDal", "Actualizar", string.Format("{0} Error: {1}", DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("EmpleadoDal", "Actualizar", string.Format("{0} Error: {1}", DateTime.Now.ToString(),  ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("EmpleadoDal", "Actualizar", string.Format("{0}  Info: {1}", DateTime.Now.ToString(),  "Termino de ejecutar  el metodo acceso a datos para Eliminar un Cliente"));

        }

        /// <summary>
        /// Método para eliminar a un empleado
        /// </summary>
        /// <param name="empleado"></param>
        public static void Eliminar(Guid idEmpleado)
        {
            Operaciones.WriteLogsDebug("EmpleadoDal", "Actualizar", string.Format("{0} Info: {1}", DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para eliminar un Persona"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Empleados SET Eliminado=1
                                    WHERE IdPersona=@id";
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
                command.Parameters.AddWithValue("@id", idEmpleado);
              
                //Elimino a la persona
                PersonaDal.EliminarConTransaccion(idEmpleado, transaccion, conexion);

                OperacionesSql.ExecuteBasicCommandWithTransaction(command);

                transaccion.Commit();
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("EmpleadoDal", "Actualizar", string.Format("{0} Error: {1}", DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("EmpleadoDal", "Actualizar", string.Format("{0} Error: {1}", DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("EmpleadoDal", "Actualizar", string.Format("{0}  Info: {1}", DateTime.Now.ToString(), "Termino de ejecutar  el metodo acceso a datos para Eliminar un Cliente"));

        }



    }
}
