using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferale.SistemaDeInformacionApp.SIFComun
{
    /// <summary>
    /// Clase para crear objetos de persona
    /// </summary>
    public class Persona
    {
        #region Propiedades

        /// <summary>
        /// Identificador de la Persona
        /// </summary>
        public int IdPersona { get; set; }
        /// <summary>
        /// Nombre de la persona
        /// </summary>
        public string Nombre { get; set; }
        /// <summary>
        /// Primer apellido de la persona
        /// </summary>
        public string PrimerApellido { get; set; }
        /// <summary>
        /// Segundo Apellido de la persona
        /// </summary>
        public string SegundoApellido { get; set; }
        /// <summary>
        /// Cedula de Identidad de la persona
        /// </summary>
        public string CedulaIdentidad { get; set; }
        /// <summary>
        /// Tipo de Persona: 0 = Sin tipo, 1 = Cliente, 2 = Empleado
        /// </summary>
        public byte TipoPersona { get; set; }
        /// <summary>
        /// Estado de la persona para borrado logico
        /// </summary>
        public byte Estado { get; set; }
        /// <summary>
        /// Provincia de procedencia de la persona
        /// </summary>
        public Provincia Provincia { get; set; }
        /// <summary>
        /// Usuario de la persona
        /// </summary>
        public Usuario Usuario { get; set; }
        /// <summary>
        /// Domicilio descriptivo de la persona
        /// </summary>
        public Domicilio Domicilio { get; set; }
        /// <summary>
        /// Lista de telefonos de la persona
        /// </summary>
        public List<Telefono> Telefonos { get; set; }
        
        #endregion
    }
}
