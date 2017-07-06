using System;
using System.Collections.Generic;
using System.Linq;

namespace Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            var participants = Console.ReadLine()
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(p => p.Trim())
                .ToArray();
            var nameSong = Console.ReadLine()
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(p => p.Trim())
                .ToArray();

            var result = new Dictionary<string, List<string>>();

            string line = Console.ReadLine();
            while (line != "dawn")
            {
                var performanse = line
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(p => p.Trim())
                .ToArray();
                var participant = performanse[0];
                var song = performanse[1];
                var award = performanse[2];
                if (participants.Contains(participant) && nameSong.Contains(song))
                {
                    if (!result.ContainsKey(participant))
                    {
                        result[participant] = new List<string>();
                    }
                    var awards = result[participant];
                    if (!awards.Contains(award))
                    {
                        awards.Add(award);
                    }
                }
                line = Console.ReadLine();
            }
            if (result.Any())  //result.count == 0
            {
                foreach (var kvp in result.OrderByDescending(p => p.Value.Count).ThenBy(p => p.Key))
                {
                    var participant = kvp.Key;
                    var awards = kvp.Value;
                    Console.WriteLine($"{participant}: {awards.Count} awards");
                    foreach (var award in awards.OrderBy(a => a))
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
