using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Programación
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@" 
 ██████  ██████  ██████  ███████ ██████  ███████      █████  ███    ██ ██████       ██████   ██████  
██    ██ ██   ██ ██   ██ ██      ██   ██ ██          ██   ██ ████   ██ ██   ██     ██       ██    ██ 
██    ██ ██████  ██   ██ █████   ██████  ███████     ███████ ██ ██  ██ ██   ██     ██   ███ ██    ██ 
██    ██ ██   ██ ██   ██ ██      ██   ██      ██     ██   ██ ██  ██ ██ ██   ██     ██    ██ ██    ██ 
 ██████  ██   ██ ██████  ███████ ██   ██ ███████     ██   ██ ██   ████ ██████       ██████   ██████    ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Bienvendio a nuestro restaurante, que desea hacer?");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("1. Ver nuestro menú ");
            Console.WriteLine("2. Nuestro GitHub ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            Console.Write("Elección: ");
            int decision; 
            string resultado = Console.ReadLine();
            while (!int.TryParse(resultado, out decision) | decision <1 | decision > 2)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No es una opción válida");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
                Console.Write("Elección: ");
                resultado = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------");

            switch (decision)
            {
                case 1:

                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Es intolerante o alergico a algún ingrediente? (si o no): ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    string intolerante = Console.ReadLine();
                    while (intolerante != "si" & intolerante != "no")
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("No es una opción válida");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Es intolerante o alergico a algún ingrediente? (si o no): ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        intolerante = Console.ReadLine();
                    }
                    Console.WriteLine();
                    if (intolerante == "si")
                    {
                        string intolerancia = Orden.Pregunta();
                        Orden.Menu();
                        Console.WriteLine();
                        Console.WriteLine($"No incluir nada con: {intolerancia}");
                        Console.ReadKey();
                        Entrega.Decision();
                        Pago.Metodo();
                    }
                    else
                    {
                        Orden.Menu();
                        Entrega.Decision();
                        Pago.Metodo();
                    }
                    break;

                case 2:

                    string[] lines = System.IO.File.ReadAllLines(@"C:\Users\publi\source\repos\Proyecto_Final_Programación\Información.txt");
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }
                    break;

                default:
                    break;
            }

        }
    }
}
