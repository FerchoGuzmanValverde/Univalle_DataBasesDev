using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Figura
    {
        #region Atributos
        public int IdFigura { get; set; }
        public string Color { get; set; }
        public Regtangulo Rectangulo { get; set; }
        #endregion
        #region Constructores
        public Figura()
        {

        }
        /// <summary>
        /// Constructor para el Delete
        /// </summary>
        /// <param name="id"></param>
        public Figura(int id)
        {
            IdFigura = id;
        }
        /// <summary>
        /// Constructor para el INSERT
        /// </summary>
        /// <param name="color"></param>
        /// <param name="rec"></param>
        public Figura(string color, Regtangulo rec)
        {
            Color = color;
            Rectangulo = rec;
        }
        /// <summary>
        /// Constructor para el GET
        /// </summary>
        /// <param name="id"></param>
        /// <param name="color"></param>
        /// <param name="rec"></param>
        public Figura(int id, string color, Regtangulo rec)
        {
            IdFigura = id;
            Color = color;
            Rectangulo = rec;
        }
        #endregion
    }
}
