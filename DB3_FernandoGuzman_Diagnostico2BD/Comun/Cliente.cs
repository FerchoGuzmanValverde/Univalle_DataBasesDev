using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Comun
{
    /// <summary>
    /// Clase para crear objetos de cliente
    /// </summary>
    public class Cliente
    {
        /// <summary>
        /// Identificador del cliente
        /// </summary>
        public int IdCliente { get; set; }
        /// <summary>
        /// Nombre del cliente
        /// </summary>
        public string NombreCliente { get; set; }
        /// <summary>
        /// Direccion del cliente
        /// </summary>
        public string Direccion { get; set; }
        /// <summary>
        /// Lista de compras del cliente
        /// </summary>
        public List<Compra> Compras { get; set; }
    }
}
