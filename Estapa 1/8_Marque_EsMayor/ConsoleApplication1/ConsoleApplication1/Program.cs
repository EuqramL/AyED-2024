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
            int edad;
            Console.WriteLine("¿cuantos años tenes?");
            edad = int.Parse(Console.ReadLine());

            if (edad < 18)
            {
                Console.WriteLine("sos menor de edad");
            }
            else if (edad > 18)
            {
                Console.WriteLine("sos mayor de edad");
            }
            else
            {
                Console.WriteLine("sos mayor de edad");
            }

            Console.ReadKey();
        }
    }
}
