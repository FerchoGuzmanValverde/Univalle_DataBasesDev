using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferale.Administracion.SistemaDeInformacionApp.Comun
{
    /// <summary>
    /// Clase que relaciona a administrador con gasto
    /// </summary>
    public class Pago
    {
        #region propiedades
        /// <summary>
        /// Administrador que realizo el pago
        /// </summary>
        public Administrador Administrador { get; set; }
        /// <summary>
        /// Gasto que se pago
        /// </summary>
        public Gasto Gasto { get; set; }
        /// <summary>
        /// Monto que se pago
        /// </summary>
        public double Monto { get; set; }
        /// <summary>
        /// Tipo de pago que se realizo
        /// </summary>
        public byte TipoPago { get; set; }
        /// <summary>
        /// Fecha Hora en la que se realizo el pago
        /// </summary>
        public DateTime FechaHoraPago { get; set; }
        #endregion
    }
}
