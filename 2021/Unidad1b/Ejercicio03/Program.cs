using System;

namespace Ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Int32 tabla, numero;

            for (int tabla = 1; tabla <= 5; tabla++)
            {
                for (int numero = 1; numero <= 10; numero++)
                    Console.WriteLine("{0} x {1} = {2}", tabla, numero, tabla*numero);

                Console.WriteLine("\n");
            }

            Console.ReadLine();
        }
    }
}
