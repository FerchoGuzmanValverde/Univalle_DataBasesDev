using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferale.SistemaDeInformacionApp.SIFComun
{
    /// <summary>
    /// Clase que sirve para crear objetos e identificarlos por su valor
    /// </summary>
    public class UsuarioKeyValue
    {
        /// <summary>
        /// Identificador del usuario
        /// </summary>
        public int IdUsuario { get; set; }

        /// <summary>
        /// Login que sirve para guardar el login del usuario
        /// </summary>
        public string Login { get; set; }
    }
}
