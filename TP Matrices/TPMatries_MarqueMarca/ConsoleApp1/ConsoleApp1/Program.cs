using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Pochimon;
            string tipo;
            int nivel;
            int estado = 0;
            int investigador = 0;
            int contadorPochi = 0;

            object[,] cantidadPochimons = new object[76, 6];


            cantidadPochimons[0, 0] = "Fila";
            cantidadPochimons[0, 1] = "Nombre";
            cantidadPochimons[0, 2] = "Tipo";
            cantidadPochimons[0, 3] = "Nivel";
            cantidadPochimons[0, 4] = "Estado";
            cantidadPochimons[0, 5] = "ivestigador asignado";


            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("--------------------------------------------------\nMenú Principal - Centro de Investigación de Pochimons\n--------------------------------------------------\n");
                Console.WriteLine("Pochimones Encontrados: " + (contadorPochi) + "/75\n");
                Console.WriteLine("1. Registrar Pochimon");
                Console.WriteLine("2. Asignar Investigador a Pochimon");
                Console.WriteLine("3. Actualizar Nivel de Pochimon");
                Console.WriteLine("4. Marcar Pochimon como Investigado");
                Console.WriteLine("5. Mostrar Información de Pochimons");
                Console.WriteLine("6. Buscar Pochimons por Tipo");
                Console.WriteLine("7. Mostrar Pochimons por Investigador");
                Console.WriteLine("8. Mostrar Pochimons Picados");
                Console.WriteLine("9. Salir");
                Console.Write("--------------------------------------------------\nIngrese la opción deseada: ");

                int opcion;
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        // Registrar Pochimon
                        {
                            for (int i = 0; i < 1; i++)
                            {
                                Console.Write("Ingrese el nombre del Pochimon: ");
                                Pochimon = Console.ReadLine();
                                Console.Write("\n");

                                Console.Write("Ingrese el tipo(A/F/P): ");
                                tipo = Console.ReadLine();
                                Console.Write("\n");

                                Console.Write("Ingrese el nivel: ");
                                nivel = int.Parse(Console.ReadLine());

                                Console.Write("\n");

                                // Guardamos la información en la matriz
                                cantidadPochimons[contadorPochi + 1, 0] = contadorPochi + 1;
                                cantidadPochimons[contadorPochi + 1, 1] = Pochimon;
                                cantidadPochimons[contadorPochi + 1, 2] = tipo;
                                cantidadPochimons[contadorPochi + 1, 3] = nivel;
                                cantidadPochimons[contadorPochi + 1, 4] = 0;
                                cantidadPochimons[contadorPochi + 1, 5] = 0;

                                contadorPochi++;
                                Console.Write("Pohimon registrado correctamente, enter para continuar");
                                Console.ReadKey();
                                Console.Clear();

                            }


                        }
                        break;


                    case 2:
                        // Asignar Investigador a Pochimon
                        Console.WriteLine("Lista de Pochimons no investigados: \n ");
                        Console.WriteLine("Fila\tNombre\tTipo\tNivel");

                        for (int i = 1; i <= contadorPochi; i++)
                        {
                            if (cantidadPochimons[i, 4].ToString() == "0")
                            {
                                Console.Write("\n" + (cantidadPochimons[i, 0]));
                                Console.Write("\t" + (cantidadPochimons[i, 1]));
                                Console.Write("\t" + (cantidadPochimons[i, 2]));
                                Console.Write("\t" + (cantidadPochimons[i, 3]) + "\t");
                            }
                        }

                        Console.Write("\nIngrese el número de fila del Pochimon a asignar: ");
                        int filaSeleccionada = int.Parse(Console.ReadLine());

                        if (filaSeleccionada >= 1 && filaSeleccionada <= contadorPochi &&
                            cantidadPochimons[filaSeleccionada, 4].ToString() == "0" && (cantidadPochimons[filaSeleccionada, 5].ToString() == "0"))
                        {
                            Console.Write("Ingrese el codigo del investigador: ");
                            investigador = int.Parse(Console.ReadLine());

                            cantidadPochimons[filaSeleccionada, 5] = investigador;
                            cantidadPochimons[filaSeleccionada, 4] = 1;
                            Console.WriteLine("Investigador asignado correctamente y estado actualizado.");
                        }
                        else
                        {
                            Console.WriteLine("Número de fila inválido o el Pochimon ya está investigado o tiene un investigador asignado.");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        // Actualizar el nivel de un Pochimon
                        Console.WriteLine("Fila\tNombre\tNivel");
                        for (int i = 1; i <= contadorPochi; i++)
                        {
                            Console.Write("\n" + (cantidadPochimons[i, 0]));
                            Console.Write("\t" + (cantidadPochimons[i, 1]));
                            Console.Write("\t" + (cantidadPochimons[i, 3]));

                        }
                        Console.Write("\nIngrese el número de fila del Pochimon: ");
                        int filaSeleccionada2 = int.Parse(Console.ReadLine());

                        if (filaSeleccionada2 >= 1 && filaSeleccionada2 <= contadorPochi)
                        {
                            Random rand = new Random();
                            int numRandom = rand.Next(1, 4);

                            int nivelActual = Convert.ToInt32(cantidadPochimons[filaSeleccionada2, 3]);
                            cantidadPochimons[filaSeleccionada2, 3] = nivelActual + numRandom;

                            Console.WriteLine("Nivel actualizado correctamente. El nivel ha aumentado en " + numRandom);
                        }
                        else
                        {
                            Console.WriteLine("Número de fila inválido.");
                        }

                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case 4:
                        // Marcar un Pochimon como Investigado
                        Console.WriteLine("Lista de Pochimons no investigados: \n ");
                        Console.WriteLine("Fila\tNombre\tTipo\tNivel\tEstado\tInvestigador");

                        for (int i = 1; i <= contadorPochi; i++)
                        {
                            if (cantidadPochimons[i, 4].ToString() == "1")
                            {
                                Console.Write("\n" + (cantidadPochimons[i, 0]));
                                Console.Write("\t" + (cantidadPochimons[i, 1]));
                                Console.Write("\t" + (cantidadPochimons[i, 2]));
                                Console.Write("\t" + (cantidadPochimons[i, 3]));
                                Console.Write("\t" + (cantidadPochimons[i, 4]));
                                Console.Write("\t" + (cantidadPochimons[i, 5]));
                            }
                        }

                        Console.Write("\nIngrese el número de fila del Pochimon a asignar: ");
                        int filaSeleccionada3 = int.Parse(Console.ReadLine());

                        if (filaSeleccionada3 >= 1 && filaSeleccionada3 <= contadorPochi)
                        {
                            cantidadPochimons[filaSeleccionada3, 4] = 2;
                            Console.WriteLine("\nPochimon marcado como Investigado.");

                        }
                        else
                        {
                            Console.WriteLine("\nNúmero de fila inválido.");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 5:
                        // Mostrar información de todos los Pochimons
                        Console.WriteLine("--------------------------------------------------");
                        Console.WriteLine("Información de Pochimons:");
                        Console.WriteLine("Fila\tNombre\tTipo\tNivel\tEstado\tInvestigador");
                        for (int i = 1; i <= contadorPochi; i++)
                        {
                            Console.Write("\n" + (cantidadPochimons[i, 0]));
                            Console.Write("\t" + (cantidadPochimons[i, 1]));
                            Console.Write("\t" + (cantidadPochimons[i, 2]));
                            Console.Write("\t" + (cantidadPochimons[i, 3]));
                            Console.Write("\t" + (cantidadPochimons[i, 4]));
                            Console.Write("\t" + (cantidadPochimons[i, 5]));

                        }
                        Console.WriteLine("\n--------------------------------------------------");
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case 6:
                        // Buscar Pochimons por Tipo
                        Console.Write("Ingrese el tipo de Pochimon a buscar: ");
                        string tipoSeleccion = Console.ReadLine();

                        Console.WriteLine("--------------------------------------------------");
                        Console.WriteLine("Pochimons del tipo " + tipoSeleccion + ":");
                        Console.WriteLine("Fila\tNombre\tTipo");
                        for (int i = 1; i <= contadorPochi; i++)
                        {
                            if (cantidadPochimons[i, 2].ToString() == tipoSeleccion)
                            {
                                Console.Write("\n" + (cantidadPochimons[i, 0]));
                                Console.Write("\t" + (cantidadPochimons[i, 1]));
                                Console.Write("\t" + (cantidadPochimons[i, 2]));
                            }
                        }
                        Console.WriteLine("\n--------------------------------------------------");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 7:
                        //Mostrar Pochimons por Investigador
                        Console.Write("Ingrese el Investigador de Pochimon a buscar: ");
                        int invSeleccion = int.Parse(Console.ReadLine());

                        Console.WriteLine("--------------------------------------------------");
                        Console.WriteLine("Pochimons del tipo " + invSeleccion + ":");
                        Console.WriteLine("Fila\tNombre\tIvestigador");

                        for (int i = 1; i <= contadorPochi; i++)
                        {
                            if ((Convert.ToInt32(cantidadPochimons[i, 5]) == invSeleccion))
                            {
                                Console.Write("\n" + (cantidadPochimons[i, 0]));
                                Console.Write("\t" + (cantidadPochimons[i, 1]));
                                Console.Write("\t" + (cantidadPochimons[i, 5]));
                            }
                        }
                        Console.WriteLine("\n--------------------------------------------------");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 8:
                        //pochimones picados
                        Console.WriteLine("--------------------------------------------------");
                        Console.WriteLine("Pochimons picados:");
                        Console.WriteLine("Fila\tNombre\tTipo\tNivel");

                        for (int i = 1; i <= contadorPochi; i++)
                        {
                            if ((Convert.ToInt32(cantidadPochimons[i, 3]) >= 30))
                            {
                                Console.Write("\n" + (cantidadPochimons[i, 0]));
                                Console.Write("\t" + (cantidadPochimons[i, 1]));
                                Console.Write("\t" + (cantidadPochimons[i, 2]));
                                Console.Write("\t" + (cantidadPochimons[i, 3]));
                            }
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 9:
                        //Salir
                        continuar = false;
                        Console.WriteLine("Adios");
                        break;

                    default:
                        Console.WriteLine("error, ingrse otro numero");
                        Console.ReadKey();
                        Console.Clear();

                        break;
                }


            }

            Console.ReadKey();
        }
    }
}
