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
            Console.WriteLine("Enter no. of countries to display? ");
            bool inputIsInt = int.TryParse(Console.ReadLine(), out int userInput);
            if(!inputIsInt || userInput <= 0)
            {
                Console.WriteLine("You must enter a +ve integer. Exiting");
                return;
            }

            int maxToDisplay = userInput;
            for(int i = countries.Count - 1; i >= 0; i--)
            {
                int displayIndex = countries.Count - 1 - i;
                if (displayIndex > 0 && (displayIndex % maxToDisplay == 0))
                {
                    Console.WriteLine("Hit return to continue, anything else to quit>");
                    if (Console.ReadLine() != "")
                        break;
                }
                Country country = countries[i];
                Console.WriteLine($"{displayIndex+1}: {PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }
        }
    }
}
