using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int invitados;
            Console.WriteLine("cuantos invitados hay?");
            invitados = int.Parse(Console.ReadLine());


            int[] vector = new int[invitados];
            int comida;

            for (int i = 0; i < invitados; i++)
            {

                Console.WriteLine("cuanta comida come el invitado " + (i + 1));

                comida = int.Parse(Console.ReadLine());


                if (comida > 100)
                {
                    Console.WriteLine("error, numero menor de 100");
                    i--;
                }
                else if (comida < 100)
                {
                    vector[i] = comida;

                }

            }

            int acumulador = 0;

            for (int i = 0; i < invitados; i++)
            {
                acumulador += vector[i];
            }
            Console.WriteLine("el promedio final es " + (acumulador / invitados));
            Console.ReadKey();
        }
    }
}
