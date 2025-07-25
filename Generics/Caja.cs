using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Caja<T>
    {
        private T contenido;

       public Caja(T valor)
        {
            contenido = valor;
        }

        public T obtieneContenido()
        {

            return contenido;
        }
      
    }
}
