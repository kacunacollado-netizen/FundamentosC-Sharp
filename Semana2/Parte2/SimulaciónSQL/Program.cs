using System;

class Program
{
    static void Main(string[] args)
    {
        string consulta =
            "SELECT * FROM Usuarios WHERE usuario = @usuario AND password = @password";

        Console.WriteLine("Consulta SQL segura:");
        Console.WriteLine(consulta);

        // Se usan parámetros para evitar inyección SQL porque es más seguro que ocntatenar, ya que al contatenar se mezcla información SQL( código) con datos que puede ingresar el usuario.

        Console.ReadLine();
    }
}