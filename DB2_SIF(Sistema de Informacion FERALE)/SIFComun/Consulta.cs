using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferale.Administracion.SistemaDeInformacionApp.Comun
{
    /// <summary>
    /// Clase de la relacion entre empleado y documento
    /// </summary>
    public class Consulta
    {
        #region propiedades
        /// <summary>
        /// Empleado que consulta el documento
        /// </summary>
        public Empleado Empleado { get; set; }
        /// <summary>
        /// Documento que es consultado por el empleado
        /// </summary>
        public Documento Documento { get; set; }
        /// <summary>
        /// Fecha y hora en que el empleado consultó el documento
        /// </summary>
        public DateTime FechaHoraConsulta { get; set; }
        #endregion
    }
}
