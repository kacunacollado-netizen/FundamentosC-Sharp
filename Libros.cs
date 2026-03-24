// La clase Libro hereda de Producto.
// Esto significa que obtiene todas las propiedades y métodos de Producto.

public class Libro : Producto
{
    // Atributos específicos de un libro
    public string Autor { get; set; }
    public int Edicion { get; set; }

    // Estructura de la clase Libro.
    // Utiliza : base() para llamar a la estructura de Producto.
    public Libro(string id, string nombre, string autor, int edicion)
        : base(id, nombre)
    {
        Autor = autor;
        Edicion = edicion;
    }

    // Aquí aplicamos POLIMORFISMO.
    // Este método sobrescribe el método MostrarInfo de Producto.
    public override void MostrarInfo()
    {
        Console.WriteLine($"Libro -> ID: {Id} | Nombre: {Nombre} | Autor: {Autor} | Edición: {Edicion}");
    }

    public override void CalcularPrecio()
    {
        // Se agregará en el segundo avance
    }
}