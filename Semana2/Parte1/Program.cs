int opcion;

do
{
    Console.WriteLine("\nMENÚ");
    Console.WriteLine("1. Mostrar números pares");
    Console.WriteLine("2. Mostrar números impares");
    Console.WriteLine("3. Salir");
    Console.Write("Seleccione una opción: ");

    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            break;

        case 2:
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            break;

        case 3:
            Console.WriteLine("Saliendo del programa...");
            break;

        default:
            Console.WriteLine("Opción inválida");
            break;
    }

} while (opcion != 3);