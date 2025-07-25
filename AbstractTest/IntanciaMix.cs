using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTest
{
    public  class IntanciaMix : Car
    {
        public override void Star()
        {
            base.Star();
        }

        public override void Stop()
        {
            base.Stop();
        }


        public override string mensaje()
        {
            string mensaje = "Sobreecrito";
            return mensaje;
        }

        public static string mensajeStatic()
        {
            return "Hola soy un static ";
        }


    }
}
