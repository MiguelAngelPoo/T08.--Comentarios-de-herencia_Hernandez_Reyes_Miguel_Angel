using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta
{
    public class Datos_cuenta: Cuentas
    {   //instanciamos objetos
        public List <Pensiones> ListaP()
        {
          
            //creamos los objetos
           List<Pensiones> Pension = new List<Pensiones>();
           Pension.Add(new Pensiones { Vencimiento = Convert.ToDateTime("11/05/2021"), Contizacion = 8473, NuCuentaOrigen = 2, Numero = 1, Titulo = "Marce", Saldo = 66363, Intereses = 737464 });
           Pension.Add(new Pensiones { Vencimiento = Convert.ToDateTime("11/05/2021"), Contizacion = 7563, NuCuentaOrigen = 1, Numero = 2, Titulo = "Premi", Saldo = 7592, Intereses = 49283 });
           Pension.Add(new Pensiones { Vencimiento = Convert.ToDateTime("11/05/2021"), Contizacion = 94927, NuCuentaOrigen = 3, Numero = 3, Titulo = "jun", Saldo = 5472, Intereses = 10847 });
           Pension.Add(new Pensiones { Vencimiento = Convert.ToDateTime("11/05/2021"), Contizacion = 47362,NuCuentaOrigen = 4, Numero = 4, Titulo = "kill", Saldo = 46252, Intereses = 492726 });
            Pension.Add(new Pensiones { Vencimiento = Convert.ToDateTime("12/06/2021"), Contizacion = 35435, NuCuentaOrigen = 5, Numero = 4234, Titulo = "Mike", Saldo = 332, Intereses = 3234 });
            return Pension;



        }


        public List<CuentaCorriente> ListaC()
        {

            List<CuentaCorriente> corriente = new List<CuentaCorriente>();
            corriente.Add(new CuentaCorriente { Numero = 1, Titulo = "Servan", Saldo = 332, Intereses = 3234 });
            corriente.Add(new CuentaCorriente { Numero = 2, Titulo = "Lusio", Saldo = 332, Intereses = 3234 });
            corriente.Add(new CuentaCorriente { Numero = 3, Titulo = "killer", Saldo = 332, Intereses = 3234 });
            corriente.Add(new CuentaCorriente { Numero = 4, Titulo = "maurisio", Saldo = 332, Intereses = 3234 });
            corriente.Add(new CuentaCorriente { Numero = 5, Titulo = "montes", Saldo = 332, Intereses = 3234 });
            return corriente;

        }


        public List <CuentaAhorro> ListaH()
        {
            

            List<CuentaAhorro> Ahorro = new List<CuentaAhorro>();


            Ahorro.Add(new CuentaAhorro { Numero = 1, Titulo = "Marco", Saldo = 4, Intereses = 3234,Vencimiento = Convert.ToDateTime("30/06/2022") });
            Ahorro.Add(new CuentaAhorro { Numero = 2, Titulo = "Morelos", Saldo = 34532, Intereses = 3234, Vencimiento = Convert.ToDateTime("11/06/2021") });
            Ahorro.Add(new CuentaAhorro { Numero = 3, Titulo = "Mile", Saldo = 45, Intereses = 3234, Vencimiento = Convert.ToDateTime("29/07/2023") });
            Ahorro.Add(new CuentaAhorro { Numero = 4, Titulo = "juan", Saldo = 45, Intereses = 3234, Vencimiento = Convert.ToDateTime("29/08/2024") });
            Ahorro.Add(new CuentaAhorro { Numero = 5, Titulo = "josu", Saldo = 45, Intereses = 3234, Vencimiento = Convert.ToDateTime("15/09/2026") });

            return Ahorro;
        }

        

    }
}
