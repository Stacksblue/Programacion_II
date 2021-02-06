using System;

namespace Ejemplo09
{
    class Program
    {
        static void Main(string[] args)
        {
            char tecla;

            Console.WriteLine("Presione una tecla");
            tecla = Convert.ToChar(Console.ReadLine());

            /*
            if (Char.IsLetterOrDigit(tecla))
                Console.WriteLine("Es una letra o digito");
            else if (Char.IsWhiteSpace(tecla))
                Console.WriteLine("Espacio");
            else if (Char.IsPunctuation(tecla))
                Console.WriteLine("Puntuacion");
            */

            switch (tecla)
            {
                case ' ':
                    Console.WriteLine("Espacio");
                    break;
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Vocal");
                    break;
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                    Console.WriteLine("Digito");
                    break;
                case '.':
                case ',':
                case ';':
                    Console.WriteLine("Signo de puntuacion");
                    break;
                default:
                    Console.WriteLine("Consonante");
                    break;
            }

            Console.ReadLine();
        }
    }
}
