using System;

namespace Ejemplo03
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.WriteLine("Ingrese el primer un número:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo un número:");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 % num2 == 0)
                Console.WriteLine("El número {0} es multiplo de {1}", num1, num2);
            else
                Console.WriteLine("El número {0} no es multiplo de {1}", num1, num2);

            Console.ReadLine();
        }
    }
}
