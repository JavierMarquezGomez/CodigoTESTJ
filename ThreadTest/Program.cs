using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio del hilo principal.");
            ThreadStart newThread = new ThreadStart(OtherThread);
            ThreadStart hilo3 = new ThreadStart(TercerThread);
            ThreadStart hilo4 = new ThreadStart(enlace);
            Thread thread = new Thread(newThread);
            Thread tercer = new Thread(hilo3);
            Thread cuarto = new Thread(hilo4);
            thread.Start();
            tercer.Start();
            cuarto.Start();
            Console.WriteLine("Fin del hilo principal.");

            probarConexion c = new probarConexion();


            Console.Read();
        }
        public static void OtherThread()
        {
            Console.WriteLine("Inicio del hilo secundario.");
            Thread.Sleep(2000);
            Console.WriteLine("Fin del hilo secundario.");
        }

        public static void TercerThread()
        {
            Console.WriteLine("Inicio de Tercer Hilo.");
            Thread.Sleep(5000);
            Console.WriteLine("Fin del Tercer Hilo");
        }

        public static  void enlace()
        {
            probarConexion con = new probarConexion();
            Console.WriteLine("Inicianod enlace");
            con.test("abcd",23);
            Thread.Sleep(9000);
            Console.WriteLine("Conexion Exitosa");
        }

        public class probarConexion
        {
            public string test(string direccion, int posicion)
            {

                return "Hola me conect";
            }
        }

    }


  
}


