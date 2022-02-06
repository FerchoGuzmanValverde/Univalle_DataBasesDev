using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferale.SistemaDeInformacionApp.SIFComun
{
    /// <summary>
    /// Clase para crear objetos de usuarios
    /// </summary>
    public class Usuario
    {
        #region Propiedades

        /// <summary>
        /// Identificador del usuario
        /// </summary>
        public int IdUsuario { get; set; }
        /// <summary>
        /// Login del usuario
        /// </summary>
        public string LoginUsuario { get; set; }
        /// <summary>
        /// Password del usuario
        /// </summary>
        public string PasswordUsuario { get; set; }
        /// <summary>
        /// Estado para el borrado logico del usuario
        /// </summary>
        public byte Estado { get; set; }

        #endregion
    }
}
