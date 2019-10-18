using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
   public class DatosCuenta
    {
        //En este metodo agregamos los datos a las cuentas de pensiones
        public List<Pensiones> P()
        {
            List<Pensiones> pensiones = new List<Pensiones>();
            pensiones.Add(new Pensiones { Titular = "David", Num = 12345, Saldo = 20002});
            pensiones.Add(new Pensiones { Titular = "Juan", Num = 3, Saldo = 14124});
            pensiones.Add(new Pensiones { Titular = "Manuel", Num = 4, Saldo = 63142519});
            pensiones.Add(new Pensiones { Titular = "Jaime", Num = 5, Saldo =63215});
            return pensiones;
        }
        //En este metodo agregamos los datos a las cuentas de Cuenta Ahorro
        public List<Cuentaahorro> CA()
        {
            List<Cuentaahorro> cuentaahorros= new List<Cuentaahorro>();
            cuentaahorros.Add(new Cuentaahorro { Titular = "MerioUwU", Num = 1, Saldo = 41245});
            cuentaahorros.Add(new Cuentaahorro { Titular = "Andy", Num = 2, Saldo = 87127 });
            cuentaahorros.Add(new Cuentaahorro { Titular = "Sandra", Num = 3, Saldo = 152355 });
            cuentaahorros.Add(new Cuentaahorro { Titular = "Eduardo", Num = 4, Saldo = 2466545 });
            cuentaahorros.Add(new Cuentaahorro { Titular = "Omar", Num = 5, Saldo = 9874});
            return cuentaahorros;

        }
        //En este metodo agregamos los datos a las cuentas de Cuentas Corriente
        public List<CuentaCorriente> CC()
        {
            List<CuentaCorriente> Lista = new List<CuentaCorriente>();
            Lista.Add(new CuentaCorriente { Titular = "Luz", Num = 1, Saldo = 87412 });
            Lista.Add(new CuentaCorriente { Titular = "Joe", Num = 2, Saldo = 35125 });
            Lista.Add(new CuentaCorriente { Titular = "Luis", Num = 3, Saldo = 42352 });
            Lista.Add(new CuentaCorriente { Titular = "Martin", Num = 4, Saldo = 77645 });
            Lista.Add(new CuentaCorriente { Titular = "Miguel", Num = 5, Saldo = 612345 });
            return Lista;

        }


    }
}
