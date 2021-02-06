using System;

namespace Ejemplo10
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;

            Console.WriteLine("Ingresa tu nombre");
            nombre = Console.ReadLine();

            switch (nombre)
            {
                case "Juan":
                    Console.WriteLine("Bienvenido {0}", nombre);
                    break;
                case "Pedro":
                    Console.WriteLine("Hola {0}, bienvenido", nombre);
                    break;
                default:
                    Console.WriteLine("Nombre desconocido");
                    break;
            }

            Console.ReadLine();
        }
    }
}
