using System;

namespace repareOfTile
{
   public class Program
    {
       public static void Main(string[] args)
        {
            var N = double.Parse(Console.ReadLine());
            var wTail = double.Parse(Console.ReadLine());
            var lTail = double.Parse(Console.ReadLine());
            var MBench = double.Parse(Console.ReadLine());
            var OBench = double.Parse(Console.ReadLine());
            double tottalArea = N * N; 
           
            double BenchArea = MBench * OBench;
           double AreaCover = tottalArea - BenchArea;
            double tailArea = wTail * lTail;
  
            double NeedTail = AreaCover / tailArea ;
            double NeedTime = NeedTail * 0.2;
            Console.WriteLine(NeedTail);
            Console.WriteLine(NeedTime);

        }
    }
}
