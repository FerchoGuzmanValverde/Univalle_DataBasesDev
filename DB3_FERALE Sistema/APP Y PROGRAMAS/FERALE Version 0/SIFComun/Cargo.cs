using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferale.SistemaDeInformacionApp.SIFComun
{
    /// <summary>
    /// Clase para crear objetos de cargo
    /// </summary>
    public class Cargo
    {
        #region Propiedades

        /// <summary>
        /// Identificador del cargo
        /// </summary>
        public byte IdCargo { get; set; }
        /// <summary>
        /// Nombre del Cargo
        /// </summary>
        public string NombreCargo { get; set; }

        #endregion
    }
}
