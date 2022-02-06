using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferale.Administracion.SistemaDeInformacionApp.Comun
{
    /// <summary>
    /// Clase para crear objetos de Fruta
    /// </summary>
    public class Fruta:Producto
    {
        #region propiedades
        /// <summary>
        /// Nro de Fruta
        /// </summary>
        public byte Fruta { get; set; }
        /// <summary>
        /// Peso del producto Fruta
        /// </summary>
        public double Peso { get; set; }
        /// <summary>
        /// tipo de envase del producto Fruta
        /// </summary>
        public string TipoEnvase { get; set; }
        #endregion
    }
}
