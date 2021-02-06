using System;

namespace Ejercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Teclea un número (0 para salir): ");
            numero = Convert.ToInt32(Console.ReadLine());

            while(numero != 0)
            {
                if (numero > 0)
                    Console.WriteLine("Es positivo");
                else
                    Console.WriteLine("Es negativo");

                Console.WriteLine("\nTeclea un número (0 para salir): ");
                numero = Convert.ToInt32(Console.ReadLine());
            }

            Console.ReadLine();
        }
    }
}
