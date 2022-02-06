using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Lectura
    {
        #region Propiedades

        public DateTime InicioLectura { get; set; }
        public DateTime FinLectura { get; set; }
        public string NombreLectura { get; set; }
        public string MotivoLectura { get; set; }
        public string NombreResponsable { get; set; }
        public List<Registro> Registros { get; set; }
        public byte Estado { get; set; }

        #endregion

        #region Constructores

        public Lectura(DateTime inicio, DateTime fin, string nombreLectura, string motivoLectura, string responsable, List<Registro> registros)
        {
            this.InicioLectura = inicio;
            this.FinLectura = fin;
            this.NombreLectura = nombreLectura;
            this.MotivoLectura = motivoLectura;
            this.NombreResponsable = responsable;
            this.Registros = registros;
            this.Estado = 1;
        }

        
        public Lectura(string nombreLectura)
        {
            this.NombreLectura = nombreLectura;
        }

        public Lectura()
        {

        }

        #endregion
    }
}
