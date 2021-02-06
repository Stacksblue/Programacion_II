using System;

namespace Unidad1b
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int contador = 0; contador <= 10; contador++)
            { 
                if (contador == 5)
                    continue;

                Console.WriteLine("{0} Programación II", contador);
            }

            Console.ReadLine();
        }
    }
}
