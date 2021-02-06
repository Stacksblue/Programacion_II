using System;

namespace Ejemplo07
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;

            while(true)
            {
               Console.WriteLine("{0}", cont);

                if (cont == 5)
                    break;

                cont++;
            }

            Console.ReadLine();
        }
    }
}
