using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferale.SistemaDeInformacionApp.SIFComun
{
    /// <summary>
    /// Clase para crear objetos de provincia
    /// </summary>
    public class Provincia
    {
        #region Propiedades

        /// <summary>
        /// Identificador de la Provincia
        /// </summary>
        public int IdProvincia { get; set; }
        /// <summary>
        /// Nombre de la provincia
        /// </summary>
        public string NombreProvincia { get; set; }
        /// <summary>
        /// Ciudad a la que pertenece la provincia
        /// </summary>
        public Ciudad Ciudad { get; set; }

        #endregion
    }
}
