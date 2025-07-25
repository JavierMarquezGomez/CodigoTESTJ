using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTest
{
    public class Car : Vehiculo
    {
        public override void Star()
        {
            Console.WriteLine("Abstract Veh Arranca");
        }

        public override void Stop()
        {
            Console.WriteLine("Abstract Veh Stop");
        }
        public virtual string mensaje()
        {
            string ms;
            return  ms = "Retorno";
        }
    }
}
