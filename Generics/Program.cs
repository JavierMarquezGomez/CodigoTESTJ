using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<nombre> datos = new List<nombre>()
            {
                new nombre {ape = "Jose", nom= "Tellez"},
                new nombre{ape = "Pedro", nom= "Reyes"}
            };


            Caja<int> entero = new Caja<int>(234);
            Caja<List<nombre>> lista = new Caja<List<nombre>>(datos);
            Caja<string> texto = new Generics.Caja<string>("Hola");

            Console.WriteLine("Impresion de Generics ENTERO" + entero.obtieneContenido());
            Console.WriteLine("Impresion de Lista LIST" + lista.obtieneContenido());


            //

            Guardar<Perro> guardaPerro = new Guardar<Perro>();
            guardaPerro.AgregarMascota(new Perro { Nombre = "Robin"   });

            var guardaGato = new Guardar<Gato>();
            guardaGato.AgregarMascota(new Gato { Nombre = "pepe" });

            guardaPerro.MostrarNombre();
            guardaGato.MostrarNombre();
            
            // Ejemeplo 
            Utilidades.imprimirElementos<string>("Hola");
            Utilidades.imprimirElementos<int>(123);
            Utilidades.imprimirElementos<decimal>(23.4m);
            Utilidades.imprimirElementos<bool>(true);

            IRepositorio<string> repo = new RepositorioDeClientes();
            repo.Agregar("HOla");
            repo.Agregar("Texto");

            foreach (var item in repo.ObtenerTodos())
            {
                Console.WriteLine($"El contenido del item es {item}");
            }


            Console.Read();
        }

       

        public class nombre {

            public string nom { get; set; }
            public string ape { get; set; }

            }

    }
}
