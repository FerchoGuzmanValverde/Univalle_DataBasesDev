using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferale.Administracion.SistemaDeInformacionApp.Comun
{
    /// <summary>
    /// Clase para crear objetos Documento
    /// </summary>
    public class Documento
    {
        #region propiedades
        /// <summary>
        /// Identificador del documento
        /// </summary>
        public int IdDocumento { get; set; }
        /// <summary>
        /// Descripcion del documento
        /// </summary>
        public string Descripcion { get; set; }
        /// <summary>
        /// Cadena de la ubicacion del documento
        /// </summary>
        public string ArchivoDocumento { get; set; }
        /// <summary>
        /// Fecha de la expiracion del documento
        /// </summary>
        public DateTime FechaExpiracion { get; set; }
        /// <summary>
        /// Tipo de documento
        /// </summary>
        public byte TipoDocumento { get; set; }
        /// <summary>
        /// Estado para el borrado logico del documento
        /// </summary>
        public byte Estado { get; set; }
        #endregion
    }
}
