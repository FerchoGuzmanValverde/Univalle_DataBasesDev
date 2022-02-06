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
        
        public string CI { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public byte Estado { get; set; }

        #endregion

        #region Constructores

        /// <summary>
        /// Insert
        /// </summary>
        /// <param name="ci"></param>
        /// <param name="nombres"></param>
        /// <param name="apellidos"></param>
        /// <param name="fecha"></param>
        public Persona(string ci, string nombres, string apellidos, DateTime fecha)
        {
            this.CI = ci;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.FechaNacimiento = fecha;
            this.Estado = 1;
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="CI"></param>
        public Persona(string CI)
        {
            this.CI = CI;
        }

        public Persona()
        {

        }

        #endregion

        #region Metodos de la clase

        public string VerInfo()
        {
            return this.CI + " " + this.Nombres + " " + this.Apellidos;
        }

        #endregion
    }
}
