using System;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;

            for (letra='a'; letra <= 'z'; letra++)
                Console.WriteLine("{0}", letra);

            Console.ReadLine();
        }
    }
}
