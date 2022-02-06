using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Db4objects.Db4o;

namespace DAL
{
    public class PersonaDAL
    {

        IObjectContainer db;
        Persona p;

        #region Constructores
        public PersonaDAL()
        {

        }

        public PersonaDAL(Persona p)
        {
            this.p = p;
        }
        #endregion

        public void Insert()
        {
            try
            {
                db = Db4oFactory.OpenFile(Config.pathDBOO);
                //Insertamos
                db.Store(this.p);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.Close();
            }
        }

        public void Delete()
        {
            try
            {
                db = Db4oFactory.OpenFile(Config.pathDBOO);
                IObjectSet people = db.QueryByExample(this.p);
                Persona delete = (Persona)people.Next();//se captura la persona que desa eliminar
                db.Delete(delete);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.Close();
            }
        }

        public Persona GetPeopleByCi(string ci)
        {
            Persona res = null;
            try
            {
                db = Db4oFactory.OpenFile(Config.pathDBOO);
                IObjectSet people = db.QueryByExample(new Persona(ci));
                foreach (Persona item in people)
                {
                    if(item.Ci==ci)
                    {
                        res = item;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.Close();
            }
            return res;
        }

        public List<Persona> SelectAll()
        {
            List<Persona> res = new List<Persona>();
            try
            {
                db = Db4oFactory.OpenFile(Config.pathDBOO);
                IObjectSet people = db.QueryByExample(typeof(Persona));
                foreach(Persona item in people)
                {
                    res.Add(item);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.Close();
            }
            return res;
        }
    }
}
