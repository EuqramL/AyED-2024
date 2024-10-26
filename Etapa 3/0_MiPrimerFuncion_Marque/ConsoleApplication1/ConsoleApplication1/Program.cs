using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static string Saludar(string x)
        {
            x = "Hola " + x;
            return x;
        }
        static void Main(string[] args)
        {
                Console.WriteLine("como te llamas?");
                string nombre = Console.ReadLine();
                Console.WriteLine(Saludar(nombre));

                Console.ReadKey();
            }
    }
}
