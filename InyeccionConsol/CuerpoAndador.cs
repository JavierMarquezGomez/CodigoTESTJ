using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionConsol
{
    public class CuerpoAndador : ICuerpo, IOtro
    {
        public CuerpoAndador()
        {

        }
        public void Avanzar()
        {
            Console.WriteLine(" Avanzo.... desde Inyeccion1 Adaptador }}}}}}-->");
        }

        public void Disparar()
        {
            Console.WriteLine(" Disparo... desde Inyeccion1 Adaptador -----> ");
        }

        public void Retroceder()
        {
            Console.WriteLine(" Retrocedo ... desde Inyeccion1 Adaptador <--{{{{{ ");
        }
        public void Rodar()
        {
            Console.WriteLine("Rodar desde Inyeccion 1 Interfaz IAccion");
        }
        
        public void Ejercitar()
        {
            Console.WriteLine("Ejercitar");
        }
         
    }
}
