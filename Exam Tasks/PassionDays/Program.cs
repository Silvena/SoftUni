using System;

namespace PassionDays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var linaMoney = decimal.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            command = Console.ReadLine();
            int purchases = 0;

            while (command != "mall.Exit")
            {
                string action = command;
                for (int i = 0; i < action.Length; i++)
                {
                    decimal price = 0;
                    var chr = action[i];
                    if (char.IsLetter(chr))
                    {
                        decimal discount = char.IsUpper(chr) ? 0.5m : 0.3m;
                        price = chr * discount;


                        if (linaMoney >= price)
                        {
                            linaMoney -= price;
                            purchases++;
                        }
                        }
                    else if (chr == '%')
                    {
                        if (linaMoney > 0)
                        {
                            linaMoney /= 2;
                            purchases++;
                        }
                    }

                    else if (chr == '*')
                    {
                        linaMoney += 10;
                    }
                    else
                    {
                        price = chr;
                        if (linaMoney >= price)
                        {
                            linaMoney -= price;
                            purchases++;

                        }
                    }
                }
                command = Console.ReadLine();
            }
            if (purchases == 0)
            {
                Console.WriteLine("No purchases. Money left: {0:f2} lv.", linaMoney);
            }
            else
            {
                Console.WriteLine("{0} purchases. Money left: {1:f2} lv.", purchases, linaMoney);
            }

        }
    }
}
