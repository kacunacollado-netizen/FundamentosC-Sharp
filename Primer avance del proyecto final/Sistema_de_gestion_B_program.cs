using System;
using System.Collections.Generic;

// Esta es la clase principal del programa.
// Aquí se ejecuta el sistema de gestión de biblioteca.

class Program
{
    static void Main(string[] args)
    {
        // Creamos una colección tipo List para almacenar todos los productos de la biblioteca
        // Usamos List porque permite almacenar varios objetos dinámicamente.
        List<Producto> productos = new List<Producto>();

        // Productos de ejemplo para poder probar el sistema
        productos.Add(new Libro("L0100", "C# Yellow Book", " Rob Miles", 6));
        productos.Add(new Revista("R0100", "Riesgos cibernéticos de los espacios de coworking", "Byte TI"));
        productos.Add(new Tesis("T0100", "IA en educación", "UCR", "Informática"));

        int opcion;

        // Ciclo do-while para mostrar el menú hasta que el usuario decida salir
        do
        {
            Console.WriteLine("\n--- MENÚ BIBLIOTECA ---");
            Console.WriteLine("1. Ver productos disponibles");
            Console.WriteLine("2. Solicitar producto");
            Console.WriteLine("3. Ver productos en préstamo");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            opcion = int.Parse(Console.ReadLine()!);

            switch (opcion)
            {
                // Mostrar productos disponibles
                case 1:

                    foreach (var p in productos)
                    {
                        // Se utiliza el método ConsultarDisponibilidad
                        if (p.ConsultarDisponibilidad())
                        {
                            // Se aplica polimorfismo porque cada tipo de producto ejecuta su propio MostrarInfo, dependiendo de sus atributos
                            p.MostrarInfo();
                        }
                    }

                    break;

                // Solicitar producto
                case 2:

                    Console.Write("Ingrese ID del producto: ");
                    string id = Console.ReadLine()!;

                    // Buscamos el producto dentro de la lista usando Find
                    var producto = productos.Find(p => p.Id == id);

                    if (producto != null && producto.ConsultarDisponibilidad())
                    {
                        // Se selecciona como prestado
                        producto.SalidaProducto();

                        Console.WriteLine("Producto prestado correctamente.");
                    }
                    else
                    {
                        Console.WriteLine("Producto no disponible.");
                    }

                    break;

                // Mostrar productos que están en préstamo
                case 3:

                    foreach (var p in productos)
                    {
                        if (!p.ConsultarDisponibilidad())
                        {
                            p.MostrarInfo();
                        }
                    }

                    break;

            }

        } while (opcion != 4);

        Console.WriteLine("Saliendo del sistema...");
    }
}