using System;

namespace Ejemplo05
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, operacion, resultado;

            Console.WriteLine("Ingrese el primer número:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese una operación (1 = resta; otro = suma):");
            operacion = Convert.ToInt32(Console.ReadLine());

            resultado = (operacion == 1) ? num1 - num2 : num1 + num2;

            Console.WriteLine("El resultado es {0}", resultado);
            Console.ReadLine();
        }
    }
}
