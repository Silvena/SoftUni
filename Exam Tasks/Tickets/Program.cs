using System;
namespace Tickets
{
   public class Program
    {
       public static void Main(string[] args)
        {
            var buget = double.Parse(Console.ReadLine());
            var category = Console.ReadLine().ToLower();
            var numOfPeople = int.Parse(Console.ReadLine());
           
            var ticket = category == "vip" ? 499.99 : 249.99;
            var allTicket = numOfPeople * ticket;

            if ( numOfPeople <= 4)
                {
                    buget =  (buget * 0.25);
                 
                }
               else if(numOfPeople <= 9)
                {
                    buget*=0.60;

                }
               else if (numOfPeople <= 24)
                {
                    buget *= 0.50;
                }
               else if (numOfPeople <= 49)
                {
                    buget *= 0.40;
                }
                else if (numOfPeople > 50)
                {
                    buget *= 0.25;
                   
                }

            if (allTicket <= buget)
            {
                buget -= allTicket;
                Console.WriteLine("Yes,you have {0:F2} leva left", buget);
            }
            else if (buget < allTicket)
            {
                Console.WriteLine("Not enough money! You need {0:F2} leva.", allTicket - buget);
            }
        }
    }
}
