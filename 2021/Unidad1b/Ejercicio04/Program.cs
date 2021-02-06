using System;

namespace Ejercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            const int valido = 456;
            const int max_intentos = 3;

            int clave, intentos = 0;

            do 
            { 
                Console.WriteLine("Introduzca su clave numérica: ");
                clave = Convert.ToInt32(Console.ReadLine());

                if (clave != valido)
                { 
                    Console.WriteLine("No válida");
                    intentos++;
                }

                if (intentos == max_intentos)
                    break;

            } while(clave != valido);

            if (intentos < max_intentos)
                Console.WriteLine("Aceptada");

            Console.ReadLine();
        }
    }
}
