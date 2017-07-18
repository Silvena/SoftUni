using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            const char delimiter = '|';

            var input = Console.ReadLine().Split(delimiter).ToList();
            var countryCityPopulation = new Dictionary<string, Dictionary<string, int>>();
            var countryPopulation = new Dictionary<string, long>();
            var command = input[0];

            while (command != "report")
            {
                var city = input[0];
                var country = input[1];
                var populationCity = int.Parse(input[2]);

                if (!countryCityPopulation.ContainsKey(country))
                {
                    var cityPopulation = new Dictionary<string, int>();

                    cityPopulation.Add(city, populationCity);
                    countryCityPopulation.Add(country, cityPopulation);
                    countryPopulation.Add(country, populationCity);
                }
                else
                {
                    var cityPopulation = new Dictionary<string, int>();

                    cityPopulation = countryCityPopulation[country];
                    cityPopulation.Add(city, populationCity);
                    countryCityPopulation[country] = cityPopulation;
                    var populationCountry = countryPopulation[country] + populationCity;
                    countryPopulation[country] = populationCountry;
                }

                input = Console.ReadLine().Split(delimiter).ToList();
                command = input[0];
            }

   
            foreach (var country in countryPopulation.OrderByDescending(populationCountry => populationCountry.Value))
            {
                var key = country.Key;
                var cityPopulation = countryCityPopulation[key];

                Console.WriteLine($"{country.Key} (total population: {country.Value})");
                foreach (var city in cityPopulation.OrderByDescending(populationCity => populationCity.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}