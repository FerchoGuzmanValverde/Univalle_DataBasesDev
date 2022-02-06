using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferale.SistemaDeInformacionApp.SIFComun
{
    /// <summary>
    /// Clase para crear objetos de Ciudad
    /// </summary>
    public class Ciudad
    {
        #region Propiedades

        /// <summary>
        /// Nombre de la ciudad
        /// </summary>
        public string NombreCiudad { get; set; }
        /// <summary>
        /// Pais al que pertenece la ciudad
        /// </summary>
        public Pais Pais { get; set; }

        #endregion
    }
}
