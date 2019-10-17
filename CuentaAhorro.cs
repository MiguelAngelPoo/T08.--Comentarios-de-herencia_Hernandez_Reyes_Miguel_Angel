using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta
{
   public class CuentaAhorro: Cuentas
    {
        public DateTime Vencimiento { get; set; }

        //clase de cuenta ahorro se usa herencia para acceder a sus elementos
    }
}
