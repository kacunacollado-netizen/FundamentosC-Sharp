List<string> estudiantes = new List<string>()
{
    "Luis",
    "Ana",
    "Carlos",
    "María"
};

foreach (string nombre in estudiantes)
{
    if (nombre == "Ana")
    {
        continue;
    }

    Console.WriteLine("Hola " + nombre);
}
