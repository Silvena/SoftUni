using System;


namespace BackToThePast
{
   public class Program
    {
      public  static void Main(string[] args)
        {
            double heritage = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            int startYear = 1800;
            double spendMoneyEven = 12000;
            double leftMoney = heritage;
            int ivanchoAge = 18;
            int oddYear = 0;
            for (int i = startYear; i <= year; i++)
            {
                if (i % 2 != 0)
                {
                    leftMoney -= (spendMoneyEven + (ivanchoAge+oddYear)* 50 );
                }
                else
                {
                    leftMoney = leftMoney - spendMoneyEven;
                }
                oddYear++;
            }
            if (leftMoney >= 0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:0.00} dollars left.", leftMoney);
            }
            else
            {
                Console.WriteLine("He will need {0:0.00} dollars to survive.", Math.Abs(leftMoney));
            }
        }
    }
}
