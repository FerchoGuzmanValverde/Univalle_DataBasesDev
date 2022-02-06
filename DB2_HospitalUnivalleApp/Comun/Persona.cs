
using System;
using System.Collections.Generic;

namespace Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.Comun
{
    /// <summary>
    /// Clase padre que sirve para crear personas
    /// </summary>
    public  class Persona
    {
        #region propiedades

        /// <summary>
        /// Identificador de la persona
        /// </summary>
        public Guid IdPersona { get; set; }

        /// <summary>
        /// Nombre que sirve para guardar el nombre de la persona
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// PrimerApellido que sirve para guardar el primer apellido de la persona
        /// </summary>
        public string PrimerApellido { get; set; }

        /// <summary>
        /// SegundoApellido que sirve para guardar el segundo apellido de la persona
        /// </summary>
        public string SegundoApellido { get; set; }

        /// <summary>
        /// Usuario que sirve para guardar a usuario de la persona
        /// </summary>
        public Usuario Usuario { get; set; }

        /// <summary>
        /// Lista de telefonos 
        /// </summary>
        public List<Telefono> Telefonos { get; set; }

        /// <summary>
        /// Eliminado que sirve para el eliminado lògico
        /// </summary>
        public bool Eliminado { get; set; }

        #endregion

    }
}
