using System;

namespace Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.Comun
{
    /// <summary>
    /// Clase hija que sirve para crear empleados
    /// </summary>
    public class Empleado: Persona
    {
        #region Propiedades

        /// <summary>
        /// Propiedad que sirve para guardar la fecha de contratación del empleado
        /// </summary>
        public DateTime FechaContratacion { get; set; }

        #endregion
    }
}
