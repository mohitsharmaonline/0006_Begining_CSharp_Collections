using System;
using System.Collections.Generic;
using System.IO;

namespace ImportingDataInArrayDemo
{
    internal class CsvReader
    {
        private string _csvFilePath;

        public CsvReader(string _csvFilePath)
        {
            this._csvFilePath = _csvFilePath;
        }

        internal List<Country> ReadAllCountries()
        {
            List<Country> countries = new List<Country>();
            using (StreamReader sr = new StreamReader(_csvFilePath))
            {
                // Read header line
                sr.ReadLine();

                for (int i = 0; i < nCountries; i++)
                {
                    string csvLine = sr.ReadLine();
                    countries[i] = ReadCountryFromCsvLine(csvLine);
                }
            }

            return countries;
        }

        public Country ReadCountryFromCsvLine(string csvLine)
        {
            string[] parts = csvLine.Split(new char[] { ',' });

            string name = parts[0];
            string code = parts[1];
            string region = parts[2];
            int population = int.Parse(parts[3]);

            return new Country(name, code, region, population);
        }
    }
}