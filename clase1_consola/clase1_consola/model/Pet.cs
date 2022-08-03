using System;
namespace clase1_consola.model
{
    public abstract class Pet
    {
        public string name { get; set; }
        public string symptom { get; set; }
        public string diagnosis { get; set; }
        public Person person { get; set; }

        public Pet()
        {
        }
    }
}

