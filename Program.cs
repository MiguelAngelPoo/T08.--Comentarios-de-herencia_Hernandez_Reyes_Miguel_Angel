using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta
{
    class Program: Cuentas
    {



        static void Main(string[] args)
        {
            //En el main mandamos a llamar a la clase repo donde se encuentran los menu 
            //instanciamos repo para poder usarlo y asi llamar el metodo principal
            Repo r = new Repo();
            r.principal();

        }
    }
}
