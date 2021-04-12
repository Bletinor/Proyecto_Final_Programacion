using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Programación
{
    class Pago
    {
        public static void Metodo()
        {
            //Presenta el título del proceso en color verde
            Console.WriteLine("-------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"____ ____ ____ _  _ ____    ___  ____    ___  ____ ____ ____
|___ |  | |__/ |\/| |__|    |  \ |___    |__] |__| | __ |  |
|    |__| |  \ |  | |  |    |__/ |___    |    |  | |__] |__|
                                                             ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("-------------------------------------------------------------");

            //Imprime la factura + el total
            for (int i = 0; i < Orden.pedido.Count; i++)
            {
                Console.WriteLine($"{Orden.cantidad[i]}x {Orden.pedido[i]} a {Orden.costo[i]} pesos con {Orden.itbis[i]} de ITBIS");
            }
            decimal vTotalTodo = Orden.total.Sum();
            decimal vTotalItbis = Orden.itbis.Sum();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("El total a pagar es: {0}", vTotalTodo + vTotalItbis);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();

            //Pregunta si se usará comprobante fiscal
            string resultado;
            Console.Write("Desea Comprobante Fiscal: ");
            string vComprobante = (Console.ReadLine());

            //Valida el input
            while (vComprobante != "si" & vComprobante != "Si" & vComprobante != "no" & vComprobante != "No")
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No es una opción válida");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
                Console.Write("Desea Comprobante Fiscal ");
                vComprobante = Console.ReadLine();
            }
            if (vComprobante == "Si" || vComprobante == "si")
            {
                //Pide como ingreso el RNC
                Console.WriteLine();
                Console.Write("Ingrese RNC: ");
                string vRNC = (Console.ReadLine());
            }
            Console.WriteLine();

            //Pregunta el método de pago
            Console.WriteLine("Como desea Pagar");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("1. Efectivo");
            Console.WriteLine("2. Tarjeta");
            Console.WriteLine("3. Transferencia");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();

            string vNombreCliente = "";

            double vOpcion;
            Console.Write("Elección: ");
            resultado = Console.ReadLine();
            Console.WriteLine();

            //Valida el input
            while (!double.TryParse(resultado, out vOpcion) & vOpcion < 1 & vOpcion > 3)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No es una opción válida");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
                Console.Write("Elección: ");
                resultado = Console.ReadLine();
            }

            switch (vOpcion)
            {
                //Método de pago con efectivo
                case (1):
                    Console.WriteLine("----------------------------------");
                    Console.Write("Nombre de quien realiza el pago: ");
                    vNombreCliente = Console.ReadLine();
                    Console.WriteLine("");

                    Console.Write("Ingrese con cuanto va a pagar: ");
                    int vPago;
                    resultado = Console.ReadLine();

                    //Valida el input
                    while (!int.TryParse(resultado, out vPago) & vPago < vTotalTodo)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Le faltan: {0} pesos", (vTotalTodo - vPago));
                        Console.Write("De mas dinero porfavor: ");
                        vPago += int.Parse(Console.ReadLine());
                    }
                    int devuelta = (int)(vPago - vTotalTodo);

                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("DEVUELTA");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    int[] vMoneda = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                    if (devuelta > 2000)
                    {
                        vMoneda[0] = devuelta / 2000;
                        devuelta -= (vMoneda[0] * 2000);
                        Console.WriteLine("Billetes de 2000: " + vMoneda[0]);
                    }
                    if (devuelta > 999)
                    {
                        vMoneda[1] = devuelta / 1000;
                        devuelta -= (vMoneda[1] * 1000);
                        Console.WriteLine("Billetes de 1000: " + vMoneda[1]);
                    }
                    if (devuelta > 499)
                    {
                        vMoneda[2] = devuelta / 500;
                        devuelta -= (vMoneda[2] * 500);
                        Console.WriteLine("Billetes de 500: " + vMoneda[2]);
                    }
                    if (devuelta > 199)
                    {
                        vMoneda[3] = devuelta / 200;
                        devuelta -= (vMoneda[3] * 200);
                        Console.WriteLine("Billetes de 200: " + vMoneda[3]);
                    }
                    if (devuelta > 99)
                    {
                        vMoneda[4] = devuelta / 100;
                        devuelta -= (vMoneda[4] * 100);
                        Console.WriteLine("Billetes de 100: " + vMoneda[4]);
                    }
                    if (devuelta > 49)
                    {
                        vMoneda[5] = devuelta / 50;
                        devuelta -= (vMoneda[5] * 50);
                        Console.WriteLine("Billetes de 50: " + vMoneda[5]);
                    }
                    if (devuelta > 24)
                    {
                        vMoneda[6] = devuelta / 25;
                        devuelta -= (vMoneda[6] * 25);
                        Console.WriteLine("Monedas de 25: " + vMoneda[6]);
                    }
                    if (devuelta > 9)
                    {
                        vMoneda[7] = devuelta / 10;
                        devuelta -= (vMoneda[7] * 10);
                        Console.WriteLine("Monedas de 10: " + vMoneda[7]);
                    }
                    if (devuelta > 4)
                    {
                        vMoneda[8] = devuelta / 5;
                        devuelta -= (vMoneda[8] * 5);
                        Console.WriteLine("Monedas de 5: " + vMoneda[8]);
                    }
                    if (devuelta > 0)
                    {
                        vMoneda[9] = devuelta / 1;
                        devuelta -= (vMoneda[9] * 1);
                        Console.WriteLine("Monedas de 1: " + vMoneda[9]);
                    }
                    Console.WriteLine();
                    break;
                case (2):

                    //Método de pago con tarjeta
                    Console.WriteLine("--------------");
                    Console.Write("A nombre de quien esta la tarjeta: ");
                    vNombreCliente = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("Ingrese su numero de tarjeta: ");
                    string vNumeroT = (Console.ReadLine());
                    Console.WriteLine();
                    string Text = vNumeroT.Substring(0, 1);
                    Console.WriteLine("Ingrese la fecha de vencimiento: ");
                    Console.Write("Día: ");
                    string vDiaVen = (Console.ReadLine());
                    Console.Write("Año:");
                    string vAnoVen = (Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Ingrese codigo de seguridad: : ");
                    string vCodigoSeg = (Console.ReadLine());
                    Console.WriteLine();

                    if (Text == "4")
                    {
                        Console.WriteLine("Tarjeta Visa Aceptada");
                    }
                    else if (Text == "5")
                    {
                        Console.WriteLine("Tarjeta Matercard Aceptada");
                    }
                    break;

                case (3):

                    //Método de pago con transferencia
                    Console.WriteLine("--------------");
                    Console.WriteLine("Porfavor depositar al siguiente numero: 1934900049 para Orders and Go");
                    Console.WriteLine("--------------");

                    Console.Write("Ingrese cuanto va a despositar pagar: ");
                    int vPagoT;
                    resultado = Console.ReadLine();
                    Console.WriteLine();

                    //Valida el input
                    while (!int.TryParse(resultado, out vPagoT))
                    {
                        Console.WriteLine("No es una opción válida");
                        Console.Write("Elección: ");
                        resultado = Console.ReadLine();
                    }

                    //Calcula cuanto falta para poder pagar la factura
                    while (vPagoT < vTotalTodo)
                    {
                        Console.WriteLine("Le faltan: {0} pesos", (vTotalTodo - vPagoT));
                        Console.Write("Favor agregar mas: ");
                        vPagoT += int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine();
                    Console.Write("A nombre de quien es la tranferencia:  ");
                    vNombreCliente = Console.ReadLine();

                    break;

                default:
                    Console.WriteLine("Porfavor ingrese una opcion valida");
                    break;
            }

            //Aprovacion del pago
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine(@"
____ ____ _  _ ___  ____ ____ ___  ____ _  _ ___ ____
|    |  | |\/| |__] |__/ |  | |__] |__| |\ |  |  |___
|___ |__| |  | |    |  \ |__| |__] |  | | \|  |  |___ ");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ESTIMADO: {0}", vNombreCliente);
            Console.WriteLine();
            Console.WriteLine("Le notificamos que su a sido procesado de manera exitosa");
            Console.WriteLine("Adjunto encontrara su comprobante de pago");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();

            //Factura Final
            string vMetodoDePago;
            Console.ForegroundColor = ConsoleColor.Red;
            if (vOpcion == 1)
            {
                vMetodoDePago = "Efectivo";
            }
            else if (vOpcion == 2)
            {
                vMetodoDePago = "Tarjeta de credito";
            }
            else
            {
                vMetodoDePago = "Tranferecia";
            }

            Console.WriteLine("ORDERS & GO");
            Console.WriteLine("Comprobante de pago");
            Console.WriteLine();

            Console.WriteLine("Recibimos de: {0} ", vNombreCliente);
            Console.WriteLine();
            Console.WriteLine("La suma de: ");
            for (int i = 0; i < Orden.pedido.Count; i++)
            {
                Console.WriteLine($"{Orden.cantidad[i]}x {Orden.pedido[i]} a {Orden.costo[i]} pesos con {Orden.itbis[i]} de ITBIS");
            }
            Console.WriteLine("");
            Console.WriteLine("Totales RD$: {0}", vTotalTodo + vTotalItbis);
            Console.WriteLine("");
            Console.WriteLine("Metodo de pago: {0} ", vMetodoDePago);
            Console.WriteLine("");

            Console.WriteLine("Para cualquier duda o solicitud adicional puede contactarnos por estas vias: ");
            Console.WriteLine("");
            Console.WriteLine("ORDERS & GO");
            Console.WriteLine("TELEFONO: 809-534-0663");
            Console.WriteLine("CORREO: Ordes&Go@support.com");
            Console.WriteLine("");
            Console.WriteLine("Gracias Por Preferir Nuestros Servicios!");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }
}
