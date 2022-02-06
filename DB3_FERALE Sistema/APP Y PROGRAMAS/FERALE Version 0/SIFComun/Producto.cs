using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferale.SistemaDeInformacionApp.SIFComun
{
    /// <summary>
    /// Clase para crear objetos de Producto
    /// </summary>
    public class Producto
    {
        #region Propiedades

        /// <summary>
        /// Identificador del producto
        /// </summary>
        public int IdProducto { get; set; }
        /// <summary>
        /// Nombre del producto
        /// </summary>
        public string NombreProducto { get; set; }
        /// <summary>
        /// Precio base del producto
        /// </summary>
        public byte PrecioBase { get; set; }
        /// <summary>
        /// Nombre de la variedad del producto.
        /// </summary>
        public string Variedad { get; set; }
        /// <summary>
        /// Area del producto: 0 = viveros, 1 = Comercializacion
        /// </summary>
        public byte AreaProducto { get; set; }
        /// <summary>
        /// Estado para el borrado logico del producto
        /// </summary>
        public byte Estado { get; set; }

        #endregion
    }
}
