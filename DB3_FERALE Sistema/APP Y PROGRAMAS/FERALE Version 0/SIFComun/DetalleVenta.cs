using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferale.SistemaDeInformacionApp.SIFComun
{
    /// <summary>
    /// Clase para crear objetos de detalle venta
    /// </summary>
    public class DetalleVenta
    {
        #region Propiedades

        /// <summary>
        /// Venta del detalle
        /// </summary>
        public Venta Venta { get; set; }
        /// <summary>
        /// Producto del detalle
        /// </summary>
        public Producto Producto { get; set; }
        /// <summary>
        /// Precio unitario por producto al momento de la venta
        /// </summary>
        public byte PrecioUnitario { get; set; }
        /// <summary>
        /// Cantidad de unidades del producto que estan en la venta
        /// </summary>
        public int cantidad { get; set; }

        #endregion
    }
}
