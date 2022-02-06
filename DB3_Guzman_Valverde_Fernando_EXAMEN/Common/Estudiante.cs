using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Estudiante
    {
        #region Atributos

        public int IdEstudiante { get; set; }
        public string Carrera { get; set; }
        public Persona Persona { get; set; }

        #endregion
        #region Constructores

        public Estudiante()
        {

        }
        /// <summary>
        /// Constructor para el INSERT
        /// </summary>
        /// <param name="carrera"></param>
        /// <param name="persona"></param>
        public Estudiante(string carrera, Persona persona)
        {
            this.Carrera = carrera;
            this.Persona = persona;
        }
        /// <summary>
        /// Constructor para el GET
        /// </summary>
        /// <param name="id"></param>
        /// <param name="carrera"></param>
        /// <param name="persona"></param>
        public Estudiante(int id, string carrera, Persona persona)
        {
            this.IdEstudiante = id;
            this.Carrera = carrera;
            this.Persona = persona;
        }

        #endregion
    }
}
