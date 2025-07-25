using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Mascota
    {
        public string Nombre { get; set; }
    }

    public class Perro : Mascota
    {
        public void Ladrar() => Console.WriteLine("Ladra");
    }
    public class Gato : Mascota
    {
        public void Maullar() => Console.WriteLine("Maulla");
    }
}
