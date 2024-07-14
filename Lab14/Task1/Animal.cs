using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal abstract class Animal
    {
        public abstract string AnimalType { get; set; }

        public Animal(string animalType)
        {
            AnimalType = animalType;
        }
        public abstract void Say();

        public void ShowInfo()
        {
            Console.WriteLine($"Название животного: {AnimalType}");
            Say();
        }
    }
}
