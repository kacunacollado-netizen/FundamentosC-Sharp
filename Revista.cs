// La clase Revista también hereda de Producto

public class Revista : Producto
{
    // Atributo propio de las revistas
    public string Editorial { get; set; }

    public Revista(string id, string nombre, string editorial)
        : base(id, nombre)
    {
        Editorial = editorial;
    }

    // Polimorfismo: sobrescribimos el método MostrarInfo
    public override void MostrarInfo()
    {
        Console.WriteLine($"Revista -> ID: {Id} | Nombre: {Nombre} | Editorial: {Editorial}");
    }

    public override void CalcularPrecio()
    {
        // Se agregará en el segundo avance
    }
}