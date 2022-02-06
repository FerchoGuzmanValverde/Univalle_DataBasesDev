using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmpleadoDAL
    {
        /*Figura figura;
        public FiguraDAL()
        {

        }
        public FiguraDAL(Figura figura)
        {
            this.figura = figura;
        }

        public void Insert()
        {
            string query = @"INSERT INTO FIGURA (COLOR, RECTANGULO) VALUES(:COLOR, RECTAGULO_T(:BASE,:ALTURA))";
            try
            {
                OracleCommand cmd = Methods.CreateBasicCommand(query);
                OracleParameter[] array = new OracleParameter[] {
                    new OracleParameter(":COLOR", figura.Color),
                    new OracleParameter(":BASE", figura.Rectangulo.Base),
                    new OracleParameter(":ALTURA", figura.Rectangulo.Altura)
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
            string query = @"SELECT F.IDFIGURA, F.COLOR, F.RECTANGULO.BASE AS BASE, F.RECTANGULO.ufcArea() AS AREA FROM FIGURA F";

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

        public Figura GetFigura(int ID)
        {
            Figura figura = null;

            string query = @"SELECT F.IDFIGURA, F.COLOR, F.RECTANGULO.BASE, F.RECTANGULO.ALTURA, F.RECTANGULO.ufcArea() AS AREA, F.RECTANGULO.ufcPerimetro() AS PERIMETRO FROM FIGURA F WHERE F.IDFIGURA = :ID";

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
                    figura = new Figura(int.Parse(dr[0].ToString()), dr[1].ToString(), new Regtangulo(int.Parse(dr[2].ToString()), int.Parse(dr[3].ToString()), int.Parse(dr[4].ToString()), int.Parse(dr[5].ToString())));
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

            return figura;
        }

        public void Update()
        {
            string query = @"UPDATE FIGURA F SET F.COLOR = :COLOR, F.RECTANGULO = RECTAGULO_T(:BASE,:ALTURA)
                            WHERE F.IDFIGURA = :ID";
            OracleCommand cmd = null;
            try
            {
                cmd = Methods.CreateBasicCommand(query);

                OracleParameter[] array = new OracleParameter[] {
                    new OracleParameter(":COLOR", figura.Color),
                    new OracleParameter(":BASE", figura.Rectangulo.Base),
                    new OracleParameter(":ALTURA", figura.Rectangulo.Altura),
                    new OracleParameter(":ID", figura.IdFigura)
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
            string query = @"DELETE FROM FIGURA WHERE IDFIGURA = :ID";
            OracleCommand cmd = null;
            try
            {
                cmd = Methods.CreateBasicCommand(query);

                OracleParameter[] array = new OracleParameter[] {
                    new OracleParameter(":ID", figura.IdFigura)
                };
                cmd.Parameters.AddRange(array);

                Methods.ExecuteBasicCommand(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }*/
    }
}
