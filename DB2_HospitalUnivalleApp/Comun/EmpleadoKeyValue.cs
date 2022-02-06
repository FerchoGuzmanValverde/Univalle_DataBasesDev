using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.Comun
{
    /// <summary>
    /// Clase que sirve para crear objetos con el identificar y su valor
    /// </summary>
    public class EmpleadoKeyValue
    {
        /// <summary>
        /// Identificador de la persona
        /// </summary>
        public Guid IdPersona { get; set; }

        /// <summary>
        /// NombreCompleto que sirve para guardar el nombre completo de la persona
        /// </summary>
        public string NombreCompleto { get; set; }
    }
}
