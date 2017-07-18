using System;


namespace T4FruitOrVegetable
{
   public class FrutOrVeg
    {
       public static void Main(string[] args)
        {
            var product = Console.ReadLine().ToLower();
            
            if(product == "banana" || product == "apple" || product == "kiwi" || product == "cherry" || product == "lemon" || product == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if ( product == "tomato" || product == "cucumber" || product == "pepper" || product == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
