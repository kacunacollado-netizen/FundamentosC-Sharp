// La clase Tesis también hereda de Producto

public class Tesis : Producto
{
    // Atributos propios de una tesis
    public string Universidad { get; set; }
    public string Carrera { get; set; }

    public Tesis(string id, string nombre, string universidad, string carrera)
        : base(id, nombre)
    {
        Universidad = universidad;
        Carrera = carrera;
    }

    // Aplicación de polimorfismo
    public override void MostrarInfo()
    {
        Console.WriteLine($"Tesis -> ID: {Id} | Nombre: {Nombre} | Universidad: {Universidad} | Carrera: {Carrera}");
    }

    public override void CalcularPrecio()
    {
        // Se iagregaráen el segundo avance
    }
}