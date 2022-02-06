using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Persona
    {
        #region Propiedades de la Clase
        public String Ci { get; set; }
        public String Nombres { get; set; }
        public String Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Byte Estado { get; set; }
        #endregion

        #region Contructores

        /// <summary>
        /// INSERT
        /// </summary>
        /// <param name="Ci"></param>
        /// <param name="Nombres"></param>
        /// <param name="Apellidos"></param>
        /// <param name="FechaNacimiento"></param>
        /// 
        public Persona(String Ci, String Nombres, String Apellidos, DateTime FechaNacimiento)
        {
            this.Ci = Ci;
            this.Nombres = Nombres;
            this.Apellidos = Apellidos;
            this.FechaNacimiento = FechaNacimiento;
            this.Estado = 1;
        }
        /// <summary>
        /// UPDATE
        /// </summary>
        /// <param name="Nombres"></param>
        /// <param name="Apellidos"></param>
        /// <param name="FechaNacimiento"></param>
        public Persona(String Nombres, String Apellidos, DateTime FechaNacimiento)
        {
            this.Nombres = Nombres;
            this.Apellidos = Apellidos;
            this.FechaNacimiento = FechaNacimiento;
        }

        public Persona()
        {

        }
        #endregion


        public Persona(string Ci)
        {
            this.Ci = Ci;
        }


        #region Metodos de Clase
        public string VerInfo()
        {
            return this.Ci + " " + this.Nombres + " " + this.Apellidos;
        }
        #endregion

    }
}
