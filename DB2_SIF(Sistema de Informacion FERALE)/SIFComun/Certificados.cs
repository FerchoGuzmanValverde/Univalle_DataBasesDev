using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferale.Administracion.SistemaDeInformacionApp.Comun
{
    /// <summary>
    /// Clase para crear objetos de Certificados
    /// </summary>
    public class Certificados
    {
        #region propiedades
        /// <summary>
        /// Indentificador del certificado
        /// </summary>
        public int IdCertificado { get; set; }
        /// <summary>
        /// Descripcion del certificado
        /// </summary>
        public string Descripcion { get; set; }
        /// <summary>
        /// Cadena de la ubicacion del certificado
        /// </summary>
        public string ArchivoCertificado { get; set; }
        /// <summary>
        /// Capacitador al que le pertenece este certificado
        /// </summary>
        public Capacitador Capacitador { get; set; }
        /// <summary>
        /// Estado para el borrado logico de certificado
        /// </summary>
        public byte Estado { get; set; }
        #endregion
    }
}
