using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int obstaculos;
            Console.WriteLine("cuantos obstaculos tiene homero?");
            obstaculos = int.Parse(Console.ReadLine());

            int[] vector = new int[obstaculos];
            string respuesta;

            for (int i = 0; i < obstaculos; i++)
            {

                Console.WriteLine("supera el obstaculo " + i);
                respuesta = Console.ReadLine();


                if (respuesta == "si")
                {
                    vector[i] += 10;
                }
                else if (respuesta == "no")
                {
                    vector[i] -= 5;
                }
                else
                {
                    Console.WriteLine("error");
                    i--;
                }



            }

            int acumulador = 0;

            for (int i = 0; i < obstaculos; i++)
            {
                acumulador += vector[i];
            }
            Console.WriteLine("el punatje final es: " + acumulador);
            Console.ReadKey();
        }
    }
}
