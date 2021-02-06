using System;

namespace Ejemplo11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] planetas = {"Mercurio", "Venus", "Tierra", "Marte", "Jupiter",
                "Saturno", "Urano", "Neptuno"};

            Console.WriteLine("Número de elementos {0}", planetas.Length);

            Console.WriteLine("Uno o más planetas que inicien com 'M': {0}",
                Array.Exists(planetas, planeta => planeta.StartsWith("M")));

            Console.WriteLine("Uno o más planetas que inicien com 'A': {0}",
                Array.Exists(planetas, planeta => planeta.StartsWith("A")));

            Console.WriteLine("¿Tierra es un planeta?: {0}",
                Array.Exists(planetas, planeta => planeta == "Tierra"));

            Console.ReadLine();
        }
    }
}
