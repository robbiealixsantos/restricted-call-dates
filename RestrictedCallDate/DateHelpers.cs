using System;
using System.Collections.Generic;
using System.Text;

namespace RestrictedCallDates
{
    public class DateHelpers
    {
        public static DateTime AdjustForUniformHolidayMondayObserved(DateTime holiday)
        {
            DayOfWeek dayOfWeek = holiday.DayOfWeek;
            var armisticeDayAndVeteransDayObserved = new DateTime(holiday.Year, 11, 11);
            while (holiday.DayOfWeek != DayOfWeek.Monday)
            {
                if (holiday.Day == 1 || holiday == armisticeDayAndVeteransDayObserved)
                {
                    while (holiday.DayOfWeek != DayOfWeek.Monday)
                    {
                        holiday = holiday.AddDays(1);
                        dayOfWeek = holiday.DayOfWeek;
                    }
                }
                else
                {
                    holiday = holiday.AddDays(-1);
                    dayOfWeek = holiday.DayOfWeek;
                }
            }
            return holiday;
        }

        public static DateTime EasterSunday(int year)
        {
            int day = 0;
            int month = 0;

            int goldenNumber = year % 19;
            int century = year / 100;
            int daysBetweenEquinoxAndNextFullMoon = (century - (century / 4) - ((8 * century + 13) / 25) + 19 * goldenNumber + 15) % 30;
            int daysFirstSundayBetweenFullMoonAfterEquinox = daysBetweenEquinoxAndNextFullMoon - (daysBetweenEquinoxAndNextFullMoon / 28) *
                (1 - (daysBetweenEquinoxAndNextFullMoon / 28) * (29 / (daysBetweenEquinoxAndNextFullMoon + 1)) * ((21 - goldenNumber) / 11));

            day = daysFirstSundayBetweenFullMoonAfterEquinox - ((year + (year / 4) + daysFirstSundayBetweenFullMoonAfterEquinox + 2 - century + (century / 4)) % 7) + 28;
            month = 3;

            if (day > 31)
            {
                month++;
                day -= 31;
            }

            return new DateTime(year, month, day).Date;
        }
    }
}
