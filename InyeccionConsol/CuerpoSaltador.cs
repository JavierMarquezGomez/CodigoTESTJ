using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionConsol
{
    public class CuerpoSaltador : ICuerpo
    {
        public void Avanzar()
        {
            Console.WriteLine("Avanzo ... desde Inyeccion2 Saltador");
        }
        public void Retroceder()
        {
            Console.WriteLine("Retrocedo... desde Inyeccion2 Adaptador");
        }

        public void Disparar()
        {
            Console.WriteLine("Disparo... desde Inyeccion2 Adaptador");
        }
    }
}
