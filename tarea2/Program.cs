using System;

namespace tarea2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Bienvenido a tarea1 ;3");

            Random aleatorio = new Random();
            string respuesta = "s";
            int dado1 = 0, total = 0, vidas = 3, ara = 0,turno =0, dado2 = 0;//tiroA = 0,
            Console.WriteLine("tines " + vidas + "vidas");
            while (respuesta == "s" && total < 100 && vidas != 0)
            {
                Console.WriteLine("¿tirar el dado?");
                respuesta = Console.ReadLine();
                while (respuesta != "s" && respuesta != "n")
                {
                    Console.WriteLine("¿Deseas tirar el dado otra vez? (s/n)");
                    respuesta = Console.ReadLine();
                }

                if (respuesta == "s")
                {
                    dado1 = aleatorio.Next(1, 7);
                    Console.WriteLine("tu dado es: " + dado1);
                    total += dado1;
                    Console.WriteLine("tu total actual es: " + total);
                    if (turno == 2) //consecutivos 1s
                    {
                        vidas--;
                        Console.WriteLine("tines " + vidas + "vidas");
                        turno = 0;
                    }
                    if (ara == 3)
                    {
                        dado2 = aleatorio.Next(1, 7);
                        Console.WriteLine("tu dado2 es: " + dado2);
                        total += dado2;
                        if (dado1 == dado2)
                        {
                            vidas++;
                            Console.WriteLine("tines " + vidas + "vidas");
                        }
                        ara = 0;
                    }
                    //tiroA = dado1;
                    //ganar-perder
                    if (vidas == 0)
                    {
                        Console.WriteLine("Se quedo sin vidas mijo");
                        break;
                    }
                    if (total >= 100)
                    {
                        Console.WriteLine("no me lo creo ganaste");
                        respuesta = "n";
                        Console.ForegroundColor = ConsoleColor.Green;
                        string pajarito =
                          "\n  ^ ^" +
                          "\n (O,O)" +
                          "\n (   )" +
                          "\n  T T";
                        Console.WriteLine(pajarito);

                    }
                    ara++;
                    turno++;
                }
                else
                {
                    Console.WriteLine("le estan saliendo como plumas mijo");
                    Console.WriteLine("te falto " + (100 - total));
                    break;
                }

            }
        }
    }
}
