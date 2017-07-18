using System;


namespace HousePrice
{
   public class Program
    {
       public static void Main(string[] args)
        {
            double smallroom = double.Parse(Console.ReadLine());
            double kitchenArea = double.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());

            double bathroom = smallroom / 2;
            double secondRoom = smallroom * 1.10;
            double thirdRoom = secondRoom * 1.10;
            
            double sumRoom = smallroom + secondRoom + thirdRoom + bathroom + kitchenArea;
            double doorWay = sumRoom * 0.05;
            sumRoom += doorWay;
            Console.WriteLine("{0:f2}",sumRoom * price);
           

        }
    }
}
