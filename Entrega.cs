using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Programación
{
    class Entrega
    {
         public static void Decision()
        {
            int forma_entrega, forma_delivery;
            string apartamento;
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"____ ____ ____ _  _ ____    ___  ____    ____ _  _ ___ ____ ____ ____ ____ 
|___ |  | |__/ |\/| |__|    |  \ |___    |___ |\ |  |  |__/ |___ | __ |__| 
|    |__| |  \ |  | |  |    |__/ |___    |___ | \|  |  |  \ |___ |__] |  |                                                                       
");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Como quiere que se le entregue su pedido: ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("1. Delivery ");
            Console.WriteLine("2. Takeout ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            Console.Write("Elección: ");

            string resultado = Console.ReadLine();

            while (!int.TryParse(resultado, out forma_entrega) | forma_entrega < 1 | forma_entrega > 2)
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
            Console.WriteLine();
            switch (forma_entrega)
            {
                case 1:
                    Console.WriteLine("Inserte los datos de su ubicación: ");
                    location();
                    Console.WriteLine();
                    Console.WriteLine("---------------------------------------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine("Opciones de delivery: ");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("1. Dejar pedido frente a puerta del lobby");
                    Console.WriteLine("2. Recibir directamente  pedido en su apartamento");
                    Console.WriteLine("3. Recibir directamente el pedido afuera del edificio");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.Write("Elección: ");

                    resultado = Console.ReadLine();

                    while (!int.TryParse(resultado, out forma_delivery) | forma_delivery != 2 && forma_delivery != 1 && forma_delivery != 3)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("No es una opción válida");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine();
                        Console.Write("Elección: ");
                        resultado = Console.ReadLine();
                    }


                    if (forma_delivery == 2)
                    {
                        Console.WriteLine();
                        Console.Write("Inserte el número de su apartamento: ");
                        apartamento = Console.ReadLine();
                    }

                    Console.WriteLine();
                    break;

                case 2:

                    Random tiempo_espera = new Random();
                    int randomizer = tiempo_espera.Next(25, 30);
                    Console.WriteLine("Su pedido estará listo en: " + randomizer + " minutos una vez complete el pago del mismo");
                    break;

            }
            Console.WriteLine();

        }

        static void location()
        {
            string calle, sector, ciudad, país = "República Dominicana", edificio, decision;
            int numero;
            Console.Write("Calle: ");
            calle = Console.ReadLine();

            Console.Write("Número: ");
            string resultado = Console.ReadLine();
            while (!int.TryParse(resultado, out numero))
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No es una opción válida");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
                Console.Write("Número: ");
                resultado = Console.ReadLine();
            }

            Console.Write("Nombre de Apartamento o Establecimiento: ");
            edificio = Console.ReadLine();

            Console.Write("Ciudad: ");
            ciudad = Console.ReadLine();

            Console.Write("Sector: ");
            sector = Console.ReadLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nuestro restaurante solo se localiza en la República Dominicana");
            Console.WriteLine();
            Console.Write("Se encuentra usted en este país? ");
            Console.ForegroundColor = ConsoleColor.Gray;
            decision = Console.ReadLine();
            Console.WriteLine();

            while (decision != "si" & decision != "Si" & decision != "no" & decision != "No")
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No es una opción válida");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
                Console.Write("Se encuentra usted en este país? ");
                decision = Console.ReadLine();
            }

            if (decision == "si" || decision == "Si")
            {
                Console.WriteLine("Puede continuar");
            }
            else if (decision == "no" || decision == "No")
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Lo sentimos no podemos proceder con su pedido");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ReadKey();
                Environment.Exit(1);
            }

        }

    }
}
