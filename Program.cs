using AnimalS3;
using AveS3;
using GatoS3;
using PerroS3;
using System;
using System.Collections.Generic;

namespace MainS3
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Animal> listaAnimales = new List<Animal>();

            Perro perro1 = new Perro("Bingo", 6);
            Gato gato1 = new Gato("Garfield", 3);
            Ave ave1 = new Ave("Rio", 2);

            listaAnimales.Add(perro1);
            listaAnimales.Add(gato1);
            listaAnimales.Add(ave1);

            Console.WriteLine("Lista de animales del refugio:\n");

            foreach (Animal a in listaAnimales)
            {
                Console.WriteLine("Nombre: " + a.GetNombre());
                Console.WriteLine("Edad: " + a.Edad);
                a.EmitirSonido();
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}