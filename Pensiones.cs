using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta
{
    public class Pensiones: Cuentas
    {
        //encapsulacion de los datos de la cuenta pension
        public DateTime Vencimiento { get; set; }
        public double Contizacion { get; set; }
        public double NuCuentaOrigen { get; set; }

    }
}
