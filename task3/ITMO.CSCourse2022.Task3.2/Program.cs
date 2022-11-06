using System;
using System.Reflection;

namespace ITMO.CSCourse2022.Task3._2
{
    enum MonthName
    {
        January,
        Febrary,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }


    internal class ProgramWhatDayUpdate
    {
        static void Main()
        {
            try 
            {
                string line;
                int dayNum;
                int monthNum = 0;

                Console.WriteLine("Enter a day number between 1 and 365: ");
                line = Console.ReadLine();
                dayNum = int.Parse(line);
                if (dayNum < 1 || dayNum > 365)
                    throw new ArgumentOutOfRangeException("Day is out of range");

                int[] DaysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                foreach (int daysInMonth in DaysInMonth)
                {
                    if (dayNum <= daysInMonth)
                        break;
                    else
                    {
                        dayNum -= daysInMonth;
                        monthNum++;
                    }
                }


                MonthName temp = (MonthName)monthNum;
                string monthName = temp.ToString();

                Console.WriteLine("{1} {0}th", dayNum, monthName);

            }
            catch (Exception caught)
            {
                Console.WriteLine(caught.Message);
            }            
        }
    }
}
