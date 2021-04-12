using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Proyecto_Final_Programación
{
    class Program
    {
        static void Main(string[] args)
        {
            //Presenta el título en color verde
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

            //Presenta el menú principal y recibe cual acción se va a realizar
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

            //Valida el input
            string resultado = Console.ReadLine();
            while (!int.TryParse(resultado, out decision) | decision < 1 | decision > 2)
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

                    //Pregunta si el cliente es intolerante
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
                        //Realiza el resto del programa tomando en cuenta la intolerancia
                        string intolerancia = Orden.Pregunta();
                        Orden.Menu();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"No incluir nada con: {intolerancia}");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Entrega.Decision();
                        Pago.Metodo();
                    }
                    else
                    {
                        //Realiza el resto del programa sin tomar en cuenta ninguna intolerancia
                        Orden.Menu();
                        Entrega.Decision();
                        Pago.Metodo();
                    }
                    break;

                case 2:

                    //Lleva al usuario al GitHub
                    var link = new ProcessStartInfo("iexplore.exe");
                    link.Arguments = "https://github.com/Bletinor/Proyecto_Final_Programacion";
                    Process.Start(link);
                    break;

                default:
                    break;
            }
        }
    }
}
