using System;


namespace T14TimeMinutes
{
  public  class Program
    {
      public  static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            TimeSpan span = new TimeSpan(hour, minutes , 0);
            TimeSpan add = new TimeSpan(0,15,0);

            TimeSpan total = span + add;
            Console.WriteLine("{0:h\\:mm}",total);
        }
    }
}
