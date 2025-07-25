using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractConsole
{
    public abstract class Pieza
    {
       
        public Pieza( decimal h)
        {
            
        }
        public abstract decimal Area();
        public abstract decimal Perimetro();

        public virtual decimal suma( decimal a , decimal b)
        {
            decimal resultado;
            return resultado = a + b;
        }

        //public double CalcularHipotenusa(int lado, int hipotenusa)
        //{
        //    double ladob = Math.Sqrt(Math.Pow(hipotenusa, 2) - Math.Pow(lado, 2);
        //    return lado * ladob / 2;

        //}

    }
}
