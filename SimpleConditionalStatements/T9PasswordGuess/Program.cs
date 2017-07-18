using System;


namespace T9PasswordGuess
{
   public class Program
    {
     public static void Main(string[] args)
        {
            var user = Console.ReadLine();
            if(user == "qwerty")
            {
                Console.WriteLine("Wrong password!");
            }
            else if(user == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else if (user == "s3cr3t!p@ss")
            {
                Console.WriteLine("Wrong password!");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
