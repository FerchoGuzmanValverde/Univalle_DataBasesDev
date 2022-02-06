using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Regtangulo
    {
        #region Atributos
        public int Base { get; set; }
        public int Altura { get; set; }
        public int Area { get; set; }
        public int Perimetro { get; set; }
        #endregion
        #region Constructores
        public Regtangulo()
        {

        }
        /// <summary>
        /// Constructor para el INSERT
        /// </summary>
        /// <param name="baseR"></param>
        /// <param name="altura"></param>
        public Regtangulo(int baseR, int altura)
        {
            Base = baseR;
            Altura = altura;
        }
        /// <summary>
        /// Constructor para el GET
        /// </summary>
        /// <param name="baseR"></param>
        /// <param name="altura"></param>
        /// <param name="area"></param>
        /// <param name="perimetro"></param>
        public Regtangulo(int baseR, int altura, int area, int perimetro)
        {
            Base = baseR;
            Altura = altura;
            Area = area;
            Perimetro = perimetro;
        }
        #endregion
    }
}
