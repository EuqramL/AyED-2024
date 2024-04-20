using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int radio;
            double pi = 3.14;
            Console.WriteLine("Escribi el radio de la esfera");
            radio = int.Parse(Console.ReadLine());
            Console.WriteLine("la superficie es: " + (4 * pi * (radio*radio)));
            Console.WriteLine("el volumen es: " + (4 / 3 * pi * (radio*radio*radio)));


            Console.ReadKey();
        }
    }
}
