using Common;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRL
{
    public class EstudianteBRL
    {
        Estudiante figura;
        EstudianteDAL dal;

        #region Constructores
        public EstudianteBRL(Estudiante estudiante)
        {
            this.figura = estudiante;
            dal = new EstudianteDAL(this.figura);
        }
        public EstudianteBRL()
        {
            dal = new EstudianteDAL();
        }
        #endregion
        #region Metodos
        public void Insertar()
        {
            dal.Insert();
        }

        public DataTable SelectAll()
        {
            return dal.Select();
        }

        public Estudiante GetFigura(int id)
        {
            return dal.GetEstudiante(id);
        }
        public void Update()
        {
            dal.Update();
        }

        public void HardDelete()
        {
            dal.HardDelete();
        }
        #endregion
    }
}
