using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferale.Administracion.SistemaDeInformacionApp.Comun
{
    /// <summary>
    /// Clase de la relacion entra Capacitacion y el Capacitador
    /// </summary>
    public class CapacitacionCapacitador
    {
        #region propiedades
        /// <summary>
        /// Capacitacion que se expuso
        /// </summary>
        public Capacitacion Capacitacion { get; set; }
        /// <summary>
        /// Capacitador que brindo la capacitacion
        /// </summary>
        public Capacitador Capacitador { get; set; }
        /// <summary>
        /// Tema de la capacitacion
        /// </summary>
        public string TemaExpuesto { get; set; }
        #endregion
    }
}
