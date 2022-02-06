using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Spatial;

namespace Ferale.Administracion.SistemaDeInformacionApp.Comun
{
    /// <summary>
    /// Clase parea crear objetos Domicilio
    /// </summary>
    public class Domicilio
    {
        #region propiedades
        /// <summary>
        /// Identificador de domicilio
        /// </summary>
        public int IdDomicilio { get; set; }
        /// <summary>
        /// Ubicacion del domicilio, latitud longitud
        /// </summary>
        public DbGeography Ubicacion { get; set; }
        /// <summary>
        /// Descripcion del domicilio
        /// </summary>
        public string descripcion { get; set; }
        /// <summary>
        /// Estado para el borrado logico del domicilio
        /// </summary>
        public byte Estado { get; set; }
        #endregion
    }
}
