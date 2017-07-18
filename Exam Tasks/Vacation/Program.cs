using System;


namespace Vacation
{
  public  class Program
    {
      public  static void Main(string[] args)
        {
            double adult = double.Parse(Console.ReadLine());
            double student = double.Parse(Console.ReadLine());
            double night = double.Parse(Console.ReadLine());
            string transport = Console.ReadLine().ToLower();
            double costTransport = 0;
            double comission = 0;
            double groopNight = night * 82.99;
            double all = 0;
            
            if (transport == "train")
            {
               
                costTransport = (adult* 24.99) + (student*14.99);
                costTransport *= 2;
            if ( adult + student >= 50 )
               {
                    
                    costTransport /= 2; // otstapka 50%
                }
            }  
          else  if (transport == "bus")
            {
                adult *= 32.50;
                student *= 28.50;
                costTransport = (adult + student) * 2;
            }
           else if (transport == "boat")
            {
                adult *= 42.99;
                student *= 39.99;
                costTransport = (adult + student) * 2;
            }
           else if (transport == "airplane")
            {
                adult *= 70.00;
                student *= 50.00;
                costTransport = (adult + student) * 2;
            }

            comission = (costTransport + groopNight) *0.10;
            all = costTransport + groopNight + comission;
         
            Console.WriteLine("{0:f2}",all);
           
        }
    }
}
