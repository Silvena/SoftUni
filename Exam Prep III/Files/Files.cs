using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _4_Files
{
    class File
    {
        public string Root { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        public long Size { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var files = new List<File>();

            for (int i = 0; i < n; i++)
            {
                var path = Console.ReadLine();
                var tokens = path.Split(new char[] { '\\', ';' });
                var root = tokens.First();
                var size = long.Parse(tokens.Last());
                var name = tokens.Reverse().Skip(1).First();
                var extension = name.Split('.').Last();

                var file = files
                    .SingleOrDefault(f => f.Name == name && f.Root == root);
                if (file != null)
                {
                    file.Size = size;
                }
                else
                {
                    file = new File()
                    {
                        Root = root,
                        Name = name,
                        Extension = extension,
                        Size = size
                    };
                    files.Add(file);
                }
            }
            var check = Regex.Split(Console.ReadLine(), @" in ");
            files = files
                .Where(f => f.Root == check[1])
                .Where(f => f.Extension == check[0])
                .OrderByDescending(f => f.Size)
                .ThenBy(f => f.Name)
                .ToList();
            if (files.Any())
            {
                foreach (var f in files)
                {
                    Console.WriteLine($"{f.Name} - {f.Size} KB");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}