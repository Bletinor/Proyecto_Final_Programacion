using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Programación
{
    class Orden
    {
        public static List<string> pedido = new List<string>();
        public static List<int> costo = new List<int>();
        public static List<int> cantidad = new List<int>();
        public static List<decimal> itbis = new List<decimal>();
        public static List<decimal> total = new List<decimal>();
        static public string Pregunta()
        {
            //Pregunta si es intolerante y lo devuelve para guardarlo en una variable
            Console.Write("A que es intolerante?: ");
            string intolerancia = Console.ReadLine();
            Console.WriteLine();

            return intolerancia;
        }

        static public void Menu()
        {
            //Muestra el menú y el precio línea tras línea
            Console.ForegroundColor = ConsoleColor.Blue;
            string[] menu = { @"
  __  __ ___ _  _ _   _
 |  \/  | __| \| | | | |
 | |\/| | _|| .` | |_| |
 |_|  |_|___|_|\_|\___/ ", "Agua", "Refresco", "Cerveza", "Pizza de peperoni", "Pizza de queso", "Pizza vegetariana", "Hamburguesa clásica", "Cheeseburger", "Chickenburger", "Sandwich de queso", "Sandwich de jamón", "Sandwich cubano", "Churros", "Hot dogs", "Tacos" };
            int[] precios = { 0, 20, 50, 60, 250, 225, 275, 300, 325, 350, 150, 150, 250, 75, 100, 175 };
            string[] numerador = { "index", "1. ", "2. ", "3. ", "4. ", "5. ", "6. ", "7. ", "8. ", "9. ", "10. ", "11. ", "12. ", "13. ", "14. ", "15. ", };
            Console.WriteLine($"{menu[0]}");
            Console.WriteLine();
            
            for (int i = 1; i < menu.Length; i++)
            {
                Console.WriteLine($"{numerador[i]}{menu[i]}: {precios[i]} pesos");
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine();

            //Prepara las que tendrán el pedido, el costo y cantidad luego se pasarán a arrays
            

            //Se pide cuales elementos del menú se añadiran al pedido y su cantidad
            for (int i = 0; i != 1;)
            {
                Console.Write("Ingrese el número de lo que desea ordenar o ingrese 0 para terminar de ordenar: ");
                int elecion;
                string resultado = Console.ReadLine();
                while (!int.TryParse(resultado, out elecion) | elecion < 0 | elecion > 15)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No es una opción válida");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.Write("Ingrese el número de lo que desea ordenar o ingrese 0 para terminar de ordenar: ");
                    resultado = Console.ReadLine();
                }
                if (elecion == 0)
                {
                    i++;
                }
                else
                {
                    Console.Write("Ingrese la cantidad que desea: ");
                    int qty; 
                    resultado = Console.ReadLine();
                    while (!int.TryParse(resultado, out qty))
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("No es una opción válida");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine();
                        Console.Write("Ingrese la cantidad que desea: ");
                        resultado = Console.ReadLine();
                    }
                    pedido.Add(menu[elecion]);
                    costo.Add(precios[elecion]);
                    cantidad.Add(qty);
                    itbis.Add(qty * precios[elecion] * 0.18m);
                    total.Add(qty * precios[elecion] + itbis[i]);
                }
            }

            Console.WriteLine();
            for (int i = 0; i < pedido.Count; i++)
            {
                Console.WriteLine($"{cantidad[i]}x {pedido[i]} a {costo[i]} pesos con {itbis[i]} de ITBIS");
            }
            Console.WriteLine();
            Console.WriteLine($"El total a pagar es {total.Sum()} pesos");
        }
    }
}
