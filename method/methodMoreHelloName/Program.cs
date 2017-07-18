using System;


namespace methodMoreHelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            ReciveName();
        }
        static void ReciveName()
        {
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
