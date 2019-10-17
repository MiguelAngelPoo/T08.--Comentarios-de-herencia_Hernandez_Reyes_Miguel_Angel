using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta
{
    public class Cuentas
    {
        //clase donde se realizan todos los metodos del menu de usuario
        public int Numero { get; set; }
        public string Titulo { get; set; }
        public double Saldo { get; set; }
        public double Intereses { get; set; }


        public bool ingreso(List<Cuentas> L,Cuentas C)
        {
           return false;
        }

        //operacion de interes por mes
        public double InteresXMes(Cuentas Lista)
        {
            var itotal = Intereses * .16;
            Console.WriteLine("El interes por mes es:" + itotal);
            return 0;
        }
        //consulta de saldo
        public void ConsultarSaldo(Cuentas Lista)
        {

            Console.WriteLine("Su saldo Actual es de  $: " + Lista.Saldo);
        }

        //transferencia 
        public void Tranferir(Cuentas Lista)
        {
            Console.WriteLine("ingrese la cantidad que  decea tranferir: ");
            double trans = Convert.ToDouble(Console.ReadLine());
            //condicion 
            if(trans < Saldo)
            {
                //operacion
                double Va = Saldo - trans;
                Console.WriteLine("Saldo transferido");
                Console.WriteLine("Saldo actual es: " + Va);
            }
        }


        public void ingreso(Cuentas Lista)
        {
            Console.WriteLine("ingrese ");
        }

        
        public void reintegro(Cuentas Lista)
        {
            int Res;
            Console.WriteLine("ingrese el la cantidad que desea reintegrar a su cuenta:");

        }

        //ingreso por mes
        public void IngresoPorMes(Cuentas Lista)
        {
            //procedimiento
            double IGM;
            Console.WriteLine("ingrese numero de  meses que a pagado:");
            double nm = Convert.ToDouble(Console.ReadLine());
            IGM = (Saldo / nm);

            Console.WriteLine("el ingreso por mes es:" + IGM);
            
        }

       
    }
}
