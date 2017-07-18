using System;


namespace SaltAndPepper
{
  public  class Program
    {
     public   static void Main(string[] args)
        {
            ulong num = ulong.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            while (command != "end")
            {
               
                    string[] commandElem = command.Split(' ');
                string action = commandElem[0];
                int step = int.Parse(commandElem[1]);

                if (action == "salt")

                {
                    for (int i = 0; i <=63; i+=step)
                    {
                        if (((num >>i)&1)==1)
                        {
                            ulong mask = ~((ulong)1 << i);
                            num = num & mask;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i <= 63; i += step)
                    {
                        if (((num >> i) & 1) == 0)
                        {
                            ulong mask = (ulong)1 << i;
                            num = num | mask;
                        }
                    }
                }
                command = Console.ReadLine();

            }
            Console.WriteLine(num);

        }
    }
}
