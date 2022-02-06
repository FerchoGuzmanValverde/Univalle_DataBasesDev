
using System;

namespace Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.Comun
{
    /// <summary>
    /// Clase que sirve para crear telefonos
    /// </summary>
    public class Telefono
    {
        #region propiedades

        /// <summary>
        /// Identificador del telefono
        /// </summary>
        public Guid IdTelefono { get; set; }

        /// <summary>
        /// Numero que sirve para registrar el número telefonico
        /// </summary>
        public int Numero { get; set; }

        /// <summary>
        /// TipoTelefono que sive para guardar el tipo de teléfono
        /// </summary>
        public TipoTelefono TipoTelefono { get; set; }

        /// <summary>
        /// Persona que sirve para guardar la persona que le corresponde el telefono
        /// </summary>
        public Persona Persona { get; set; }

        /// <summary>
        /// Eliminado que sirve para el eliminado lògico
        /// </summary>
        public bool Eliminado { get; set; }

        #endregion
    }
}
