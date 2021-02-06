using System;

namespace Ejemplo13
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 247;
            Console.WriteLine(Convert.ToString(num, 2));
            Console.WriteLine(Convert.ToString(num, 16));

            Console.WriteLine("{0}", num / 3);
            Console.WriteLine("{0}", Convert.ToDecimal(num) / 3);
            Console.WriteLine("{0}", (Convert.ToDecimal(num)/3).ToString("N4"));

            Console.ReadLine();
        }
    }
}
