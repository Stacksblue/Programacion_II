using System;
using System.IO;

namespace registros
{
    class Program
    {
        static string rutaArchivo;
        static string nombreArchivo;
        static char delimitador = ',';

        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                string proc = args[0];
                string archivo = args[1];

                if (DirectorioValido(archivo))
                {
                    if (proc == "-n" || proc == "-o")
                    {
                        if (ArchivoValido(archivo, proc))
                            Menu();
                        else
                            Console.WriteLine("Ejecución abortada.");
                    }
                    else
                        Console.WriteLine("Operador {0} no es válido.");
                }
            }
            else
                MostrarAyuda();
        }

        static void Menu()
        {
            int op;
            do
            {
                Console.Clear();
                Console.WriteLine("+-----------------------+");
                Console.WriteLine("|   Registro de Datos   |");
                Console.WriteLine("+--- -------------------+");
                Console.WriteLine("| 1 - Ver registros     |");
                Console.WriteLine("| 2 - Agregar registros |");
                Console.WriteLine("| 3 - Borrar registro   |");
                Console.WriteLine("| 4 - Salir             |");
                Console.WriteLine("+-----------------------+");
                string resp = SolicitarValor("Opción: ");

                op = int.TryParse(resp, out int num) ? num : 0;

                switch (op)
                {
                    case 1:
                        MostrarRegistro();
                        break;
                    case 2:
                        AgregarRegistro();
                        break;
                    case 3:
                        BorrarRegistro();
                        break;
                    default:
                        break;
                }

            } while (op >= 1 && op <= 3);
        }

        static void MostrarRegistro()
        {
            Console.Clear();

            // Tarea: Insertar logica mostrar bloques de 25 lineas por pantalla.

            string archivo = Path.Combine(rutaArchivo, nombreArchivo);
            int idx = 0;

            using (StreamReader reader = new StreamReader(archivo))
            {
                while (!reader.EndOfStream)
                {
                    string[] valor = reader.ReadLine().Split(delimitador);

                    if (idx == 0)
                    {
                        Console.WriteLine("      {0}{1}{2}", valor[0].ToUpper().PadRight(25), valor[1].ToUpper().PadRight(25), valor[2].ToUpper().PadRight(30));
                        Console.WriteLine("{0}", new string('-', 80));
                    }
                    else
                        Console.WriteLine("{0}{1}{2}{3}", idx.ToString().PadRight(6), valor[0].PadRight(25), valor[1].PadRight(25), valor[2].PadRight(30));

                    idx++;
                }
            }

            Console.WriteLine("{0}", new string('-', 80));
            string resp = SolicitarValor("Presione [A]gregar | [B]orrar | Cualquier tecla para salir: ");

            if (resp == "A" || resp == "a")
                AgregarRegistro();
            else if (resp == "B" || resp == "b")
                BorrarRegistro();
        }

        static void AgregarRegistro()
        {
            Console.Clear();
            Console.WriteLine("- Agregar Registro -");
            Console.WriteLine("  Dejar campos en blanco para salir.\n\n");

            string archivo = Path.Combine(rutaArchivo, nombreArchivo);

            string nombre = SolicitarValor("Nombre: ");
            string apellido = SolicitarValor("Apellido: ");
            string email = SolicitarValor("Email: ");

            if (!String.IsNullOrEmpty(nombre) && !String.IsNullOrEmpty(apellido) && !String.IsNullOrEmpty(email))
            {
                try
                {
                    File.AppendAllText(archivo, $"{nombre}{delimitador}{apellido}{delimitador}{email}");
                    Console.WriteLine("\n ** Registro agregado **");
                    Console.ReadKey();
                }
                catch (Exception err)
                {
                    Console.WriteLine("\nError al agregar registro.\n{0}", err.Message);
                }
            }

        }

        static void BorrarRegistro()
        {
            Console.Clear();
            Console.WriteLine("- Borrar Registro -");

            string linea = SolicitarValor("Igrese el número de línea a eliminar: ");

            int indice = int.TryParse(linea, out int num) ? num : -1;

            if (indice >= 0)
            {
                // Tarea: Insertar logica para eliminar linea.
            }

        }

        static bool ArchivoValido(string _archivo, string _proceso)
        {
            bool valido = true;

            if (!String.IsNullOrEmpty(_archivo) && !String.IsNullOrEmpty(_proceso))
            {
                nombreArchivo = Path.GetFileName(_archivo);

                string nuevoArchivo = Path.Combine(rutaArchivo, nombreArchivo);
                string[] respAfirmativa = { "SI", "Si", "si", "S", "s" };

                bool crearArchivo = false;

                if (_proceso == "-n")
                {
                    if (File.Exists(nuevoArchivo))
                    {
                        string resp = SolicitarValor($"El archivo {nuevoArchivo} ya existe. ¿Desea sobrescribirlo? [Si/No]: ");
                        crearArchivo = Array.IndexOf(respAfirmativa, resp) > -1;
                    }
                    else
                        crearArchivo = true;
                }
                else
                {
                    if (!File.Exists(nuevoArchivo))
                    {
                        string resp = SolicitarValor($"El archivo {nuevoArchivo} no existe. ¿Desea crearlo? [Si/No]: ");
                        crearArchivo = Array.IndexOf(respAfirmativa, resp) > -1;
                        if (!crearArchivo)
                            valido = false;
                    }
                }

                if (crearArchivo)
                {
                    try
                    {
                        File.Create(nuevoArchivo).Close();
                        File.AppendAllText(nuevoArchivo, $"Nombre{delimitador}Apellido{delimitador}Email");
                    }
                    catch (Exception err)
                    {
                        valido = false;
                        Console.WriteLine("Error al crear archivo.\n{0}", err.Message);
                    }
                }

            }

            return valido;
        }

        static bool DirectorioValido(string _archivo)
        {
            string rutaAplicacion = Directory.GetCurrentDirectory();

            if (!String.IsNullOrEmpty(_archivo))
            {
                string directorioArchivo = Path.GetDirectoryName(_archivo);

                if (!String.IsNullOrEmpty(directorioArchivo))
                {
                    if (!Directory.Exists(directorioArchivo))
                    {
                        Directory.CreateDirectory(directorioArchivo);
                        rutaArchivo = directorioArchivo;
                    }
                    else
                        rutaArchivo = directorioArchivo;
                }
                else
                    rutaArchivo = rutaAplicacion;
            }

            return !String.IsNullOrEmpty(rutaArchivo);
        }

        static string SolicitarValor(string _solicitud)
        {
            Console.Write(_solicitud);
            return Console.ReadLine();
        }

        static void MostrarAyuda()
        {
            Console.WriteLine("\nLa aplicación espera los siguientes parámetros:");
            Console.WriteLine("   -n <archivo>    Crea un archivo CSV en la ruta y nombre especificada.");
            Console.WriteLine("   -o <archivo>    Abre un archivo CSV existente");
            Console.WriteLine("\nEjemplo:");
            Console.WriteLine("   > registros.exe -n C:\\datos\\clientes.csv");
            Console.WriteLine("   > registros.exe -o C:\\datos\\clientes.csv\n");

        }
    }
}
