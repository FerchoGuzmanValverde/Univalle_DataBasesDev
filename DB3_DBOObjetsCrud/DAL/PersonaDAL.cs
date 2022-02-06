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

        public PersonaDAL()
        {

        }

        public PersonaDAL(Persona p)
        {
            this.p = p;
        }

        public void Insert()
        {
            try
            {
                db = Db4oFactory.OpenFile(Config.pathDBOO);
                //Insertamos
                db.Store(this.p);
            }
            catch(Exception ex)
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
                Persona delete = (Persona)people.Next();
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

        public void Update(Persona update)
        {
            try
            {
                db = Db4oFactory.OpenFile(Config.pathDBOO);
                IObjectSet people = db.QueryByExample(this.p);
                Persona found = (Persona)people.Next();
                found.Nombres = update.Nombres;
                found.Apellidos = update.Apellidos;
                found.FechaNacimiento = update.FechaNacimiento;
                db.Store(found);
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
                    if (item.Ci==ci)
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
                foreach (Persona item in people)
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

        public List<string> Select()
        {
            List<string> res = new List<string>();
            try
            {
                List<Persona> people = SelectAll();
                var query = from per in people
                            orderby per.Apellidos
                            select per;
                foreach (var item in query)
                {
                    res.Add(item.VerInfo());
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return res;
        }

        public List<string> Iniciales(string inicial)
        {
            List<string> res = new List<string>();
            try
            {
                List<Persona> people = SelectAll();
                var query = from per in people
                            where per.Apellidos.StartsWith(inicial)
                            orderby per.Apellidos
                            select per;
                foreach (var item in query)
                {
                    res.Add(item.VerInfo());
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return res;
        }
        public List<string> Grupos(string inicial)
        {
            List<string> res = new List<string>();
            try
            {
                List<Persona> people = SelectAll();
                var query = from per in people
                            group per by per.Apellidos;
                            
                foreach (var item in query)
                {
                    res.Add(item.Key);
                    foreach (var item1 in item)
                    {
                        res.Add(item1.Nombres+item1.Apellidos);
                    }
                    
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return res;
        }
    }
}
