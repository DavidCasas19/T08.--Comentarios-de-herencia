using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Repobanco
    {
        DatosCuenta ad;
        public Repobanco()
        {
            ad = new DatosCuenta();
        }

        //un Menu donde el usuario eliga su tipo de cuenta y le de acceso al siguiente menu
        public void Menu()
        { 
            Console.WriteLine("Eliga una opcion");
            Console.WriteLine("1.-Pensiones \n2.- Cuenta Corriente \n3.-Cuenta Ahorro");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Bienvenidos a Pensiones");
                    GetDatapension();
                    break;

                case "2":
                    Console.WriteLine("Bienvenidos a Cuenta Corriente");
                    GetDataCorrriente();
                    Console.ReadKey();
                    break;

                case "3":
                    Console.WriteLine("Bienvenidos a Cuenta ahorro");
                    GetDataAhorro();
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Ingrese un numero correcto");
                    break;

            }

           
        }
        // en este metodo elegimos que cuenta quiera ver el usuario  usando el foreach para identificar la cuenta que necesita 
        void GetDataCorrriente()
        {
            int number = GetData();
            var List = ad.CC();
            CuentaCorriente cc = new CuentaCorriente();

            foreach (var cuent in List)
            {
                if (number == cuent.Num)
                {
                    cc = cuent;
                }

            }
            Console.WriteLine("Bienvenido" + " " + cc.Titular);
            Console.ReadKey();
            MenuUsuario(cc);
        }

        // en este metodo elegimos que cuenta quiera ver el usuario  usando el foreach para identificar la cuenta que necesita lo mismo pero para pensiones
       private void GetDatapension()
        {
            int number = GetData();
            var Lista = ad.P();
            Pensiones p = new Pensiones();

            foreach (var cuenta in Lista)
            {
                if (number == cuenta.Num)
                {
                    p = cuenta;
                }

            }
            Console.WriteLine("Bienvenido" +" "+ p.Titular);
            Console.ReadKey();
            MenuUsuario(p);
        }
        // en este metodo elegimos que cuenta quiera ver el usuario  usando el foreach para identificar la cuenta que necesita lo mismo pero para cuenta ahorro
        void GetDataAhorro()
        {
            int number = GetData();
            var Listas = ad.CA();
            Cuentaahorro ca = new Cuentaahorro();

            foreach (var cuentas in Listas)
            {
                if (number == cuentas.Num)
                {
                    ca = cuentas;
                }

            }
            Console.WriteLine("Bienvenido" + " " +ca.Titular);
            Console.ReadKey();
            MenuUsuario(ca);
        }
        //un segundo menu donde el usuario eliga que es lo que quiere hacer con su cuenta y las varias opciones que ofrece
        
        private void MenuUsuario(Cuenta p)
        {
            Console.Clear();
            Console.WriteLine("Bienvenido a tu cuenta");
            Console.WriteLine("1.-Consultar saldo \n2.- Transferir \n3.-Interes x mes\n4.- ingreso");
            Console.WriteLine("Eliga una opcion");
            switch (Console.ReadLine())
            {
                case "1":
                    p.ConultarSaldo(p);
                    MenuUsuario(p);
                    break;

                case "2":

                    break;

                case "3":
                    Console.WriteLine("El interes Generado es de:"+ p.Interespormes(p));
                    Console.ReadKey();
                    
                    break;

                default:
                    break;
            }
        }
        //un metodo en donde se le pide al usuario el numero de cuenta para que pueda consultarlo
        public int GetData()
        {
            Console.WriteLine("Ingrese su numero de cuenta");
            string res = Console.ReadLine();
            return Convert.ToInt32(res);
        }
    }
}