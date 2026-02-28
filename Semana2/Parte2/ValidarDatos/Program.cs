using System.Text.RegularExpressions;

int edad;
Console.Write("Ingrese su edad: ");

if (int.TryParse(Console.ReadLine(), out edad))
{
    Console.WriteLine("Edad válida: " + edad);
}
else
{
    Console.WriteLine("Edad inválida");
}

Console.Write("Ingrese su correo electrónico: ");
string correo = Console.ReadLine();

string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

if (Regex.IsMatch(correo, patronCorreo))
{
    Console.WriteLine("Correo válido");
}
else
{
    Console.WriteLine("Correo inválido");
}
