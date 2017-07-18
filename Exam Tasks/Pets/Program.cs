using System;


namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int leftFood = int.Parse(Console.ReadLine());
            double foodForDog = double.Parse(Console.ReadLine());
            double foodForCat = double.Parse(Console.ReadLine());
            double foodForTurtule = double.Parse(Console.ReadLine());
            var needFoodDog = days * foodForDog;
            var needFoodCat = days * foodForCat;
            var needFoodTurtule = (days * foodForTurtule)/1000;
            var needFood = needFoodTurtule + needFoodDog + needFoodCat ;
            var diff = leftFood - needFood;
            if (diff >= 0 )
            {
                 Console.WriteLine("{0} kilos of food left.",Math.Truncate(diff));
            }
            else
            {
                diff = Math.Abs(diff);
             Console.WriteLine("{0} more kilos of food are needed.",Math.Ceiling(diff));
           
            }
          
           
        }
    }
}
