using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Comun
{
    /// <summary>
    /// Clase para crear objetos de Compra
    /// </summary>
    public class Compra
    {
        /// <summary>
        /// Identificador de la compra
        /// </summary>
        public int IdCompra { get; set; }
        /// <summary>
        /// Identificador del cliente que realizo la comrpa
        /// </summary>
        public int IdCliente { get; set; }
        /// <summary>
        /// Total del cliente
        /// </summary>
        public int TotalCompra { get; set; }
    }
}
