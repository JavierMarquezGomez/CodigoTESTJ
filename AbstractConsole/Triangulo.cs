using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractConsole
{
    public class Triangulo : Pieza
    {
       public Triangulo ( decimal h): base(h)
        {

        }
        public override decimal Area()
        {
            throw new NotImplementedException();
        }

        public override decimal Perimetro()
        {
            throw new NotImplementedException();
        }

        public override decimal suma(decimal a, decimal b)
        {
            return base.suma(a, b);
        }
    }
}
