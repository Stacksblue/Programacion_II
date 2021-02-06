using System;

namespace Ejemplo08
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = {2, 4, 5, 8, 11};

            foreach(int elemento in arreglo)
            {
                Console.WriteLine("{0}", elemento);
            }

            for(int i = 0; i < 5; i++)
            { 
                Console.WriteLine("{0}", arreglo[i]);
            }

            Console.ReadLine();
        }
    }
}
