using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
   public class Cuenta
    {
        //Encapsulamos los datos
        public int Num { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public double Interes { get; set; }

      //hacemos un metodo para que el usuario ingrese dinero a su cuenta
        public bool ingreso()
        {
        
            return false;

        }
        //Un metodo para que el usuario pueda consultar cuanto saldo tiene
        public void ConultarSaldo(Cuenta cuenta)
           {
            Console.WriteLine("Su saldo actual es de $"+cuenta.Saldo);
            Console.ReadKey();
            
           }
        //Metodo para que el usuario vea cuando interes por mes
        //en este metodo hacemos la operacion y la retornamos al menu 
        public double Interespormes(Cuenta p)
        {
            var itotal = p.Interes/100 *Convert.ToDouble(p.Saldo);
            return itotal;
        }
       
    }
}
