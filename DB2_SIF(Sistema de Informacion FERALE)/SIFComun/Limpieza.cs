using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferale.Administracion.SistemaDeInformacionApp.Comun
{
    /// <summary>
    /// Clase para crear objetos de limpieza
    /// </summary>
    public class Limpieza
    {
        #region propiedades
        /// <summary>
        /// Identificador de la limpieza
        /// </summary>
        public byte IdLimpieza { get; set; }
        /// <summary>
        /// Descripcion de la limpieza
        /// </summary>
        public string Descripcion { get; set; }
        /// <summary>
        /// Tipo de la limpieza
        /// </summary>
        public byte TipoLimpieza { get; set; }
        /// <summary>
        /// Estado para el borrado logico de la limpieza
        /// </summary>
        public byte Estado { get; set; }
        #endregion
    }
}
