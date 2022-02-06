using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using DAL;
using System.Data;

namespace BRL
{
    public class FiguraBRL
    {
        Figura figura;
        FiguraDAL dal;

        #region Constructores
        public FiguraBRL(Figura figura)
        {
            this.figura = figura;
            dal = new FiguraDAL(this.figura);
        }
        public FiguraBRL()
        {
            dal = new FiguraDAL();
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

        public Figura GetFigura(int id)
        {
            return dal.GetFigura(id);
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
