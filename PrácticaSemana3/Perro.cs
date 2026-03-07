using AnimalS3;
using System;

namespace PerroS3
{
    public class Perro : Animal
    {
        public Perro(string nombre, int edad) : base(nombre, edad)
        {
        }

        public override void EmitirSonido()
        {
            Console.WriteLine("El perro " + GetNombre() + " hace: Guau");
        }
    }
}
