
using System;
using System.Collections.Generic;
using System.Linq;

namespace Semana3cot
{
    public class Program
    {
        // Guardo todos los estudiantes del sistema con una List para recorrer la información más fácil y agregar a los estudiantes.
      
        static List<Estudiante> estudiantes = new List<Estudiante>();

        // En esta cola se representa el orden en que los estudiantes van a ser atendidos, el primero que entra es el primero que sale.
        static Queue<Estudiante> cola = new Queue<Estudiante>();

        // En esta pila guarda los estudiantes que ya fueron atendidos, el último que entra es el primero que se puede consultar.
        static Stack<Estudiante> atendidos = new Stack<Estudiante>();

        static void Main(string[] args)
        {
            // Información para prueba del programa
            estudiantes.Add(new Estudiante("Jeffry", 35, "Ingenieria"));
            estudiantes.Add(new Estudiante("Maria", 20, "Medicina"));
            estudiantes.Add(new EstudianteBecado("Luis", 23, "Derecho", "Academica"));

            int opcion = 0;

            // Aquí se mantiene el menú activo hasta que el usuario decida salir
            while (opcion != 6)
            {
                Console.WriteLine("\n--- MENU ---");
                Console.WriteLine("1. Listar estudiantes");
                Console.WriteLine("2. Buscar estudiante por nombre");
                Console.WriteLine("3. Filtrar estudiantes por edad");
                Console.WriteLine("4. Agregar estudiante a la cola de atención");
                Console.WriteLine("5. Atender estudiante");
                Console.WriteLine("6. Salir");

                Console.Write("Opción: ");

                // Uso TryParse para evitar errores si el usuario escribe una entrada incorrecta.
                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1:
                        ListarEstudiantes();
                        break;

                    case 2:
                        BuscarPorCedula();
                        break;

                    case 3:
                        FiltrarPorEdad();
                        break;

                    case 4:
                        AtenderEstudiante();
                        break;

                    case 5:
                        RegistrarAtendido();
                        break;
                }
            }
        }

        // Recorre la lista y muestre la información de cada estudiante
        static void ListarEstudiantes()
        {
            foreach (var e in estudiantes)
            {
                // Aquí se aplico polimorfismo ya que cada tipo de estudiante, tiene su propia versión del método MostrarInfo()
                e.MostrarInfo();
            }
        }

        // Busco un estudiante dentro de la lista según el nombre
        static void BuscarPorCedula()
        {
            Console.Write("Nombre del estudiante: ");
            string nombre = Console.ReadLine() ?? "";

            // Uso LINQ para buscar el primer estudiante que coincida
            var estudiante = estudiantes.FirstOrDefault(e => e.GetNombre() == nombre);

            if (estudiante != null)
                estudiante.MostrarInfo();
            else
                Console.WriteLine("Estudiante no encontrado.");
        }

        // Aquí filtro estudiantes según una edad mínima 
        static void FiltrarPorEdad()
        {
            Console.Write("Edad mínima: ");

            int edad;
            int.TryParse(Console.ReadLine(), out edad);

            // LINQ ayuda a filtrar fácilmente la lista
            var resultado = estudiantes.Where(e => e.Edad >= edad);

            foreach (var e in resultado)
            {
                e.MostrarInfo();
            }
        }

        // Agrego un estudiante a la cola de atención
        static void AtenderEstudiante()
        {
            Console.Write("Nombre del estudiante: ");
            string nombre = Console.ReadLine() ?? "";

            var estudiante = estudiantes.FirstOrDefault(e => e.GetNombre() == nombre);

            if (estudiante != null)
            {
                // Enqueue agrega el estudiante al final de la cola
                cola.Enqueue(estudiante);
                Console.WriteLine("Estudiante agregado a la cola.");
            }
            else
            {
                Console.WriteLine("No se encontró el estudiante.");
            }
        }

        // Atiendo al estudiante que esté primero en la cola
        static void RegistrarAtendido()
        {
            if (cola.Count > 0)
            {
                // Dequeue saca al primer estudiante de la cola
                var estudiante = cola.Dequeue();

                // Luego lo guardo en la pila de atendidos
                atendidos.Push(estudiante);

                Console.WriteLine("Estudiante atendido:");
                estudiante.MostrarInfo();
            }
            else
            {
                Console.WriteLine("No hay estudiantes en la cola.");
            }
        }
    }
}