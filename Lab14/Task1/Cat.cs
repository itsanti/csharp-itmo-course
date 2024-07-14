using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Cat : Animal
    {
        private string animalType;

        public override string AnimalType { get => animalType; set => animalType = value; }

        public Cat() : base("Кошка") {}

        public override void Say()
        {
            Console.WriteLine("Мяу");
        }

    }
}
