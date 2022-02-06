using Common;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EstudianteDAL
    {
        Estudiante estudiante;
        public EstudianteDAL()
        {

        }
        public EstudianteDAL(Estudiante estudiante)
        {
            this.estudiante = estudiante;
        }

        public void Insert()
        {
            string query = @"INSERT INTO ESTUDIANTE (CARRERA, PERSONA) VALUES(:CARRERA, PERSONA_T(:CI,:NOMBRE,:APELLIDO1,:APELLIDO2,:FECHA))";
            try
            {
                OracleCommand cmd = Methods.CreateBasicCommand(query);
                OracleParameter[] array = new OracleParameter[] {
                    new OracleParameter(":CARRERA", estudiante.Carrera),
                    new OracleParameter(":CI", estudiante.Persona.Ci),
                    new OracleParameter(":NOMBRE", estudiante.Persona.Nombres),
                    new OracleParameter(":APELLIDO1", estudiante.Persona.PrimerApellido),
                    new OracleParameter(":APELLIDO2", estudiante.Persona.SegundoApellido),
                    new OracleParameter(":FECHA", estudiante.Persona.FechaNacimiento)
                };
                cmd.Parameters.AddRange(array);
                Methods.ExecuteBasicCommand(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Select()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT E.CARRERA, E.PERSONA.CI AS CI, E.PERSONA.NOMBRE AS NOMBRE, E.PERSONA.APELLIDOPATERNO AS APELLIDO     FROM ESTUDIANTE E";

            try
            {
                OracleCommand cmd = Methods.CreateBasicCommand(query);
                dt = Methods.ExecuteDataTableCommand(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        public Estudiante GetEstudiante(int ID)
        {
            Estudiante estudiante = null;

            string query = @"SELECT E.IDESTUDIANTE, E.CARRERA, E.PERSONA.CI, E.PERSONA.NOMBRE, E.PERSONA.APELLIDOPATERNO, E.PERSONA.APELLIDOMATERNO, E.PERSONA.FECHANACIMIENTO, E.PERSONA.ufcInformacion AS info FROM ESTUDIANTE E WHERE E.IDESTUDIANTE = :ID";

            OracleDataReader dr = null;
            OracleCommand cmd = null;

            try
            {
                cmd = Methods.CreateBasicCommand(query);
                OracleParameter[] array = new OracleParameter[] {
                    new OracleParameter(":ID", ID)
                };
                cmd.Parameters.AddRange(array);
                dr = Methods.ExecuteDataReaderCommand(cmd);

                while (dr.Read())
                {
                    estudiante = new Estudiante(int.Parse(dr[0].ToString()), dr[1].ToString(), new Persona(dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), DateTime.Parse(dr[6].ToString())));
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
                dr.Close();
            }

            return estudiante;
        }

        public void Update()
        {
            string query = @"UPDATE ESTUDIANTE E SET E.CARRERA = :CARRERA, E.PERSONA = PERSONA_T(:CI,:NOMBRE,:APELLIDO1,:APELLIDO2,:FECHA)
                            WHERE E.IDESTUDIANTE = :ID";
            OracleCommand cmd = null;
            try
            {
                cmd = Methods.CreateBasicCommand(query);

                OracleParameter[] array = new OracleParameter[] {
                    new OracleParameter(":ID", estudiante.IdEstudiante),
                    new OracleParameter(":CARRERA", estudiante.Carrera),
                    new OracleParameter(":CI", estudiante.Persona.Ci),
                    new OracleParameter(":NOMBRE", estudiante.Persona.Nombres),
                    new OracleParameter(":APELLIDO1", estudiante.Persona.PrimerApellido),
                    new OracleParameter(":APELLIDO2", estudiante.Persona.SegundoApellido),
                    new OracleParameter(":FECHA", estudiante.Persona.FechaNacimiento)
                };
                cmd.Parameters.AddRange(array);

                Methods.ExecuteBasicCommand(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void HardDelete()
        {
            string query = @"DELETE FROM ESTUDIANTE WHERE IDESTUDIANTE = :ID";
            OracleCommand cmd = null;
            try
            {
                cmd = Methods.CreateBasicCommand(query);

                OracleParameter[] array = new OracleParameter[] {
                    new OracleParameter(":ID", estudiante.IdEstudiante)
                };
                cmd.Parameters.AddRange(array);

                Methods.ExecuteBasicCommand(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
