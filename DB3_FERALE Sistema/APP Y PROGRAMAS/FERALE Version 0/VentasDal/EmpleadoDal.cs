using Ferale.SistemaDeInformacionApp.ClienteDal;
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
                empleado = PersonaEmpleadoDal.ObtenerEmpleado(id);
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
