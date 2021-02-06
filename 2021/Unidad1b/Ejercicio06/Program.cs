using System;

namespace Ejercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            const int max = 5;
            int contador = 1;
            int numero;

            while(contador <= max)
            {
                Console.WriteLine("Teclea un número: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero > 0)
                    Console.WriteLine("Es positivo");
                else
                    Console.WriteLine("Es negativo");

                contador++;
            }

            Console.ReadLine();
        }
    }
}
