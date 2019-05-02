using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1._2_Conversion
{
    class Program
    {  //read a number from the console- it is number of days, converts to years, months weeks, days
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number");
            int number = Convert.ToInt32(Console.ReadLine());
            int years = number / 365;
            int months = (number %365) / 30;
            int weeks = (number % 365) / 7; 
            int days = (number % 365 )%30 /7;
            Console.WriteLine("Converted to: " + years + " years " + months + " months " + weeks + " weeks " + number + " days");

        }
    }
}