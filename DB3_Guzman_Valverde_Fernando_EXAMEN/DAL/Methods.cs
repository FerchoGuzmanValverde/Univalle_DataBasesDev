using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Methods
    {
        static string connectionString = "DATA SOURCE=xe; PASSWORD=12345; USER ID=BDDOREXAMEN";

        public static OracleCommand CreateBasicCommand(string query)
        {
            OracleCommand cmd = new OracleCommand(query);
            OracleConnection connection = new OracleConnection(connectionString);
            cmd.Connection = connection;
            return cmd;
        }

        public static void ExecuteBasicCommand(OracleCommand cmd)
        {
            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }

        public static DataTable ExecuteDataTableCommand(OracleCommand cmd)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection.Open();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return dt;
        }

        public static OracleDataReader ExecuteDataReaderCommand(OracleCommand cmd)
        {
            OracleDataReader dr = null;
            try
            {
                cmd.Connection.Open();
                dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dr;
        }
    }
}
