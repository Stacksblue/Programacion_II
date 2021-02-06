using System;


namespace Ejemplo15
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = ObtenerValor("Ingrese su nombre:");
            string apellido = ObtenerValor("Ingrese su apellido:");
            string edad = ObtenerValor("Ingrese su edad:");

            Console.WriteLine("Informacion ingresada:");
            ImprimirInfo(nombre, apellido, edad);

            Console.ReadLine();
        }

        static string ObtenerValor(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        static void ImprimirInfo(string strNombre, string strApellido, string strEdad)
        {
            Console.WriteLine("Nombre: {0}", strNombre);
            Console.WriteLine("Apellido: {0}", strApellido);
            Console.WriteLine("Edad: {0}", strEdad);
        }
    }
}
