 namespace itm.csharp.basic
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine($"¡Hola, {nombre}! Por favor, elige un ejercicio del sigueinte menú: ");
            Menu.MostrarMenu();
            while (true)
            {
                string entrada = Console.ReadLine().ToLower();
                if (entrada == "q" || entrada == "exit")
                {
                    break;
                }

                if (int.TryParse(entrada, out int eleccion) && eleccion >= 1 && eleccion <= 15)
                {

                    switch (eleccion)
                    {
                        case 1:
                            new Challenge1().Run();
                            break;
                        case 2:
                            new Challenge2().Run();
                            break;
                        case 3:
                            new Challenge3().Run();
                            break;
                        case 4:
                            new Challenge4().Run();
                            break;
                        case 5:
                            new Challenge5().Run();
                            break;
                        case 6:
                            new Challenge6().Run();
                            break;
                        case 7:
                            new Challenge7().Run();
                            break;
                        case 8:
                            new Challenge8().Run();
                            break;
                        case 9:
                            new Challenge9().Run();
                            break;
                        case 10:
                            new Challenge10().Run();
                            break;
                        case 11:
                            new Challenge11().Run();
                            break;
                        case 12:
                            new Challenge12().Run();
                            break;
                        case 13:
                            new Challenge13().Run();
                            break;
                        case 14:
                            new Challenge14().Run();
                            break;
                        case 15:
                            new Challenge15().Run();
                            break;
                        default:
                            Console.WriteLine("Presiona una tecla para continuar...");
                            Console.ReadKey();
                            Console.Clear();
                            Menu.MostrarMenu();
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Opcion no valida. Por favor ingrese un numero entre 1 y 15 o 'q' o 'exit' para salir");
                }
            }
            Console.WriteLine("¡Hasta luego!");
        }
    }
}