using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesMore_03
{
    class Program
    {
        static void Main(string[] args)
        {
            bool canContunie = true;
            Dictionary<string, int> match = new Dictionary<string, int>();
            while (canContunie)
            {
                string resource = Console.ReadLine();
                int quantuty = 0;
                if (resource == "stop")
                {
                    canContunie = false;
                    PrintResult(match);
                    break;
                }
                else
                {
                    quantuty = int.Parse(Console.ReadLine());
                }
                if (match.ContainsKey(resource))
                {
                    match[resource] += quantuty;
                }
                else
                {
                    match.Add(resource, quantuty);
                }
            }
        }
     private static void PrintResult(Dictionary<string , int> match)
        {
            foreach ( KeyValuePair<string ,int> resourse in match)
            {
                Console.WriteLine($"{resourse.Key} -> {resourse.Value}");
            }
        }
    }
}
