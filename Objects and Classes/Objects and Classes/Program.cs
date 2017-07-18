using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;



namespace Objects_and_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateAsText = Console.ReadLine();
            DateTime date = DateTime.ParseExact(dateAsText,
                "d-M-yyyy", CultureInfo.InvariantCulture); // using System.Globalization;
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
