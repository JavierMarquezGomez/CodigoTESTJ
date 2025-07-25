using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractConsole
{
    public class Cuadrado : Pieza, IService
    {
         readonly decimal Lado;
        
        public Cuadrado(decimal h, decimal lado) : base( h)
        {
            Lado = lado;
        }
        public override decimal Area()
        {
            return Lado * Lado;
        }

        public override decimal Perimetro()
        {
            return Lado * 4;
        }

        public override decimal suma(decimal a, decimal b)
        {

            
            return a * b;
        }

        //public double CalcularAreaConHipotenusa(int lado, int hipotenusa)
        //{
        //    double ladob = Math.Sqrt(Math.Pow(hipotenusa, 2) - Math.Pow(lado, 2));
        //    return lado * ladob / 2;
        //}
    }
}
