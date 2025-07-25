using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asincrono
{
    public class asincronoTest
    {


        public async Task<string> resultado()
        {
            string menaje = "Proceso 1 tarda 9000 terminado";

            await Task.Delay(9000);
            return menaje;
        }


        public async Task<string> resultado2()
        {
            string menaje = "Proceso 2  tarda 200";

            await Task.Delay(200);
            return menaje;
        }
    }
}
