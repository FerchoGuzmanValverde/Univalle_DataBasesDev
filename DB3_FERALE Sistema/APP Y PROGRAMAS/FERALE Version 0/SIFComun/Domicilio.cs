using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferale.SistemaDeInformacionApp.SIFComun
{
    /// <summary>
    /// Clase para crear objetos de domicilio
    /// </summary>
    public class Domicilio
    {
        #region Propiedades

        /// <summary>
        /// Identificador del domicilio
        /// </summary>
        public int IdDomicilio { get; set; }
        /// <summary>
        /// Descripcion de la direccion del domicilio
        /// </summary>
        public string Descripcion { get; set; }
        /// <summary>
        /// Estado para el borrado logico del domicilio
        /// </summary>
        public byte Estado { get; set; }

        #endregion
    }
}
