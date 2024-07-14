using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.ShowInfo();

            Dog dog = new Dog();
            Console.WriteLine(dog.AnimalType);
            dog.AnimalType = "Волк";
            dog.ShowInfo();

            Console.ReadKey();
        }
    }
}
