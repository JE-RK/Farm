using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    internal class Farm
    {
        List<Animal> animals = new List<Animal>();
        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
            Console.WriteLine("Животное добавлено!");
        }

        public void Size()
        {
            Console.WriteLine(animals.Count);
        }

        public void TotalWeight()
        {
            int totalWeight = 0;
            foreach (var animal in animals)
            {
                totalWeight += animal.weight;
            }
            Console.WriteLine(totalWeight);
        }

        public void AnimalSound(int index)
        {
                animals[index - 1].MakeSound();

        }
    }
}
