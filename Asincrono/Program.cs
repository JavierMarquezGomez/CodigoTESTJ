using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asincrono
{
    public class Program
    {
        static async Task Main(string[] args)
        {

            //asincronoTest asincrono = new  asincronoTest();

            //Console.WriteLine("inicia linea");

            //Task<string> resultado1 = asincrono.resultado();
            //Task<string> resultado2 = asincrono.resultado2();


            //string[] resultados = await Task.WhenAll(resultado1, resultado2);


            //Console.WriteLine(resultados[0]);
            //Console.WriteLine(resultados[1]);


            //Console.WriteLine("Termina liena");
            //Console.ReadLine();


            //Console.WriteLine("Iniciando tarea asíncrona...");
            // await TareaAsincrona();

            //await TareaAsincrona2();
            //Console.WriteLine("Tarea asíncrona completada.");




            var tarea1 = TareaAsincrona();
            var tarea2 = TareaAsincrona2();

            Console.WriteLine("Ambas tareas iniciadas...");

            await tarea1;
            await tarea2;

            //await Task.WhenAll(tarea1, tarea2);

            Console.WriteLine("Ambas tareas completadas.");




            Console.ReadLine();
        }


        static async Task TareaAsincrona()
        {
            Console.WriteLine("Iniciando operación asíncrona...");
            await Task.Delay(9000); // Simula una operación que tarda 2 segundos
            Console.WriteLine("Operación asíncrona completada.");


           
           
        }


        static async Task TareaAsincrona2()
        {
            Console.WriteLine("Iniciando operación asíncrona...2");
            await Task.Delay(1000); // Simula una operación que tarda 2 segundos
            Console.WriteLine("Operación asíncrona completada....2");




        }
    }
}
