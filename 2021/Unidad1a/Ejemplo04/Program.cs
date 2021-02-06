using System;

namespace Ejemplo04
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Ingrese un número:");
            num = Convert.ToInt32(Console.ReadLine());

            /*
            if (num == 0)
                Console.WriteLine("El número es cero");
            else
                if (num < 0)
                    Console.WriteLine("El número es negativo");
                else
                    Console.WriteLine("El número es positivo");
            */

            if (num == 0)
                Console.WriteLine("El número es cero");
            else if (num < 0)
                Console.WriteLine("El número es negativo");
            else
                Console.WriteLine("El número es positivo");

            Console.ReadLine();
        }
    }
}
