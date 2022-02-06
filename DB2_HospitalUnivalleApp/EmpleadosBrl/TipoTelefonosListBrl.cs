using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.Comun;

namespace Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.EmpleadosBrl
{
    public class TipoTelefonosListBrl
    {
        public static TipoTelefonoList Get()
        {
            return EmpleadosDal.TipoTelefonoListDal.Get();
        }

    }
}
