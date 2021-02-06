using System;

namespace Ejemplo10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Title = "Programación II - Funciones del Lenguaje";

            string[] planetas = { "Mercurio", "Venus", "Marte", "Tierra", "Jupiter", "Urano", "Saturno" };

            foreach (string elemento in planetas)
                Console.WriteLine(elemento);

            Console.ReadLine();
        }
    }
}
