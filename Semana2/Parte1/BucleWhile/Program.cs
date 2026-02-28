int numero;

while (true)
{
    Console.Write("Ingrese un número positivo o digite 0 para salir: ");
    numero = int.Parse(Console.ReadLine());

    if (numero == 0)
    {
        break;
    }

    if (numero > 100)
    {
        Console.WriteLine("Número mayor a 100. Fin del programa.");
        break;
    }

    Console.WriteLine("Número ingresado: " + numero);
}