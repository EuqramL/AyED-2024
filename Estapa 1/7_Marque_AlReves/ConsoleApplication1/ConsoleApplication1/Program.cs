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
            string letra1;
            Console.WriteLine("escribi una letra");
            letra1 = Console.ReadLine();

            string letra2;
            Console.WriteLine("escribi otra");
            letra2 = Console.ReadLine();

            string letra3;
            Console.WriteLine("y escribi otra");
            letra3 = Console.ReadLine();


            Console.WriteLine(letra3 + letra2 + letra1);

            Console.ReadKey();
        }
    }
}
