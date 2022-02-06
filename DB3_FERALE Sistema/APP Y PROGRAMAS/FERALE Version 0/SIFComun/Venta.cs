using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferale.SistemaDeInformacionApp.SIFComun
{
    /// <summary>
    /// Clase para crear objetos de venta
    /// </summary>
    public class Venta
    {
        #region Propiedades

        /// <summary>
        /// Identificador de la venta
        /// </summary>
        public int IdVenta { get; set; }
        /// <summary>
        /// Fecha y Hora en la que se realizo la venta
        /// </summary>
        public DateTime FechaHoraVenta { get; set; }
        /// <summary>
        /// Monto total de la venta - incluido descuento
        /// </summary>
        public int MontoTotalFinal { get; set; }
        /// <summary>
        /// Descuento de la venta en porcentaje
        /// </summary>
        public byte Descuento { get; set; }
        /// <summary>
        /// Tipo de venta: 0 = Area Viveros, 1 = Area Comercializacion
        /// </summary>
        public byte TipoVenta { get; set; }
        /// <summary>
        /// Estado para el borrado logico de la venta
        /// </summary>
        public byte Estado { get; set; }
        /// <summary>
        /// Cliente que realizo la compra en la venta
        /// </summary>
        public Cliente Cliente { get; set; }
        /// <summary>
        /// Empleado que gestiono la venta
        /// </summary>
        public Empleado Empleado { get; set; }
        /// <summary>
        /// Lista de productos en la venta
        /// </summary>
        public List<DetalleVenta> Detalles { get; set; }

        #endregion
    }
}
