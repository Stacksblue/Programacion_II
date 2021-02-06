using System;

namespace Ejemplo08
{
    class Program
    {
        static void Main(string[] args)
        {
            char tecla;

            Console.WriteLine("Presione una tecla");
            tecla = Convert.ToChar(Console.ReadLine());

            switch (tecla)
            {
                case ' ':
                    Console.WriteLine("Espacio");
                    break;
                case '1':
                    goto case '0';
                case '2':
                    goto case '0';
                case '3':
                    goto case '0';
                case '4':
                    goto case '0';
                case '5':
                    goto case '0';
                case '6':
                    goto case '0';
                case '7':
                    goto case '0';
                case '8':
                    goto case '0';
                case '9':
                    goto case '0';
                case '0':
                    Console.WriteLine("Digito");
                    break;
                default:
                    Console.WriteLine("Letra");
                    break;
            }

            Console.ReadLine();
        }
    }
}
