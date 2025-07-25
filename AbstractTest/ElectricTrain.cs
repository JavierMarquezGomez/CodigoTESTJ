using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTest
{
    public class ElectricTrain : Vehiculo
    {
        public override void Star()
        {
            Console.WriteLine("Arranca Electrico");
        }
        public override void Stop()
        {
            Console.WriteLine("Detiene Electrico");
        }

    }
}
