using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo carro = new Car();
            Vehiculo electrico = new ElectricTrain();
            Vehiculo insMix = new IntanciaMix();
            IntanciaMix mx = new IntanciaMix();
            Car insCar = new Car();

            var x = IntanciaMix.mensajeStatic();

            StartVehiculo(carro);
            StartVehiculo(electrico);
            string ms2 = insCar.mensaje();
            string ms = mx.mensaje();

            Console.WriteLine(x);

            Console.WriteLine(ms2);
            Console.WriteLine(ms);
            Console.WriteLine("Termina proceso");
            Console.ReadKey();

        }

        static void StartVehiculo(Vehiculo vehiculo)
        {
            vehiculo.Star();
        }


    }
}
