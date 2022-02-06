using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferale.Administracion.SistemaDeInformacionApp.Comun
{
    /// <summary>
    /// Clase para crear objetos de capacitador
    /// </summary>
    public class Capacitador
    {
        #region propiedades
        /// <summary>
        /// Identificador del capacitador
        /// </summary>
        public int IdCapacitador { get; set; }
        /// <summary>
        /// Nombre del capacitador
        /// </summary>
        public string Nombre { get; set; }
        /// <summary>
        /// Primer Apellido del capacitador
        /// </summary>
        public string PrimerApellido { get; set; }
        /// <summary>
        /// segundo apellido del Capacitador
        /// </summary>
        public string SegundoApellido { get; set; }
        /// <summary>
        /// Profesion del capacitador
        /// </summary>
        public string Profesion { get; set; }
        /// <summary>
        /// Cantidad de capacitaciones que brindo a la empresa
        /// </summary>
        public byte NroCapacitaciones { get; set; }
        /// <summary>
        /// Estado para el borrado logico del Capacitador
        /// </summary>
        public byte Estado { get; set; }
        #endregion
    }
}
