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
            int numero;
            Console.WriteLine("escribi un numero");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("por 1 = " + numero*1);
            Console.WriteLine("por 2 = " + numero * 2);
            Console.WriteLine("por 3 = " + numero * 3);
            Console.WriteLine("por 4 = " + numero * 4);
            Console.WriteLine("por 5 = " + numero * 5);
            Console.WriteLine("por 6 = " + numero * 6);
            Console.WriteLine("por 7 = " + numero * 7);
            Console.WriteLine("por 8 = " + numero * 8);
            Console.WriteLine("por 9 = " + numero * 9);
            Console.WriteLine("por 10 = "+ numero * 10);

            Console.ReadKey();
        }
    }
}
