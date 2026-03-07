using System;

namespace AnimalS3
{
    public abstract class Animal
    {
        private string nombre;
        private int edad;

 
        public int Edad
        {
            get { return edad; }
            set
            {
                if (value > 0)
                    edad = value;
            }
        }

        
        public Animal(string nombre, int edad)
        {
            this.nombre = nombre;
            this.Edad = edad;
        }

        public void SetNombre(string nuevoNombre)
        {
            nombre = nuevoNombre;
        }

        public string GetNombre()
        {
            return nombre;
        }

        
        public abstract void EmitirSonido();
    }
}
