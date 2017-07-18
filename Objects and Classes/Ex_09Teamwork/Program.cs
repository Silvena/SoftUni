using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Lab1.CountRealinput
{

    class Program
    {
        static Dictionary<string, string> teamCreators = new Dictionary<string, string>(); //team, creator
        static Dictionary<string, List<string>> teamMembers = new Dictionary<string, List<string>>(); //team, members

        static void Main(string[] args)
        {


            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                //registerTeam
                var input = Console.ReadLine().Split('-').ToArray();
                var teamName = input[1];
                var user = input[0];
                if (teamCreators.ContainsKey(input[1]))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                if (teamCreators.ContainsValue(user))
                {
                    Console.WriteLine($"{user} cannot create another team!");
                    continue;
                }
                teamCreators[teamName] = user;
                teamMembers[teamName] = new List<string>();
                Console.WriteLine($"Team {teamName} has been created by {user}!");
            }
            while (true)
            {
                //var input = Console.ReadLine().Split('>').ToArray();
                var input = Console.ReadLine();
                string[] splitInput = input.Split(new[] { "->" }, StringSplitOptions.None).ToArray();
                if (splitInput[0] == "end of assignment") break;
                var teamName = splitInput[1];
                var user = splitInput[0];
                if (!teamMembers.ContainsKey(teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }
                if (teamMembers.Any(p => p.Value.Contains(user)) || teamCreators.Any(p => p.Value == user))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                    continue;
                }
                teamMembers[teamName].Add(user);

            }
            var listDisband = new List<string>();
            //var listFormed = teamMembers.OrderBy(p => p.Value.Count);
            foreach (var item in teamMembers.OrderBy(p => p.Key))//.Value.Count))
            {
                if (item.Value.Count == 0)
                {
                    listDisband.Add(item.Key);
                    teamMembers.Remove(item.Key); //И това е промяна от мен!!!
                    continue;
                }
                else
                {
                    // listFormed.Add(item.Key);
                }
                Console.WriteLine(item.Key);
                Console.WriteLine($"- {teamCreators[item.Key]}");
                foreach (var m in item.Value.OrderBy(p => p))
                {
                    Console.WriteLine($"-- {m}");
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (var team in listDisband)
            {
                Console.WriteLine(team);
            }

        }
    }
}