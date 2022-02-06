using Common;
using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LecturasDAL
    {
        IObjectContainer db;
        Lectura lecture;

        #region Constructores

        public LecturasDAL()
        {
        }

        public LecturasDAL(Lectura l)
        {
            this.lecture = l;
        }

        #endregion
        #region Metodos CRUD

        public void Insert()
        {
            try
            {
                db = Db4oFactory.OpenFile(Config.pathDBOO);

                //Insertamos
                db.Store(this.lecture);
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

                IObjectSet lecture = db.QueryByExample(this.lecture);
                Lectura delete = (Lectura)lecture.Next();
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

        public Lectura GetLectureByName(string nombreLectura)
        {
            Lectura res = null;

            try
            {
                db = Db4oFactory.OpenFile(Config.pathDBOO);
                IObjectSet lecture = db.QueryByExample(new Lectura(nombreLectura));
                foreach (Lectura item in lecture)
                {
                    if (item.NombreLectura == nombreLectura)
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

        public List<Lectura> SelectAll()
        {
            List<Lectura> result = new List<Lectura>();

            try
            {
                db = Db4oFactory.OpenFile(Config.pathDBOO);
                IObjectSet lectures = db.QueryByExample(typeof(Lectura));

                foreach (Lectura item in lectures)
                {
                    result.Add(item);
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

            return result;
        }

        #endregion
    }
}
