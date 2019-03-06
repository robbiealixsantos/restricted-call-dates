using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestrictedCallDates
{
    public class UniformHolidays
    {
       public static Dictionary<string, DateTime> GetUniformHolidays(int year)
       {
            Dictionary<string, DateTime> uniformHolidays = new Dictionary<string, DateTime>();

            //Martin Luther King Day - third Monday in January
            DateTime martinLutherKingJrDay = new DateTime(year, 1, 21);
            uniformHolidays.Add("Martin Luther King Jr. Day",
                DateHelpers.AdjustForUniformHolidayMondayObserved(martinLutherKingJrDay).Date);

            //President's Day - third Monday in February
            DateTime presidentsDay = new DateTime(year, 2, 21);
            uniformHolidays.Add("President's Day",
                DateHelpers.AdjustForUniformHolidayMondayObserved(presidentsDay));

            //Confederate Memorial Day Alabama - 4th Monday in April
            DateTime confederateMemorialDayAlabama = new DateTime(year, 4, 22);
            uniformHolidays.Add("Confederate Memorial Day Alabama",
                DateHelpers.AdjustForUniformHolidayMondayObserved(confederateMemorialDayAlabama).Date);

            //Confederate Memorial Day Mississippi - last Monday in April
            DateTime confederateMemorialDayMississippi = new DateTime(year, 4, 29);
            uniformHolidays.Add("Confederate Memorial Day Mississippi",
                DateHelpers.AdjustForUniformHolidayMondayObserved(confederateMemorialDayMississippi).Date);

            //Mardi Gras - always 47 days before Easter Sunday
            uniformHolidays.Add("Mardi Gras Day", DateHelpers.EasterSunday(year).AddDays(-47).Date);

            //Good Friday - always 2 days before Easter Sunday
            uniformHolidays.Add("Good Friday", DateHelpers.EasterSunday(year).AddDays(-2).Date);

            //Easter Sunday
            uniformHolidays.Add("Easter Sunday", DateHelpers.EasterSunday(year).Date);

            //Memorial Day - last Monday in May 
            DateTime memorialDay = new DateTime(year, 5, 31);
            uniformHolidays.Add("Memorial Day",
                DateHelpers.AdjustForUniformHolidayMondayObserved(memorialDay).Date);

            //Jefferson Davis Birthday - 1st Monday in June 
            DateTime jeffersonDavisBirthday = new DateTime(year, 6, 1);
            uniformHolidays.Add("Jefferson Davis Birthday",
                DateHelpers.AdjustForUniformHolidayMondayObserved(jeffersonDavisBirthday).Date);

            //Victory Day - 2nd Monday in August
            DateTime victoryDay = new DateTime(year, 8, 12);
            uniformHolidays.Add("Victory Day",
                DateHelpers.AdjustForUniformHolidayMondayObserved(victoryDay).Date);

            //Labor Day - 1st Monday in September 
            DateTime laborDay = new DateTime(year, 9, 1);
            uniformHolidays.Add("Labor Day",
                DateHelpers.AdjustForUniformHolidayMondayObserved(laborDay).Date);

            //Columbus Day - 2nd Monday in October
            DateTime columbusDay = new DateTime(year, 10, 14);
            uniformHolidays.Add("Columbus Day",
                DateHelpers.AdjustForUniformHolidayMondayObserved(columbusDay).Date);

            //Thanksgiving Day - 4th Thursday in November 
            var thanksgiving = (from day in Enumerable.Range(1, 30)
                                where new DateTime(year, 11, day).DayOfWeek == DayOfWeek.Thursday
                                select day).ElementAt(3);
            DateTime thanksgivingDay = new DateTime(year, 11, thanksgiving);
            uniformHolidays.Add("Thanksgiving Day", thanksgivingDay.Date);

            //Armistice Day (MS) - Monday Observed
            var armisticeDay = new DateTime(year, 11, 11);
            uniformHolidays.Add("Armistice Day",
                DateHelpers.AdjustForUniformHolidayMondayObserved(armisticeDay).Date);

            //Veteran's Day Observed Date for Alabama, Louisiana, Rhode Island, Utah
            var veteransDay = new DateTime(year, 11, 11);
            DayOfWeek dayOfWeek = veteransDay.DayOfWeek;
            if (dayOfWeek == DayOfWeek.Saturday || dayOfWeek == DayOfWeek.Sunday)
            {
                uniformHolidays.Add("Veteran's Day Monday Observed",
                    DateHelpers.AdjustForUniformHolidayMondayObserved(veteransDay).Date);
            }

            return uniformHolidays;
       }
    }
}
