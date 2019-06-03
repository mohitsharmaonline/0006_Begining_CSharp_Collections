using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportingDataInArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\mohit\Documents\0006_Begining_CSharp_Collections\0003_Importing_from_dataSource_to_Array\data\Pop by Largest Final.csv";
            CsvReader reader = new CsvReader(filePath);

            List<Country> countries = reader.ReadAllCountries();
            Country lilliput = new Country("Lilliput", "LIL", "Somewhere", 2_000_000);
            int lilliputIndex = countries.FindIndex(country => country.Population < 2_000_000);
            countries.Insert(lilliputIndex, lilliput);
            countries.RemoveAt(lilliputIndex);

            foreach (Country country in countries)
            {
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }
            Console.WriteLine($"{countries.Count} countries");
        }
    }
}
