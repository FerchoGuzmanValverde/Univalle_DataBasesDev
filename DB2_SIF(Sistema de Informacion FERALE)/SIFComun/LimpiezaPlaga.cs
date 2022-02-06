using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferale.Administracion.SistemaDeInformacionApp.Comun
{
    /// <summary>
    /// Clase de la relacion entre plaguicida y limpieza
    /// </summary>
    public class LimpiezaPlaga
    {
        #region propiedades
        /// <summary>
        /// Plaguicida que se utilizo en la limpieza
        /// </summary>
        public Plaguicida Plaguicida { get; set; }
        /// <summary>
        /// Limpieza que se realizo
        /// </summary>
        public Limpieza Limpieza { get; set; }
        /// <summary>
        /// Cantidad usada del plaguicida
        /// </summary>
        public double CantidadPlaguicida { get; set; }
        #endregion
    }
}
