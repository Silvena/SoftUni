using System;

namespace Methods
{
    class Program
    {
        static void cashHeader()
        {
            Console.WriteLine(" CASH RECEIPT");
            Console.WriteLine(" ------------------------------");
        }
        static void body()
        {
            Console.WriteLine(" Charged to____________________");
            Console.WriteLine(" Received by___________________");
        }
        static void footer()
        {
            Console.WriteLine(" ------------------------------");
            Console.WriteLine(" \u00A9 SoftUni");
        }
        static void printAll()
        {
            cashHeader();
            body();
            footer();
        }
        static void Main(string[] args)
        {
            printAll();
        } 
    }
}
