using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace Thread
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Crear un nuevo hilo
            Thread miHilo = new Thread(new ThreadStart(MiMetodo));

            // Iniciar el hilo
            miHilo.Start();

            Console.WriteLine("Hilo principal continuando...");

            // Esperar a que el hilo termine (opcional)
            miHilo.Join();

            Console.WriteLine("Hilo principal terminado.");
        }

        public static void MiMetodo()
        {
            Console.WriteLine("Hilo secundario: Iniciando...");
            // Simular un trabajo largo
            Thread.Sleep(2000);
            Console.WriteLine("Hilo secundario:  Trabajo terminado.");
        }
    }
}
