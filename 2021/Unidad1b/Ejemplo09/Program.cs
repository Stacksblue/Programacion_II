using System;

namespace Ejemplo09
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] planetas = {"Mercurio", "Venus", "Marte", "Tierra", "Jupiter", "Urano", "Saturno"};

            foreach(string elemento in planetas)
                Console.WriteLine(elemento);

            Console.ReadLine();
        }
    }
}
