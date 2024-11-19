using Microsoft.VisualBasic;

namespace Assignment_3._1._2
{
    internal class Program
    {
        //Given a year as integer, write a method that checks if year is leap.

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsLeapYear(year) ? $"{year} is a leap year." : $"{year} is not a leap year.");
        }

        static bool IsLeapYear(int year)
        {
            if  (year % 4 == 0 )
            {
                if (year % 100 != 0)
                {
                    return true;
                }
            }
            if (year % 400 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
