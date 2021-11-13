using System;

namespace workspace
{
    class Program
    {
        // function to get the full month name
        static string getMonthName(int monthNumber) 
        {
            DateTime date = new DateTime(2021, monthNumber, 1);
            return date.ToString("MMMM");
        }

        static void Main(string[] args)
        {
            Console.Write(getMonthName(1));
        }
    }
}
