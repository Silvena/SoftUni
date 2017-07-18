using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesMore_08LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameIpDuration = new SortedDictionary<string, SortedDictionary<string, int>>();
            var count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                var line = Console.ReadLine();

                var tokens = line.Split();
                var name = tokens[1];
                var ip = tokens[0];
                var duration = int.Parse(tokens[2]);

                if (!nameIpDuration.ContainsKey(name))
                {
                    nameIpDuration[name] = new SortedDictionary<string, int>();

                }
                if (!nameIpDuration[name].ContainsKey(ip))
                {
                    nameIpDuration[name][ip] = 0;
                }
                nameIpDuration[name][ip] += duration;
            }
            foreach (var nameIpDur in nameIpDuration)
            {
                var name = nameIpDur.Key;
                var ipDuration = nameIpDur.Value;

                var totalDur = ipDuration.Sum(a => a.Value);
                var ip = ipDuration.Select(a => a.Key).ToArray();
          
                Console.WriteLine($"{name}: {totalDur} [{string.Join(", ",ip)}]");
              }
           
        }
    }
}
