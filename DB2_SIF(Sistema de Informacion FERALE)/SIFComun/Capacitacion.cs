using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferale.Administracion.SistemaDeInformacionApp.Comun
{
    /// <summary>
    /// Clase para crear objetos de Capacitacion
    /// </summary>
    public class Capacitacion
    {
        #region propiedades
        /// <summary>
        /// Identificador de la Capacitacion
        /// </summary>
        public int IdCapacitacion { get; set; }
        /// <summary>
        /// Descripcion de la Capacitacion
        /// </summary>
        public string Descripcion { get; set; }
        /// <summary>
        /// Cadena de la ubicacion del archivo con el detalle de la Capacitacion
        /// </summary>
        public string ArchivoDetalle { get; set; }
        /// <summary>
        /// Estado para el borrado logico de la Capacitacion
        /// </summary>
        public byte Estado { get; set; }
        #endregion
    }
}
