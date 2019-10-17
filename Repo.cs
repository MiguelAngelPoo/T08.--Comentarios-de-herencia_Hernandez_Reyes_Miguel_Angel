using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta
{
    public class Repo
    {
        //instacimos ad para poder usarlo y acceder a datos cuenta
        Datos_cuenta ad;
        public Repo()
        {
            //instancia 
            ad = new Datos_cuenta();
            
        }

        //Mensaje de vienvenida
        internal void principal() 
        {
            Console.WriteLine("bienvenidos a el banco mi casita");
            Menu();
            Console.ReadKey();
        }

        public void Menu() 
        {
            //Menu principal donde podemos accesar a todas las opciones de cuentas
            Console.WriteLine("Ingrese la opcion correcta");
            Console.WriteLine("1.-Cuenta ahorro \n2.-Pensiones \n3.-cuenta corriente");
            switch (Console.ReadLine())
            { 
               //switch donde realizamos todo el llamado de metodos
                case "1":
                    Console.WriteLine("bienvenidos a cuenta ahorro");
                    GetDataSave();
                    break;
                case "2":
                    Console.WriteLine("bienvenidos a pensiones");
                    GetPension();
                    break;
                case "3":
                    Console.WriteLine("bienvenidos a cuenta corriente");
                    GetDatecorriente();
                    break;
                case "4":
                   
                    break;
                    
                default:
                    break;
                        

            }
 
        }
        //metodo para obtener el numero de cuenta de usuario en cuenta corriente
        private void GetDatecorriente()
        { 
            int numer2 = GetData();
            var listaC = ad.ListaC();
            CuentaCorriente C = new CuentaCorriente();
            //condicion para buscar el numero
            foreach (var cuenta in listaC)
            {
                if (numer2 == cuenta.Numero)
                {
                    C = cuenta;
                }
                Console.WriteLine(C.Titulo);
                
            }

            Console.WriteLine("Bienvenido " + C.Titulo);
            Console.ReadKey();
            menuUsuario2(C);
            



        }
        //metodo para obtener el numero de cuenta de usuario en pension
        public void GetPension() 
        {
            int number = GetData();
            var lista = ad.ListaP();
            Pensiones p = new Pensiones();
            //condicion para buscar el numero
            foreach (var cuenta in lista)
            {
                if (number == cuenta.Numero)
                {
                    p = cuenta;
                }
                //Console.WriteLine(item.Headline);
            }

            Console.WriteLine("Bienvenido " + p.Titulo);
            Console.ReadKey();
            menuUsuario(p);
        }
        //metodo para obtener el numero de cuenta de usuario en cuenta ahorro
        private void GetDataSave()
        {
            int numer3 = GetData();
            var listaH = ad.ListaH();
            CuentaAhorro H = new CuentaAhorro();
            //se instancia cuenta ahorro y de la misma manera en los otros 2 metodos 
            //condicion para buscar el numero
            foreach (var cuenta in listaH)
            {
                if (numer3 == cuenta.Numero)
                {
                    H = cuenta;
                }
                //Console.WriteLine(item.Headline);
            }
            //mensaje que se despliega con el usuario
            Console.WriteLine("Bienvenido " + H.Titulo);
            Console.ReadKey();
            menuUsuario3(H);
        }
        //captura del numero de usuario
        private int GetData()
        {
            Console.WriteLine("Ingrese Su Numero de Cuenta");
            string res = Console.ReadLine();
            return Convert.ToInt32(res);
        }

        //Menu creado para la cuenta pensiones donde se incluiran las opciones para este tipo 
        private void menuUsuario(Cuentas p)
        {
            Console.Clear();
            Console.WriteLine("1.-consultar saldo \n2.-transferir \n3.-intereses x mes \n4.-ingreso");
            Console.WriteLine("Elige una opcion");
            //se crea un switch para poder llamar a los metodos que se encuentran en la clase cuentas
            switch (Console.ReadLine())
            {
                case "1":
                    p.ConsultarSaldo(p);
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                   
                    break;
                case "2":
                    p.Tranferir(p);
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case "3":
                    p.InteresXMes(p);
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case "4":
                    p.IngresoPorMes(p);
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;

                default:
                    break;
            }
        }


        //Menu creado para la cuenta corriente donde se incluiran las opciones para este tipo 
        private void menuUsuario2(Cuentas C)
        {
            Console.Clear();
            Console.WriteLine("1.-consultar saldo \n2.-transferir \n3.-intereses x mes \n4.-ingreso");
            Console.WriteLine("Elige una opcion");
            //se crea un switch para poder llamar a los metodos que se encuentran en la clase cuentas
            switch (Console.ReadLine())
            {
                case "1":
                    C.ConsultarSaldo(C);
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case "2":
                    C.Tranferir(C);
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case "3":
                    C.InteresXMes(C);
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case "4":
                    C.IngresoPorMes(C);
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;

                default:
                    break;
            }
        }


        //Menu creado para la cuenta ahorros donde se incluiran las opciones para este tipo 
        private void menuUsuario3(Cuentas H)
        {
            Console.Clear();
            Console.WriteLine("1.-consultar saldo \n2.-transferir \n3.-intereses x mes \n4.-reintegro");
            Console.WriteLine("Elige una opcion");
            //se crea un switch para poder llamar a los metodos que se encuentran en la clase cuentas
            switch (Console.ReadLine())
            {
                case "1":
                    H.ConsultarSaldo(H);
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case "2":
                    H.Tranferir(H);
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case "3":
                    H.InteresXMes(H);
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case "4":
                    H.IngresoPorMes(H);
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case "5":
                   
                    break;

                default:
                    break;
            }
        }

    }
}
