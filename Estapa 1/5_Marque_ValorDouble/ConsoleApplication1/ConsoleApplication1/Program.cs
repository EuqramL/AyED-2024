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
            int x;
            Console.WriteLine("pone el ancho");
            x = int.Parse(Console.ReadLine());

            int y;
            Console.WriteLine("pone la altura");
            y = int.Parse(Console.ReadLine());

            int perimetro;
            perimetro = (x + x) + (y + y);
            Console.WriteLine("el perimetro es: " + (perimetro));

            int area;
            area = x * y;
            Console.WriteLine("el area es: " + (area));

            int diagonal;
            diagonal = (x * x) + (y * y);
            Console.WriteLine("la diagonal es: " + Math.Sqrt((diagonal)));

            Console.ReadKey();

        }
    }
}
