﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Marque_HolaNombre
{
    class Program
    {

        static void Main(string[] args)
        {
            string nombre;
            Console.WriteLine("¿Cual es tu nombre?");
            nombre = Console.ReadLine();
            Console.WriteLine("¿hola? " + nombre );

            Console.ReadKey();
        }
    }
}
