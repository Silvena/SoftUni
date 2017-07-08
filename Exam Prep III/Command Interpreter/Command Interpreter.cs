using System;
namespace Command_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] items = Console.ReadLine().Split();

            while (true)
            {

                var commandLine = Console.ReadLine().ToLower().Trim();
                if (commandLine == "end")
                {
                    break;
                }
                var commandParts = commandLine.Split();
                var commandName = commandParts[0];
               
                ProcessCommand( items, commandName,commandParts);

            }
            Console.WriteLine($"[{string.Join(", ",items)}]");
        }

        private static void ProcessCommand(string[] items, string cmd, string[] cmdParts)
        {
            if (cmd == "sort" || cmd == "reverse")
            {
                ProcessSortOrReverseCommand(items, cmd, cmdParts);
            }
            if (cmd == "rollleft" || cmd == "rollRight")
            {
                ProcessRollLeftOrRollRightCommand(items, cmd, cmdParts);
            }
        }

        private static void ProcessRollLeftOrRollRightCommand(string[] items, string cmd, string[] cmdParts)
        {
          
            var count = int.Parse(cmdParts[2]);
            if (count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }
            if (cmd == "rollleft")
            {
                RollRight( items, -count);  // to right is -1 to left is  +1 so we use same method for two checks but for one is  "-count"
            }
            else if (cmd == "rollrigth")
            {
                RollRight( items, count);
            }
        }

        private static void RollRight(string[] items, int count)
        {
            var result = new string[items.Length];
            for (int oldIndex = 0; oldIndex < items.Length; oldIndex++)
            {
                var newIndex = oldIndex + count;
                newIndex = newIndex % items.Length;
                if (newIndex< 0 )
                {
                    newIndex += items.Length;
                }
                result[newIndex] = items[oldIndex];
            }

            /* 
             * another implementation for how to move items
              
            for (int i = 0; i < count; i++)
            {
             var newItems  = items.Skip(1).Take(items.Length - 1).ToList();
             newItems.Add(first);
             items = newItems.ToArray();
            }
             */

            for (int i = 0; i < items.Length; i++)
            {
                items[i] = result[i];
            }
        }

        private static void ProcessSortOrReverseCommand(string[] items, string cmd , string[] cmdParts)
        {
            var start = int.Parse(cmdParts[2]);
                var count = int.Parse(cmdParts[4]);
                if (start < 0 || start > items.Length -1 || start + count  < 0 || start + count - 1 > items.Length - 1)
                {
                    Console.WriteLine("Invalid input parameters.");
                    return;
                }
            if (cmd == "sort")
            {
                SortRange(items, start, count);
            }
            else if (cmd == "reverse")
            {
                ReverseRange(items, start,count);
            }
        }
        
        private static void ReverseRange(string[] items, int start, int count)
        {
          
            var end = start + count - 1;
            while (start < end)
            {
                //reverse start and end
                var oldItem = items[start];              
                items[start] = items[end];
                items[end] = oldItem;
                start++;
                end--;
            } 
        }
        private static void SortRange(string[] items, int start, int count)
        {
            Array.Sort(items, start, count);
               
        }
    }
}
