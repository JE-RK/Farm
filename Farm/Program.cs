using System;
namespace Farm
{
    class Farm
    {
        List<Animal> animals = new List<Animal>();
        public void AddToFarm(Animal obj)
        {
            animals.Add(obj);
            Console.WriteLine("Животное добавлено!");
        }

        public void FarmSize()
        {
            Console.WriteLine( animals.Count);
        }

        public void FarmTotalWeight()
        {
            int totalWeight = 0;
            foreach (var item in animals)
            {
                totalWeight += item.weight;
                
            }
            Console.WriteLine(totalWeight);
        }

        public void AnimalSound(int index)
        {
            for (int i = 0; i < animals.Count; i++)
            {
                if (i + 1 == index)
                {
                    Console.WriteLine(animals[i].sound);
                    break;
                }
            }
        }
    }
    class Animal
    {
        public string sound;
        public int weight;
    }
    class Cow : Animal
    {
        public Cow()
        {
            sound = "moo";
            weight = 500;
        }
        
    }
    class Pig : Animal
    {
        public Pig()
        {
            sound = "oink";
            weight = 100;
        }
    }
    class Chicken : Animal
    {
        public Chicken()
        {
            sound = "cluck";
            weight = 5;
        }
    }
    
    class Program
    {
        
        static void Main(string[] args)
        {
            Farm farm = new Farm();
            while (true)
            {
                string command = Console.ReadLine();
                switch (command)
                {
                    case "exit":
                        Environment.Exit(0);
                        break;
                    case "add cow":
                        Cow cow = new Cow();
                        farm.AddToFarm(cow);
                        break;
                    case "add pig":
                        Pig pig = new Pig();
                        farm.AddToFarm(pig);
                        break;
                    case "add chiken":
                        Chicken chicken = new Chicken();
                        farm.AddToFarm(chicken);
                        break;
                    case "farm size":
                        farm.FarmSize();
                        break;
                    case "farm total weight":
                        farm.FarmTotalWeight();
                        break;
                    case "farm sound":
                        Console.WriteLine("Введите порядковый номер животного");
                        string i = Console.ReadLine();
                        farm.AnimalSound(Convert.ToInt32(i));                       
                        break;
                    default:
                        Console.WriteLine("Неверная команда");
                        break;
                } 
            }
            
            
        }
    }
}
