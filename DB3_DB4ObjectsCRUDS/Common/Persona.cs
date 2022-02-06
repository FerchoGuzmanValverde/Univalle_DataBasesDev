using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Persona
    {
        #region Propiedades de la clase
        public string Ci { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public byte Estado { get; set; }
        #endregion

        #region Constructores
        /// <summary>
        /// Insert
        /// </summary>
        /// <param name="Ci"></param>
        /// <param name="Nombres"></param>
        /// <param name="Apellidos"></param>
        /// <param name="FechaNacimiento"></param>
        public Persona(string Ci, string Nombres, string Apellidos, DateTime FechaNacimiento)
        {
            this.Ci = Ci;
            this.Nombres = Nombres;
            this.Apellidos = Apellidos;
            this.FechaNacimiento = FechaNacimiento;
            this.Estado = 1;
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="Ci"></param>
        public Persona(string Ci)
        {
            this.Ci = Ci;
        }

        public Persona()
        {

        }

        #endregion



        #region Métodos de la clase
        public string VerInfo()
        {
            return this.Ci + " " + this.Nombres + " " + this.Apellidos;
        }
        #endregion
    }
}
