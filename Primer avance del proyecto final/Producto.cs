using System;

// Esta es la clase base llamada Producto.
// Representa cualquier material que exista dentro de la biblioteca
// (libros, revistas o tesis). Las demás clases heredarán de esta.

public class Producto
{
    // Propiedad que almacena el id único del producto
    public string Id { get; set; }

    // Propiedad que almacena el nombre del producto
    public string Nombre { get; set; }

    // Indica si el producto está disponible o si ya fue prestado
    public bool Disponible { get; set; }

    // Estructura de la clase Producto.
    // Se ejecuta cada vez que se crea un nuevo producto.
    public Producto(string id, string nombre)
    {
        Id = id;
        Nombre = nombre;

        // Por defecto todo producto inicia disponible
        Disponible = true;
    }

    // Método virtual que podrá ser modificado por las clases hijas.
    // Se usa para aplicar POLIMORFISMO.
    public virtual void MostrarInfo()
    {
        Console.WriteLine($"ID: {Id} - Nombre: {Nombre}");
    }

    // Método que en el segundo avance servirá para calcular el precio del préstamo según los días solicitados.
    public virtual void CalcularPrecio()
    {
        // De momento s emantiene vacío para agregarlo en el segundo avance.
    }

    // Método que permite consultar si el producto está disponible
    public bool ConsultarDisponibilidad()
    {
        return Disponible;
    }

    // Método que simula la salida del producto (cuando se presta)
    public void SalidaProducto()
    {
        Disponible = false;
    }
}