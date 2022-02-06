using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferale.SistemaDeInformacionApp.SIFComun
{
    /// <summary>
    /// Clase para crear objetos de Telefono
    /// </summary>
    public class Telefono
    {
        #region Propiedades

        /// <summary>
        /// Identificador del telefono
        /// </summary>
        public int IdTelefono { get; set; }
        /// <summary>
        /// Numero de telefono de la persona
        /// </summary>
        public string NroTelefono { get; set; }
        /// <summary>
        /// Persona a la que le pertenece el telefono
        /// </summary>
        public Persona Persona { get; set; }

        #endregion
    }
}
