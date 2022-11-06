using System;
using System.Reflection;

namespace ITMO.CSCourse2022.Task3._3
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


    internal class ProgramWhatDayUpdateYearType
    {
        static void Main()
        {
            try
            {
                string line;
                Console.WriteLine("Enter a year: ");
                line = Console.ReadLine();
                int yearNum= int.Parse(line);
                bool isYearLeap = (yearNum%4 ==0)&&(yearNum%100 != 0)||yearNum%400 == 0;
                if (isYearLeap)
                    Console.WriteLine(" This year is leap ");
                else
                    Console.WriteLine(" This year is Not leap");

                int maxDayNum = isYearLeap ? 366 : 365;
                int dayNum;
                int monthNum = 0;
                int februaryDays = isYearLeap ? 29 : 28;

                Console.WriteLine("Enter a day number between 1 and {0}: ", maxDayNum);
                line = Console.ReadLine();
                dayNum = int.Parse(line);
                if (dayNum < 1 || dayNum > maxDayNum)
                    throw new ArgumentOutOfRangeException("Day is out of range");

                int[] DaysInMonth = { 31, februaryDays, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
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
