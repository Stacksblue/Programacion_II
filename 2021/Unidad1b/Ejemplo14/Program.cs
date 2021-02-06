using System;

namespace Ejemplo14
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(ObtenerValor("Ingrese un número entero: "));
            string nombre = ObtenerValor("Ingrese nombre del Alumno:");

            Console.WriteLine("Número es {0}", num);
            Console.WriteLine("Alumno: {0}", nombre);

            Console.ReadLine();
        }

        static string ObtenerValor(string prompt) 
        { 
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }
    }
}
