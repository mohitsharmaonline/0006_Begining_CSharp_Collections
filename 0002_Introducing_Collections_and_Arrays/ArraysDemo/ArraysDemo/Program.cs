using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] daysOfWeek = {
                "Monday",
                "Tuesday",      
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            Console.WriteLine("Which day do you want to display?");
            Console.WriteLine("(Monday = 1, etc.) > ");
            int iDay = int.Parse(Console.ReadLine());

            string chosenDay = daysOfWeek[iDay];
            Console.WriteLine($"That day is {chosenDay}");
        }
    }
}
