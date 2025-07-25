using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTest
{
    public class objeto : Vehiculo 
    {
        public static  string ejemploStatic()
        {
            return "Hola";
        }

        public override void Star()
        {
            throw new NotImplementedException();
        }

        public override void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
