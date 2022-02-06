using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferale.Administracion.SistemaDeInformacionApp.Comun
{
    /// <summary>
    /// Clase para crear objetos de calidad de fruta
    /// </summary>
    public class CalidadFruta
    {
        #region propiedades
        /// <summary>
        /// idenficador de la calidad
        /// </summary>
        public byte IdCalidad { get; set; }
        /// <summary>
        /// Calidad de fruta
        /// </summary>
        public byte Calidad { get; set; }
        /// <summary>
        /// Estado para el borrado logico de calidad
        /// </summary>
        public byte Estado { get; set; }
        #endregion
    }
}
