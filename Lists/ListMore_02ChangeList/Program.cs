using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMore_02ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listToChange = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> result = new List<int>();


            while (true)
            {

                string[] input = Console.ReadLine().Split().ToArray();
                string command = input[0];

                switch (command)
                {
                    case "Delete":

                        for (int i = 0; i < listToChange.Count; i++)
                        {
                            long n = long.Parse(input[1]);
                            listToChange.RemoveAll(item => item == n);
                        }
                        break;
                    case "Insert":
                        int b = int.Parse(input[1]);
                        var position = int.Parse(input[2]);

                        listToChange.Insert(position, b);

                        break;

                    case "Even":

                        for (int i = 0; i < listToChange.Count; i++)
                        {
                            if (Math.Abs(listToChange[i]) % 2 == 0)
                            {

                                result.Add(listToChange[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", result));
                        break;

                    case "Odd":

                        for (int i = 0; i < listToChange.Count; i++)
                        {
                            if (Math.Abs(listToChange[i]) % 2 == 1)
                            {
                                result.Add(listToChange[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", result));
                        break;
                }

                if (command == "Odd" || command == "Even")
                {
                    break;
                }
                
            }
        }
    }
}
