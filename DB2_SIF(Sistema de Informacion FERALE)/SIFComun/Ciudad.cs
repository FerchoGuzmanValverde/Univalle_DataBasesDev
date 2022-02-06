using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferale.Administracion.SistemaDeInformacionApp.Comun
{
    /// <summary>
    /// Clase para crear objetos de Ciudad
    /// </summary>
    public class Ciudad
    {
        #region propiedades
        /// <summary>
        /// Identificador de Ciudad
        /// </summary>
        public int IdCiudad { get; set; }
        /// <summary>
        /// Nombre de la Ciudad
        /// </summary>
        public string NombreCiudad { get; set; }
        /// <summary>
        /// Estado para el borrado logico de la Ciudad
        /// </summary>
        public byte Estado { get; set; }
        /// <summary>
        /// Pais al que pertenece la ciudad
        /// </summary>
        public Pais Pais { get; set; }
        #endregion
    }
}
