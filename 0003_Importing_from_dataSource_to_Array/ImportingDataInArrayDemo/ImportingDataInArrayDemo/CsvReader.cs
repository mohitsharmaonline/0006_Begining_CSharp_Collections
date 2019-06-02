﻿using System;

namespace ImportingDataInArrayDemo
{
    internal class CsvReader
    {
        private string _csvFilePath;

        public CsvReader(string _csvFilePath)
        {
            this._csvFilePath = _csvFilePath;
        }

        internal Country[] ReadFirstNCountries(int nCountries)
        {
            Country[] countries = new Country[nCountries];
            return countries;
        }

        public Country ReadCountryFromCsvLine(string csvLine)
        {
            string[] parts = csvLine.Split(',');

            string name = parts[0];
            string code = parts[1];
            string region = parts[2];
            int population = int.Parse(parts[3]);

            return new Country(name, code, region, population);
        }
    }
}