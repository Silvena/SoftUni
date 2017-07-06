using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadyBugs
{
    class Program
    {
        public static void Main(string[] args)
        {
            var fieldSize = int.Parse(Console.ReadLine());
            var ladybugIndex = Console.ReadLine()
                .Split().Select(int.Parse)
                .Where(a => a >= 0 && a < fieldSize)
                .ToArray();

            var ladybugs = new int[fieldSize];
            for (int i = 0; i < ladybugIndex.Length; i++)
            {
                var currentLadybugIndex = ladybugIndex[i];
                ladybugs[currentLadybugIndex] = 1;
            }
            var line = Console.ReadLine();
            while (line != "end")
            {
                var tokens = line.Split();
                var ladyBugIndex = int.Parse(tokens[0]);
                var direction = tokens[1];
                var flyLength = int.Parse(tokens[2]);

                if (ladyBugIndex < 0 || ladyBugIndex >= ladybugs.Length)
                {
                    line = Console.ReadLine();
                    continue;
                }
                if (ladybugs[ladyBugIndex] == 0)
                {
                    line = Console.ReadLine();
                    continue;
                }

                MoveLadybug(ladybugs, ladyBugIndex, flyLength, direction);
                line = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", ladybugs));
        }

        private static void MoveLadybug(int[] ladybugs, int ladyBugIndex, int flyLength, string direction)
        {
            ladybugs[ladyBugIndex] = 0;
            var leftArrFoundPlace = false;
            while (!leftArrFoundPlace)
            {
                switch (direction)
                {
                    case "left":
                        ladyBugIndex -= flyLength;
                        break;
                    case "right":
                        ladyBugIndex += flyLength;

                        break;
                }
                if (ladyBugIndex < 0 || ladyBugIndex >= ladybugs.Length)
                {
                    leftArrFoundPlace = true;
                    continue;
                }
                if (ladybugs[ladyBugIndex] == 1)
                {
                    continue;
                }
                if (ladybugs[ladyBugIndex] == 0)
                {
                    ladybugs[ladyBugIndex] = 1;
                    leftArrFoundPlace = true;
                    continue;
                }
            }
        }
    }
}
