using System;

namespace Unidad1
{
    class Program
    {
        /// <summary>
        /// Funcion principal
        /// </summary>
        /// <param name="args">Arreglo argumentos tipo string</param>
        static void Main(string[] args)
        {
            /* 
             * Inicializacion
             * de variables
             */
            int num1 = 234;
            int num2 = 458;
            int suma = num1 + num2; // Sumatoria

            Console.WriteLine("La suma de {0} y {1} es: {2}", num1, num2, suma);
            Console.ReadLine();
        }
    }
}
