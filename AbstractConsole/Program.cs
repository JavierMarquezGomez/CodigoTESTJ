using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicia proceso");
            Cuadrado c = new Cuadrado(0,2);
            decimal z =  c.Area();
            decimal hip = c.suma(5, 8);
            Console.WriteLine("Resultado Area = "  +z.ToString());
            Console.WriteLine("Resultado suma = " + hip.ToString());
            Console.WriteLine("Termina proceso");
            Console.WriteLine("");
            Console.WriteLine("Fin de codigo");
            Console.ReadKey();

        }
    }
}
