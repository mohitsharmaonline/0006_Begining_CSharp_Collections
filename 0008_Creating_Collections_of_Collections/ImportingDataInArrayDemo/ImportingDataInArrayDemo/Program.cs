﻿using System;
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

            Dictionary<string, List<Country>> countries = reader.ReadAllCountries();
            foreach (string region in countries.Keys)
            {
                Console.WriteLine(region);
            }

            Console.WriteLine("Which of the above region do you want? ");
            string chosenRegion = Console.ReadLine();

            if (countries.ContainsKey(chosenRegion))
            {
                foreach (Country country in countries[chosenRegion].Take(10))
                {
                    Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
                }
            }
            else
            {
                Console.WriteLine("This is not a valid region");
            }
        }
    }
}
