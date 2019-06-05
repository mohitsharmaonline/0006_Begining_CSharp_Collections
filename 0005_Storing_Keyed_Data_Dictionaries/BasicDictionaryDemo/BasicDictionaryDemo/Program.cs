using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Country norway = new Country("Norway", "NOR", "Europe", 5_282_223);
            Country finland = new Country("Finland", "FIN", "Europe", 5_511_383);

            Dictionary<string, Country> countries = new Dictionary<string, Country>();
            countries.Add(norway.Code, norway);
            countries.Add(norway.Code, norway);
            
            foreach (var country in countries.Values)
            {
                Console.WriteLine(country.Name);
            }

            //List<Country> countrieslst = new List<Country>();
            //countrieslst.Add(norway);
            //countrieslst.Add(norway);

            //foreach (var country in countrieslst)
            //{
            //    Console.WriteLine(country.Name);
            //}

        }
    }
}
