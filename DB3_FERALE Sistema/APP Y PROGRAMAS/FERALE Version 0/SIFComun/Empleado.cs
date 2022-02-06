using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferale.SistemaDeInformacionApp.SIFComun
{
    /// <summary>
    /// Clase para crear objetos de empleado
    /// </summary>
    public class Empleado:Persona
    {
        #region Propiedades

        /// <summary>
        /// Identificador del Empleado
        /// </summary>
        public int IdEmpleado { get; set; }
        /// <summary>
        /// Fecha de nacimiento del empleado
        /// </summary>
        public DateTime FechaNacimiento { get; set; }
        /// <summary>
        /// Sexo del empleado: 0 = hombre, 1 = mujer
        /// </summary>
        public byte Sexo { get; set; }
        /// <summary>
        /// Numero de Cuenta Bancaria del empleado
        /// </summary>
        public string NroCuentaBancaria { get; set; }
        /// <summary>
        /// Cargo del empleado
        /// </summary>
        public Cargo Cargo { get; set; }

        #endregion
    }
}
