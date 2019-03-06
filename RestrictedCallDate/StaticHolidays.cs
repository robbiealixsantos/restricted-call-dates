using System;
using System.Collections.Generic;
using System.Text;

namespace RestrictedCallDates
{
    public class StaticHolidays
    {
        public static Dictionary<string, DateTime> GetStaticHolidays(int year)
        {
            Dictionary<string, DateTime> staticHolidays = new Dictionary<string, DateTime>();

            //New Years Day - 1/1
            DateTime newYearsDay = new DateTime(year, 1, 1);
            staticHolidays.Add("New Year's Day", newYearsDay);

            //Battle of New Orleans 1/8
            DateTime battleOfNewOrleans = new DateTime(year, 1, 8);
            staticHolidays.Add("Battle of New Orleans", battleOfNewOrleans);

            //Rhode Island Independence Day - 5/4
            DateTime rhodeIslandIndependenceDay = new DateTime(year, 5, 4);
            staticHolidays.Add("Rhode Island Independence Day", rhodeIslandIndependenceDay);

            //Confederate Memorial Day Louisana - 6/3
            DateTime confederateMemorialDayLouisiana = new DateTime(year, 6, 3);
            staticHolidays.Add("Confederate Memorial Day Louisiana", confederateMemorialDayLouisiana);

            //Independence Day - 7/4
            DateTime independenceDay = new DateTime(year, 7, 4);
            staticHolidays.Add("Independence Day", independenceDay);

            //Pioneer Day - 7/24
            DateTime pioneerDay = new DateTime(year, 7, 24);
            staticHolidays.Add("Pioneer Day", pioneerDay);

            //Huey P Long Day - 8/30
            DateTime hueyPLongDay = new DateTime(year, 8, 30);
            staticHolidays.Add("Huey P Long Day", hueyPLongDay);

            //Veteran's Day - 11/11
            DateTime veteransDay = new DateTime(year, 11, 11);
            staticHolidays.Add("Veteran's Day", veteransDay);

            //Christmas Day - 12/25
            DateTime christmasDay = new DateTime(year, 12, 25);
            staticHolidays.Add("Christmas Day", christmasDay);

            return staticHolidays;
        }
    }
}
