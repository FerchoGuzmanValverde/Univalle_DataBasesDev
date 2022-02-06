
using System;


namespace Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.Comun
{
    /// <summary>
    /// Clase que sirve para crear objetos usuario
    /// </summary>
    public class Usuario
    {
        #region propiedades

        /// <summary>
        /// Identificador del usuario
        /// </summary>
        public Guid IdUsuario { get; set; }

        /// <summary>
        /// Nombre de usuario
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Contraseña del usuario
        /// </summary>
        public string Contrasenia { get; set; }

        /// <summary>
        /// Eliminado que sirve para el eliminado lògico
        /// </summary>
        public bool Eliminado { get; set; }

        #endregion
    }
}
