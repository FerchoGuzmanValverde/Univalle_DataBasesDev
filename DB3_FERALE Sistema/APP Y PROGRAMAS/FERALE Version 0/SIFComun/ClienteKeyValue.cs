using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferale.SistemaDeInformacionApp.SIFComun
{
    /// <summary>
    /// Clase que sirve para crear objetos e identificarlos por su valor
    /// </summary>
    public class ClienteKeyValue
    {
        /// <summary>
        /// Identificador de la persona
        /// </summary>
        public int IdPersona { get; set; }

        /// <summary>
        /// NombreCompleto que sirve para guardar el nombre completo de la persona
        /// </summary>
        public string NombreCompleto { get; set; }
    }
}
