using AnimalS3;
using System;

namespace GatoS3
{
    public class Gato : Animal
    {
        public Gato(string nombre, int edad) : base(nombre, edad)
        {
        }

        public override void EmitirSonido()
        {
            Console.WriteLine("El gato " + GetNombre() + " hace: Miau");
        }
    }
}
