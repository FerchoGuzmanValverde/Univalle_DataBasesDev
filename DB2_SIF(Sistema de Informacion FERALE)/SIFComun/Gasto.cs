using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferale.Administracion.SistemaDeInformacionApp.Comun
{
    /// <summary>
    /// Clase para crear objetos de gasto
    /// </summary>
    public class Gasto
    {
        #region propiedades
        /// <summary>
        /// Identificador del gasto
        /// </summary>
        public int IdGasto { get; set; }
        /// <summary>
        /// Descripcion del gasto
        /// </summary>
        public string Descripcion { get; set; }
        /// <summary>
        /// Empresa que proveee el servicio
        /// </summary>
        public string EmpresaProveedor { get; set; }
        /// <summary>
        /// Tipo de Gasto
        /// </summary>
        public byte TipoGasto { get; set; }
        /// <summary>
        /// Estado para el borrado logico de gasto
        /// </summary>
        public byte Estado { get; set; }
        /// <summary>
        /// Tramite que ocaciono gasto
        /// </summary>
        public Tramite Tramite { get; set; }
        #endregion
    }
}
