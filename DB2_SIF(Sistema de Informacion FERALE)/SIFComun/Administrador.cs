using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferale.Administracion.SistemaDeInformacionApp.Comun
{
    /// <summary>
    /// Esta clase sirve para crear objetos administrador
    /// </summary>
    public class Administrador:Empleado
    {
        #region propiedades
        /// <summary>
        /// identificador del administrador
        /// </summary>
        public int IdAdministrador { get; set; }
        /// <summary>
        /// profesion del administrador
        /// </summary>
        public string Profesion { get; set; }
        /// <summary>
        /// cargo del administrador
        /// </summary>
        public string Cargo { get; set; }
        #endregion
    }
}
