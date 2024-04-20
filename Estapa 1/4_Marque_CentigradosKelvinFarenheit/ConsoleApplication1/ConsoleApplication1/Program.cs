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
            
            int celsius;
            Console.WriteLine("Escribi los grados centígrados");
            celsius = int.Parse(Console.ReadLine());
            Console.WriteLine("A Kelvin son: " + (celsius + 273));
            Console.WriteLine("A Fahrenheit son: " + (celsius * 18 / 10 + 32));

            Console.ReadKey();
        }
    }
}
