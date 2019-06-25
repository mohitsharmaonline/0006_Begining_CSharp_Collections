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

            List<Country> countries = reader.ReadAllCountries();

            foreach (Country country in countries.OrderBy(country => country.Name))
            {
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}:" +
                    $" {country.Name}");
            }
        }
    }
}
