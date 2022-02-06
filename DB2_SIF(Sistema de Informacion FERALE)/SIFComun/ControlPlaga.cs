using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferale.Administracion.SistemaDeInformacionApp.Comun
{
    /// <summary>
    /// Clase que relaciona plaga con plaguicida
    /// </summary>
    public class ControlPlaga
    {
        #region propiedades
        /// <summary>
        /// plaga en el control de plagas
        /// </summary>
        public Plaga Plaga { get; set; }
        /// <summary>
        /// Plaguicida que se usa en el control de plagas
        /// </summary>
        public Plaguicida Plaguicida { get; set; }
        #endregion
    }
}
