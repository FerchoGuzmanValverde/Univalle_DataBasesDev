using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferale.Administracion.SistemaDeInformacionApp.Comun
{
    /// <summary>
    /// Clase para crear objetos de empleado
    /// </summary>
    public class Empleado:Persona
    {
        #region propiedades
        /// <summary>
        /// Identificador del empleado
        /// </summary>
        public int IdEmpleado { get; set; }
        /// <summary>
        /// Fecha de nacimiento del empleado
        /// </summary>
        public DateTime FechaNacimiento { get; set; }
        /// <summary>
        /// Sexo del empleado 
        /// </summary>
        public byte Sexo { get; set; }
        /// <summary>
        /// Nro de cuenta Bancaria del empleado
        /// </summary>
        public string NroCuentaBancaria { get; set; }
        /// <summary>
        /// Tipo de empleado
        /// </summary>
        public byte TipoEmpleado { get; set; }
        #endregion
    }
}
