using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Guardar<T> where T  : Mascota
    {
        private List<T> mascotas = new List<T>(); 

        public void AgregarMascota(T nuevaMascota)
        {
            mascotas.Add(nuevaMascota);
        }

        public void MostrarNombre()
        {
            foreach (var m in mascotas)
            {
                Console.WriteLine(m.Nombre);
            }
        }
    }
}
