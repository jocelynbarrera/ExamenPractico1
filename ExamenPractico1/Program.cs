using System;

class Program
{
    static string[] codigos = new string[3];
    static string[] titulos = new string[3];
    static string[] isbns = new string[3];
    static string[] ediciones = new string[3];
    static string[] autores = new string[3];
    static int contadorLibros = 0;

    static void Main()
    {
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("Menú Principal:");
            Console.WriteLine("1. Calcular costo de llamada");
            Console.WriteLine("2. Gestión de libros");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    CalcularCostoLlamada();
                    break;
                case 2:
                    MostrarMenuLibros();
                    break;
                case 3:
                    salir = true;
                    Console.WriteLine("Gracias por usar el sistema");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    break;
            }
        }
    }
    static void CalcularCostoLlamada()
    {
        Console.Write("Ingrese la clave de la zona (12, 15, 18, 19, 23): ");
        int clave = int.Parse(Console.ReadLine());

        double precioPorMinuto = 0;

        switch (clave)
        {
            case 12:
                precioPorMinuto = 2;
                break;
            case 15:
                precioPorMinuto = 2.2;
                break;
            case 18:
                precioPorMinuto = 4.5;
                break;
            case 19:
                precioPorMinuto = 3.5;
                break;
            case 23:
                precioPorMinuto = 6;
                break;
            default:
                Console.WriteLine("Clave de zona no válida.");
                return;
        }

        Console.Write("Ingrese el número de minutos hablados: ");
        double minutos = double.Parse(Console.ReadLine());

        double costoTotal = precioPorMinuto * minutos;
        Console.WriteLine($"El costo de la llamada es: ${costoTotal}");
    }
    static void MostrarMenuLibros()
    {
        bool salirSubMenu = false;

        while (!salirSubMenu)
        {
            Console.WriteLine("Menú de Gestión de Libros:");
            Console.WriteLine("1. Agregar un libro");
            Console.WriteLine("2. Mostrar listado de libros");
            Console.WriteLine("3. Buscar libro por código");
            Console.WriteLine("4. Editar información de un libro por código");
            Console.WriteLine("5. Volver al Menú Principal");
            Console.Write("Seleccione una opción: ");
            int opcionSubMenu = int.Parse(Console.ReadLine());

            switch (opcionSubMenu)
            {
                case 1:
                    AgregarLibro();
                    break;
                case 2:
                    MostrarListadoLibros();
                    break;
                case 3:
                    BuscarLibroPorCodigo();
                    break;
                case 4:
                    EditarLibroPorCodigo();
                    break;
                case 5:
                    salirSubMenu = true;
                    Console.WriteLine("Has regresado al menu principal");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    break;
            }
        }
    }
    static void AgregarLibro()
    {
        Console.Write("Ingrese el código del libro: ");
        string codigo = Console.ReadLine();
        Console.Write("Ingrese el título del libro: ");
        string titulo = Console.ReadLine();
        Console.Write("Ingrese el ISBN del libro: ");
        string isbn = Console.ReadLine();
        Console.Write("Ingrese la edición del libro: ");
        string edicion = Console.ReadLine();
        Console.Write("Ingrese el autor del libro: ");
        string autor = Console.ReadLine();

        codigos[contadorLibros] = codigo;
        titulos[contadorLibros] = titulo;
        isbns[contadorLibros] = isbn;
        ediciones[contadorLibros] = edicion;
        autores[contadorLibros] = autor;

        contadorLibros++;

        Console.WriteLine("Libro agregado con éxito.");
    }
    static void MostrarListadoLibros()
    {
        Console.WriteLine("Listado de Libros:");
        Console.WriteLine("Código | Título | ISBN | Edición | Autor");
        for (int i = 0; i < contadorLibros; i++)
        {
            Console.WriteLine($"{codigos[i]} | {titulos[i]} | {isbns[i]} | {ediciones[i]} | {autores[i]}");
        }
    }
    static void BuscarLibroPorCodigo()
    {
        Console.Write("Ingrese el código del libro a buscar: ");
        string codigoBuscado = Console.ReadLine();

        for (int i = 0; i < contadorLibros; i++)
        {
            if (codigos[i] == codigoBuscado)
            {
                Console.WriteLine("Libro encontrado:");
                Console.WriteLine($"Código: {codigos[i]}");
                Console.WriteLine($"Título: {titulos[i]}");
                Console.WriteLine($"ISBN: {isbns[i]}");
                Console.WriteLine($"Edición: {ediciones[i]}");
                Console.WriteLine($"Autor: {autores[i]}");
                return;
            }
        }
        Console.WriteLine("Libro no encontrado.");
    }
    static void EditarLibroPorCodigo()
    {
        Console.Write("Ingrese el código del libro a editar: ");
        string codigoBuscado = Console.ReadLine();

        for (int i = 0; i < contadorLibros; i++)
        {
            if (codigos[i] == codigoBuscado)
            {
                Console.WriteLine("Ingrese los nuevos datos del libro:");
                Console.Write("Título: ");
                titulos[i] = Console.ReadLine();
                Console.Write("ISBN: ");
                isbns[i] = Console.ReadLine();
                Console.Write("Edición: ");
                ediciones[i] = Console.ReadLine();
                Console.Write("Autor: ");
                autores[i] = Console.ReadLine();
                Console.WriteLine("Libro editado con éxito.");
                return;
            }
        }
        Console.WriteLine("Libro no encontrado.");
    }
}
