using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Db4objects.Db4o;

namespace DAL
{
    public class Config
    {
        //cadena de conexion a la BDOO -- ruta de acceso al archivo
        public static string pathDBOO = Path.GetDirectoryName(Directory.GetCurrentDirectory())+@"\DBOOPeople.db4o";//nombre de la base de datos

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
                    db.Close();
            }
        }
        


    }
}
