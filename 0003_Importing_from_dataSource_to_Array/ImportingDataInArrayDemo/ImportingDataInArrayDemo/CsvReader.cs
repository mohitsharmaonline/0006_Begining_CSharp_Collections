using System;

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
    }
}