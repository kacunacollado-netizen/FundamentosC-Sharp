using AnimalS3;
using System;

namespace AveS3
{
    public class Ave : Animal
    {
        public Ave(string nombre, int edad) : base(nombre, edad)
        {
        }

        public override void EmitirSonido()
        {
            Console.WriteLine("El ave " + GetNombre() + " hace: Pio Pio");
        }
    }
}
