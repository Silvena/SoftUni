using System;

namespace DogHouse
{
  public class Program
    {
      public  static void Main(string[] args)
        {
            decimal sideA = decimal.Parse(Console.ReadLine());
            decimal sideBHight = decimal.Parse(Console.ReadLine());

            

            decimal twoSide = sideA * (sideA / 2) * 2;
            decimal backSide =((sideA / 2) * (sideA / 2))+  Math.Abs(sideA /2*(sideBHight-sideA/2)/2);
            decimal backDoor = (sideA / 5) * (sideA /5);
            decimal frontWall = backSide - backDoor;
            decimal sum = twoSide + backSide + frontWall;
            decimal roof =sideA * (sideA/2)*2;
            decimal red = roof/5;
            decimal green = sum / 3;
            Console.WriteLine($"{green:f2}");
            Console.WriteLine($"{red:f2}");
        }
    }
}
