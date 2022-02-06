using Ferale.SistemaDeInformacionApp.SIFComun;
using System;
using System.Data.SqlClient;

namespace Ferale.SistemaDeInformacionApp.EmpleadoDal
{
    /// <summary>
    /// Clase Empleado Dal que sirve para interactuar con la base de datos
    /// </summary>
    public class EmpleadoDal
    {
        /// <summary>
        /// Inserta un Empleado a la base de datos 
        /// </summary>
        /// <param name="empleado"></param>
        public static void Insertar(Empleado empleado)
        {
            Operaciones.WriteLogsDebug("EmpleadoDal", "Insertar", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para crear un empleado"));

            SqlCommand command = null;

            //Consulta para insertar clientes
            string queryString = @"INSERT INTO Empleado(idEmpleado, fechaNacimiento, sexo, nroCuentaBancaria, idCargo) 
                                    VALUES(@idEmpleado, @fechaNacimiento, @sexo, @nroCuentaBancaria, @idCargo)";
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

                //Iserto a la persona
                PersonaDal.InsertarConTransaccion(empleado as Persona, transaccion, conexion);

                //Inserto al empleado
                command = OperacionesSql.CreateBasicCommandWithTransaction(queryString, transaccion, conexion);
                command.Parameters.AddWithValue("@idEmpleado", OperacionesSql.GetActIdTable("Persona"));
                command.Parameters.AddWithValue("@fechaNacimiento", empleado.FechaNacimiento);
                command.Parameters.AddWithValue("@sexo", empleado.Sexo);
                command.Parameters.AddWithValue("@nroCuentaBancaria", empleado.NroCuentaBancaria);
                command.Parameters.AddWithValue("@idCargo", empleado.Cargo.IdCargo);
                OperacionesSql.ExecuteBasicCommandWithTransaction(command);

                transaccion.Commit();

            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("EmpleadoDal", "Insertar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("EmpleadoDal", "Insertar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
            Operaciones.WriteLogsDebug("EmpleadoDal", "Insertar", string.Format("{0} {1} Info: {2}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "Termino de ejecutar  el metodo acceso a datos para insertar empleado"));
        }

        /// <summary>
        /// Actualiza Empleado de la base de datos
        /// </summary>
        /// <param name="Empleado"></param>
        public static void Actualizar(Empleado empleado)
        {
            Operaciones.WriteLogsDebug("EmpleadoDal", "Actualizar", string.Format("{0} Info: {1}", DateTime.Now.ToLongDateString(), "Empezando a ejecutar el metodo acceso a datos para actualizar un Empleado"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Empleado SET fechaNacimiento=@fechaNacimiento, sexo=@sexo, nroCuentaBancaria=@nroCuentaBancaria, idCargo=@idCargo
                                    WHERE idEmpleado=@idEmpleado";

            try
            {

                //Iserto a la persona
                PersonaDal.Actualizar(empleado as Persona, empleado.IdEmpleado);

                command = OperacionesSql.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@idEmpleado", empleado.IdEmpleado);
                command.Parameters.AddWithValue("@fechaNacimiento", empleado.FechaNacimiento);
                command.Parameters.AddWithValue("@sexo", empleado.Sexo);
                command.Parameters.AddWithValue("@nroCuentaBancaria", empleado.NroCuentaBancaria);
                command.Parameters.AddWithValue("@idCargo", empleado.Cargo.IdCargo);
                OperacionesSql.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("EmpleadoDal", "Actualizar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("EmpleadoDal", "Actualizar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("EmpleadoDal", "Actualizar", string.Format("{0} {1} Info: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "Termino de ejecutar  el metodo acceso a datos para Actualizar un Empleado"));

        }

        /// <summary>
        /// Eliminar un empleado de la base de datos
        /// </summary>
        /// <param name="id"></param>
        public static void Eliminar(int id)
        {
            Operaciones.WriteLogsDebug("EmpleadoDal", "Eliminar", string.Format("{0} Info: {1}", DateTime.Now.ToLongDateString(), "Empezando a ejecutar el metodo acceso a datos para eliminar un Empleado"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Persona SET estado=0
                                    WHERE idPersona = @idEmpleado";
            try
            {
                command = OperacionesSql.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@idEmpleado", id);
                OperacionesSql.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                Operaciones.WriteLogsRelease("EmpleadoDal", "Eliminar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("EmpleadoDal", "Eliminar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Operaciones.WriteLogsDebug("EmpleadoDal", "Eliminar", string.Format("{0} {1} Info: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "Termino de ejecutar  el metodo acceso a datos para Eliminar un Empleado"));
        }


        /// <summary>
        /// Obtener un Empleado
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Empleado Obtener(int id)
        {
            Empleado empleado = new Empleado();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = @"SELECT * FROM Empleado WHERE idEmpleado=@id";
            try
            {
                empleado = PersonaDal.ObtenerEmpleado(id);
                cmd = OperacionesSql.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@id", id);
                dr = OperacionesSql.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    empleado.FechaNacimiento = dr.GetDateTime(1);
                    empleado.Sexo = dr.GetByte(2);
                    empleado.NroCuentaBancaria = dr.GetString(3);
                    empleado.Cargo = CargoDal.Obtener(dr.GetByte(4));
                }
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("EmpleadoDal", "Obtenet(Get)", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return empleado;
        }
    }
}
