﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
          key = Regex.Escape(key);

            var regex =new Regex($@"{key}(.*?){key}.*?{key}(.+?){key}.+?(\d+):(\d+)");

            var scores = new Dictionary<string, long>();
            var goals = new Dictionary<string, long>();
            while (true)
            {
                var line = Console.ReadLine();

                if (line == "final")
                {
                    break;
                }
                var match = regex.Match(line);

                var firstTeamReverse = match.Groups[1].Value.Reverse().ToArray();
                var secondTeamReverse = match.Groups[2].Value.Reverse().ToArray();

                var firstTeam = new string(firstTeamReverse).ToUpper();
                var secondTeam = new string(secondTeamReverse).ToUpper();
                var firstTeamGoals = int.Parse(match.Groups[3].Value);
                var secondTeamGoals = int.Parse(match.Groups[4].Value);

                if (!scores.ContainsKey(firstTeam))
                {
                    scores[firstTeam] = 0;
                }
                if (!scores.ContainsKey(secondTeam))
                {
                    scores[secondTeam] = 0;
                }
                if (!goals.ContainsKey(firstTeam))
                {
                    goals[firstTeam] = 0;

                }
                if (!goals.ContainsKey(secondTeam))
                {
                    goals[secondTeam] = 0;

                }
                goals[firstTeam] += firstTeamGoals;
                goals[secondTeam] += secondTeamGoals;

                if (firstTeamGoals > secondTeamGoals)
                {
                    scores[firstTeam] += 3;
                }
                else if (firstTeamGoals < secondTeamGoals)
                {
                    scores[secondTeam] += 3;
                }
                else
                {
                    scores[firstTeam]++;
                    scores[secondTeam]++;
                }
            }
            Console.WriteLine("League standings:");
            int plase = 1;
            foreach (var kvp in scores.OrderByDescending(
               kvp => kvp.Value).ThenBy(kvp => kvp.Key))
            {
                Console.WriteLine($"{plase}. {kvp.Key} {kvp.Value}");
                plase++;
            }
            Console.WriteLine("Top 3 scored goals:");
            foreach (var kvp in goals.OrderByDescending(kvp => kvp.Value).ThenBy(kvp => kvp.Key).Take(3))
            {
                Console.WriteLine($"- {kvp.Key} -> {kvp.Value}");
            }

        }
    }
}
