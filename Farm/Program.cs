using System;
namespace Farm
{
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
                        farm.AddAnimal(cow);
                        break;
                    case "add pig":
                        Pig pig = new Pig();
                        farm.AddAnimal(pig);
                        break;
                    case "add chiken":
                        Chicken chicken = new Chicken();
                        farm.AddAnimal(chicken);
                        break;
                    case "farm size":
                        farm.Size();
                        break;
                    case "farm total weight":
                        farm.TotalWeight();
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
