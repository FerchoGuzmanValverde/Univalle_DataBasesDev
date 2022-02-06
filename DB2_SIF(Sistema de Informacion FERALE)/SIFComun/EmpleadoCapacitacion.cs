using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferale.Administracion.SistemaDeInformacionApp.Comun
{
    /// <summary>
    /// Clase de la relacion entre empleado y capacitacion
    /// </summary>
    public class EmpleadoCapacitacion
    {
        #region propiedades
        /// <summary>
        /// Empleado que asistio a la capacitacion
        /// </summary>
        public Empleado Empleado { get; set; }
        /// <summary>
        /// Capacitacion que se brindo al empleado
        /// </summary>
        public Capacitacion Capacitacion { get; set; }
        /// <summary>
        /// Fecha y Hora de inicio de la capacitacion
        /// </summary>
        public DateTime FechaHoraInicio { get; set; }
        /// <summary>
        /// Fecha y Hora del fin de la capacitacion
        /// </summary>
        public DateTime FechaHoraFin { get; set; }
        #endregion
    }
}
