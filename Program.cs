using System;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado = 0, total = 0, gan = 0;
            string continuar = "s";

            if (total == 0)
            {
                dado = aleatorio.Next(1, 13);
                Console.WriteLine("Sus 3 primeros lanzamientos son:  " + dado);
                total += dado;
                dado = aleatorio.Next(1, 13);
                Console.WriteLine(dado);
                total += dado;
                dado = aleatorio.Next(1, 13);
                Console.WriteLine(dado);
                total += dado;
                Console.WriteLine("Su total es: " + total);
                Console.WriteLine("¿Desea continuar? (s/n): ");
                continuar = Console.ReadLine();
            }

            while (continuar == "s")
            {
                dado = aleatorio.Next(10, 13);
                Console.WriteLine("Dado = " + dado);
                
                if (dado %2 != 0)
                {
                    Console.WriteLine("Sacaste un impar. Perdiste.");
                    continuar = "n";
                }
                else
                {
                    total += dado;

                    if (total >= 100 || gan == 22)
                    {
                        Console.WriteLine("Ganaste!");
                        continuar = "n";
                    }
                    else
                    {
                        Console.WriteLine("Total = " + total);
                        Console.WriteLine("¿Deasea continuar? (s/n): ");
                        continuar = Console.ReadLine();
                    }
                }
            }

            Console.WriteLine("Su total fue: " + total + " puntos.");
            Console.WriteLine("Gracias por participar.");
        }
    }
}
