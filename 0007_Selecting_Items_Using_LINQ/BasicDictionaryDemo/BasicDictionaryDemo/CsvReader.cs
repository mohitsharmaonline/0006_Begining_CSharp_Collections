﻿using BasicDictionaryDemo;
using System;
using System.Collections.Generic;
using System.IO;

namespace BasicDictionaryDemo
{
    internal class CsvReader
    {
        private string _csvFilePath;

        public CsvReader(string _csvFilePath)
        {
            this._csvFilePath = _csvFilePath;
        }

        public Dictionary<string, Country> ReadAllCountries()
        {
            Dictionary<string, Country> countries = new Dictionary<string, Country>();
            using (StreamReader sr = new StreamReader(_csvFilePath))
            {
                // Read header line
                sr.ReadLine();

                string csvLine;
                while ((csvLine = sr.ReadLine()) != null)
                {
                    Country country = ReadCountryFromCsvLine(csvLine);
                    countries.Add(country.Code, country);
                }
            }

            return countries;
        }

        public Country ReadCountryFromCsvLine(string csvLine)
        {
            string[] parts = csvLine.Split(new char[] { ',' });


            string name;
            string code;
            string region;
            string popText;

            switch(parts.Length)
            {
                case 4:
                    name = parts[0];
                    code = parts[1];
                    region = parts[2];
                    popText = parts[3];
                    break;
                case 5:
                    name = parts[0] + ", " + parts[1];
                    name = name.Replace("\"", null).Trim();
                    code = parts[2];
                    region = parts[3];
                    popText = parts[4];
                    break;
                default:
                    throw new Exception($"Can't parse country fro csvLine: {csvLine}");
            }

            // TryParse leaves population=0 if it can't parse
            int.TryParse(popText, out int population);
            return new Country(name, code, region, population);
        }
    }
}