using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Config
    {
        //Cadena de Conexion a la BDOO -- ruta de acceso al archivo
        public static string pathDBOO = Path.GetDirectoryName(Directory.GetCurrentDirectory()) + @"\DBOOClima.db4o";

        public static void CreateDBOO()
        {
            IObjectContainer db = null;

            try
            {
                db = Db4oFactory.OpenFile(pathDBOO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (db != null)
                {
                    db.Close();
                }
            }
        }

    }
}
