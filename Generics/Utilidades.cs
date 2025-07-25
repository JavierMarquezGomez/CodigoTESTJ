using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Utilidades
    {
        public static void imprimirElementos<T>(T elemento)
        {
            Console.WriteLine($"elemento: {elemento}");
        }
    }
}
