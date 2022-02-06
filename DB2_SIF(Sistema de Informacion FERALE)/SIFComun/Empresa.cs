using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferale.Administracion.SistemaDeInformacionApp.Comun
{
    /// <summary>
    /// Clase para crear objetos de  Empresa
    /// </summary>
    public class Empresa
    {
        #region propiedades
        /// <summary>
        /// Identificador de la empresa
        /// </summary>
        public int IdEmpresa { get; set; }
        /// <summary>
        /// Nombre de la empresa
        /// </summary>
        public string Nombre { get; set; }
        /// <summary>
        /// Tipo de la empresa
        /// </summary>
        public byte TipoEmpresa { get; set; }
        /// <summary>
        /// Estado para el borrado logico de la empresa
        /// </summary>
        public byte Estado { get; set; }
        #endregion
    }
}
