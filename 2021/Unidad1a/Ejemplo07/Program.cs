using System;

namespace Ejemplo07
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

            Console.WriteLine("Ingrese una operación (1 = resta; 2 = suma; 3 = multiplicacion; 4 = division):");
            operacion = Convert.ToInt32(Console.ReadLine());

            switch (operacion)
            {
                case 1:
                    resultado = num1 - num2;
                    break;
                case 2:
                    resultado = num1 + num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    resultado = num1 / num2;
                    break;
                default:
                    resultado = 0;
                    break;
            }

            Console.WriteLine("El resultado es {0}", resultado);
            Console.ReadLine();
        }
    }
}
