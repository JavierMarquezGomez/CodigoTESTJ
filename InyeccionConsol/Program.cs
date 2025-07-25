using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionConsol
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Opcion 1 Inyeccion por Setter
             */
            /*
            Console.WriteLine("Instancia - Inyeccion por SETTER");
            Console.WriteLine("--------------------------------");
            //Implementacion de Inyeccion por SETTER INTERFAZ 1
            ICuerpo cuerpoAndador = new CuerpoAndador();
            Androide androide = new Androide();
            androide.cuerpo = cuerpoAndador;
            androide.Avanzar();

            //Implementacion de Inyeccion por SETTER INTERFAZ 2
            ICuerpo cuerpoSaltador = new CuerpoSaltador();
            Androide androide2 = new Androide();
            androide2.cuerpo = cuerpoSaltador;
            androide2.Avanzar();

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Termina proceso");
            Console.ReadKey();

            */


            /*
            Opcion 2 Inyeccion por Interfaz
            */
            /*
            Console.WriteLine("Instancia - Inyeccion por INTERFAZ");
            Console.WriteLine("--------------------------------");
            //Implementacion de Inyeccion por INTERFAZ INTERFAZ 1
            ICuerpo cuerpoAndador = new CuerpoAndador();
            Androide androide = new Androide();
            androide.SetCuerpo(cuerpoAndador);
            androide.Avanzar();

            //Implementacion de Inyeccion por INTERFAZ INTERFAZ 2
            ICuerpo cuerpoSaltador = new CuerpoSaltador();
            Androide androide2 = new Androide();
            androide2.SetCuerpo(cuerpoSaltador);
            androide2.Avanzar();

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Termina proceso");
            Console.ReadKey();

            */


            /*
           Opcion 2 Inyeccion por Interfaz
           */
           
            Console.WriteLine("Instancia - Inyeccion por CONSTRUCTOR");
            Console.WriteLine("--------------------------------");
            //Implementacion de Inyeccion por CONSTRUCTOR INTERFAZ 1
            ICuerpo cuerpoAndador = new CuerpoAndador();
            IAccion accion = new CuerpoAndador();
            IOtro otro = new CuerpoAndador();
            Androide androide = new Androide(cuerpoAndador, otro);
            
            androide.Avanzar();
            androide.Rodar();

            //Implementacion de Inyeccion por CONSTRUCTOR INTERFAZ 2
            ICuerpo cuerpoSaltador = new CuerpoSaltador();
            IAccion accion1 = new CuerpoAndador();
            IOtro otro2 = new CuerpoAndador();
            Androide androide2 = new Androide(cuerpoSaltador, otro2);
            androide2.Avanzar();
            androide2.Rodar();
            androide2.Ejercitar();

            Console.WriteLine("--------------------------------");
            //Console.WriteLine("Termina proceso");
            //Console.ReadKey();


            clConexion con = new clConexion();


            List<int> x = new List<int>();
            x.Add(21);
            x.Add(23);
            x.Add(21);

            var r =con.Generico<int>(x);

            Console.WriteLine("Salida de X : " +r);


            List<SqlParameter> parIn = new List<SqlParameter>();
            List<SqlParameter> parOut = new List<SqlParameter>();

            parIn.Add(new SqlParameter("X", System.Data.SqlDbType.Int) { Value = 30022001 });
            parOut.Add(new SqlParameter("Y", System.Data.SqlDbType.VarChar, 20) { Direction = System.Data.ParameterDirection.Output });

            con.result("SQP", parIn, parOut);

            
            Console.Read();
        }
    }
}
