using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
   public class Program
   {
        static void Main(string[] args)
        { 
           //instanciamos la clase repobanco y mandamos a llamar al metodo Menu()
            Repobanco rb = new Repobanco();
            rb.Menu();
            //List<Cuenta> Cuentas = new List<Cuenta>();
            //Cuenta cue = new Cuenta();
            //cue.Titular = "David";
            //cue.Num = 2;
            //cue.Saldo = 9999;
            //cue.Interes = 19;
            //Cuentas.Add(cue);

            //Cuenta cu = new Cuenta();
            //cu.Titular = "Lyss";
            //cu.Num = 4;
            //cu.Saldo = 912999;
            //cu.Interes = 20;
           // Cuentas.Add(cu);
            //List<P>
            //Lisr<CC>
            //list<CA>

           //Console.WriteLine("Digite su numero de cuenta");
            //var CuentaN = Convert.ToInt32(Console.ReadLine());
            //foreach (var ac in Cuentas)
            //{
               // if (CuentaN == ac.Num)
                //{
                  //  Menu();

              //  }
           // }




        }
            


        
        public Program()
        {
            List<Pensiones> pensiones = new List<Pensiones>();
            List<Cuentaahorro> cuentaahorros = new List<Cuentaahorro>();
            List<CuentaCorriente> cuentaCorrientes = new List<CuentaCorriente>();
            DatosCuenta DC = new DatosCuenta();
            pensiones = DC.P();
            
        }

     
    }
}
