using System;
using System.Globalization;

namespace Ejemplo12
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 12.345678;

            var formato = new CultureInfo("fr-FR").NumberFormat;

            Console.WriteLine(num.ToString());
            Console.WriteLine(num.ToString("N1"));
            Console.WriteLine(num.ToString("N3"));
            Console.WriteLine(num.ToString("N2", formato));
            Console.WriteLine(num.ToString("#.#"));
            Console.WriteLine(num.ToString("#.###"));

            Console.ReadLine();
        }
    }
}
