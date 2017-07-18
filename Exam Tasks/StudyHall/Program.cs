using System;
namespace StudyHall
{
  public  class Program
    {
      public  static void Main(string[] args)
        {
            var h = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            var Roll = Math.Floor(h / 1.2);
            var WorkPlace = w - 1; 
             WorkPlace = WorkPlace/ 0.7;
            WorkPlace = Math.Floor(WorkPlace);
            var numOfPlace = (Roll * WorkPlace) - 3;
            Console.WriteLine(numOfPlace);


        }
    }
}
