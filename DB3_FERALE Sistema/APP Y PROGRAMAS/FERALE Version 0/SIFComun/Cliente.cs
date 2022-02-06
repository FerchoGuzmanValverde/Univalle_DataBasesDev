using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferale.SistemaDeInformacionApp.SIFComun
{
    /// <summary>
    /// Clase para crear objetos de cliente
    /// </summary>
    public class Cliente:Persona
    {
        #region Propiedades

        /// <summary>
        /// Identificador del Cliente
        /// </summary>
        public int IdCliente { get; set; }
        /// <summary>
        /// Razon social del cliente
        /// </summary>
        public string RazonSocial { get; set; }

        #endregion
    }
}
