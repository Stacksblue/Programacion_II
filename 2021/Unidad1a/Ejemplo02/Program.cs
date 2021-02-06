using System;

namespace Ejemplo02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, suma;

            Console.WriteLine("Ingrese el primer número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            suma = num1 + num2;

            Console.WriteLine("La suma de {0} y {1} es: {2}", num1, num2, suma);
            Console.ReadLine();
        }
    }
}
