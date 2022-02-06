using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Persona
    {
        #region Atributos

        public string Ci { get; set; }
        public string Nombres { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Info { get; set; }

        #endregion
        #region Constructores

        public Persona()
        {

        }
        /// <summary>
        /// Constructor para el INSERT
        /// </summary>
        /// <param name="ci"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido1"></param>
        /// <param name="apellido2"></param>
        /// <param name="fecha"></param>
        public Persona(string ci, string nombre, string apellido1, string apellido2, DateTime fecha)
        {
            this.Ci = ci;
            this.Nombres = nombre;
            this.PrimerApellido = apellido1;
            this.SegundoApellido = apellido2;
            this.FechaNacimiento = fecha;
        }
        /// <summary>
        /// Constructor para el GET
        /// </summary>
        /// <param name="ci"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido1"></param>
        /// <param name="apellido2"></param>
        /// <param name="fecha"></param>
        /// <param name="info"></param>
        public Persona(string ci, string nombre, string apellido1, string apellido2, DateTime fecha, string info)
        {
            this.Ci = ci;
            this.Nombres = nombre;
            this.PrimerApellido = apellido1;
            this.SegundoApellido = apellido2;
            this.FechaNacimiento = fecha;
            this.Info = info;
        }

        #endregion
    }
}
