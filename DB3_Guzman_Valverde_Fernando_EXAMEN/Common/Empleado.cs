using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Empleado
    {
        #region Atributos

        public int IdEmpleado { get; set; }
        public string Salario { get; set; }
        public Persona Persona { get; set; }

        #endregion
        #region Constructores

        public Empleado()
        {

        }
        /// <summary>
        /// Constructor para el INSERT
        /// </summary>
        /// <param name="salario"></param>
        /// <param name="persona"></param>
        public Empleado(string salario, Persona persona)
        {
            this.Salario = salario;
            this.Persona = persona;
        }
        /// <summary>
        /// Constructor para el GET
        /// </summary>
        /// <param name="id"></param>
        /// <param name="salario"></param>
        /// <param name="persona"></param>
        public Empleado(int id, string salario, Persona persona)
        {
            this.IdEmpleado = id;
            this.Salario = salario;
            this.Persona = persona;
        }

        #endregion
    }
}
