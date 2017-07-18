using System;


namespace T10AnimalType
{
  public  class Program
    {
       public static void Main(string[] args)
        {
             string animalType = Console.ReadLine().ToLower();
            switch (animalType)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":
                    Console.WriteLine("reptile");
                    break;
                case "tortoise":
                    Console.WriteLine("reptile");
                    break;
                case "snake":
                    Console.WriteLine("reptile");
                    break;
                case "cat":
                    Console.WriteLine("unknown");
                    break; 
            }

        }
    }
}
