using System;
using System.Linq;

namespace RestrictedCallDates
{
    public class RestrictedDates
    {
        public static bool IsDateRestricted(DateTime timeNow)
        {
            //NEW YEARS - NATIONAL - Alabama, Louisiana, Mississippi, Rhode Island, Utah
            if (NewYearsDayCheck(timeNow))
                return true;

            //BATTLE OF NEW ORLEANS - Louisiana
            if (BattleOfNewOrleansCheck(timeNow))
                return true;

            //MARTIN LUTHER KING JR DAY -- third monday in January - Alabama, Louisiana, Mississippi, Rhode Island, Utah, Arkansas
            if (MartinLutherKingJrDayCheck(timeNow))
                return true;

            //MARDI GRAS DAY - Tuesday - Alabama, Louisiana
            if (MardiGrasDayCheck(timeNow))
                return true;

            //PRESIDENT'S DAY -- third monday in February - Alabama, Louisiana, Mississippi, Rhode Island, Utah
            if (PresidentsDayCheck(timeNow))
                return true;

            //GOOD FRIDAY - Louisiana
            if (GoodFridayCheck(timeNow))
                return true;

            //EASTER SUNDAY - NATIONAL - Louisiana
            if (EasterSundayCheck(timeNow))
                return true;

            //CONFEDERATE MEMORIAL DAY - fourth Monday in April - ALABAMA
            if (ConfederateMemorialDayAlabamaCheck(timeNow))
                return true;

            //CONFEDERATE MEMORIAL DAY - MISSISSIPPI
            if (ConfederateMemorialDayMississippiCheck(timeNow))
                return true;

            //RHODE ISLAND INDEPENDENCE DAY
            if (RhodeIslandIndependenceDayCheck(timeNow))
                return true;

            //MEMORIAL DAY  -- last monday in May - Alabama, Louisiana, Mississippi, Rhode Island, Utah
            if (MemorialDayCheck(timeNow))
                return true;

            //CONFEDERATE MEMORIAL DAY - LOUISIANA
            if (ConfederateMemorialDayLouisianaCheck(timeNow))
                return true;

            //JEFFERSON DAVIS BIRTHDAY - ALABAMA
            if (JeffersonDavisBirthdayCheck(timeNow))
                return true;

            //INDEPENCENCE DAY - NATIONAL - Alabama, Louisiana, Mississippi, Rhode Island, Utah
            if (IndependenceDayCheck(timeNow))
                return true;

            //PIONEER DAY - UTAH
            if (PioneerDayCheck(timeNow))
                return true;

            //VICTORY DAY - RHODE ISLAND
            if (VictoryDayCheck(timeNow))
                return true;

            //HUEY P LONG DAY - LOUISIANA
            if (HueyPLongDayCheck(timeNow))
                return true;

            //LABOR DAY -- 1st Monday in September
            if (LaborDayCheck(timeNow))
                return true;

            //COLUMBUS DAY - Alabama, Louisiana, Rhode Island, Utah
            if (ColumbusDayCheck(timeNow))
                return true;

            //VETERAN'S DAY - Alabama, Louisiana, Rhode Island, Utah
            if (VeteransDayCheck(timeNow))
                return true;

            //VETERAN'S DAY HOLIDAY MONDAY OBSERVED - Alabama, Louisiana, Rhode Island, Utah
            var veteransDay = new DateTime(timeNow.Year, 11, 11);
            DayOfWeek dayOfWeek = veteransDay.DayOfWeek;
            if (dayOfWeek == DayOfWeek.Saturday || dayOfWeek == DayOfWeek.Sunday)
            {
                if (VeteransDayHolidayCheck(timeNow))
                    return true;
            }

            //ARMISTICE DAY - Mississippi
            if (ArmisticeDayCheck(timeNow))
                return true;

            //THANKSGIVING DAY - 4th Thursday in November - NATIONAL - Alabama, Louisiana, Mississippi, Rhode Island, Utah
            if (ThanksgivingDayCheck(timeNow))
                return true;

            //CHRISTMAS DAY - NATIONAL - Alabama, Louisiana, Mississippi, Rhode Island, Utah
            if (ChristmasDayCheck(timeNow))
                return true;

            return false;
        }

        private static bool NewYearsDayCheck(DateTime timeNow)
        {
            DateTime newYearsDay = new DateTime(timeNow.Year, 1, 1);
            return timeNow.Date == newYearsDay.Date;
        }

        private static bool BattleOfNewOrleansCheck(DateTime timeNow)
        {
            DateTime battleOfNewOrleans = new DateTime(timeNow.Year, 1, 8);
            return timeNow.Date == battleOfNewOrleans.Date;
        }

        private static bool MartinLutherKingJrDayCheck(DateTime timeNow)
        {
            DateTime martinLutherKingJrDay = new DateTime(timeNow.Year, 1, 21);
            martinLutherKingJrDay = DateHelpers.AdjustForUniformHolidayMondayObserved(martinLutherKingJrDay);

            return timeNow.Date == martinLutherKingJrDay.Date;
        }

        private static bool MardiGrasDayCheck(DateTime timeNow)
        {
            DateTime mardiGrasDay = DateHelpers.EasterSunday(timeNow.Year).AddDays(-47);
            return timeNow.Date == mardiGrasDay.Date;
        }

        private static bool PresidentsDayCheck(DateTime timeNow)
        {
            DateTime presidentsDay = new DateTime(timeNow.Year, 2, 21);
            return timeNow.Date == DateHelpers.AdjustForUniformHolidayMondayObserved(presidentsDay).Date;
        }

        private static bool GoodFridayCheck(DateTime timeNow)
        {
            DateTime goodFriday = DateHelpers.EasterSunday(timeNow.Year).AddDays(-2);
            return timeNow.Date == goodFriday.Date;
        }

        private static bool EasterSundayCheck(DateTime timeNow)
        {
            DateTime easterSunday = DateHelpers.EasterSunday(timeNow.Year);
            return timeNow.Date == easterSunday.Date;
        }

        private static bool ConfederateMemorialDayAlabamaCheck(DateTime timeNow)
        {
            DateTime confederateMemorialDayAlabama = new DateTime(timeNow.Year, 4, 22);
            return timeNow.Date == DateHelpers.AdjustForUniformHolidayMondayObserved(confederateMemorialDayAlabama).Date;
        }

        private static bool ConfederateMemorialDayMississippiCheck(DateTime timeNow)
        {
            DateTime confederateMemorialDayMississippi = new DateTime(timeNow.Year, 4, 29);
            return timeNow.Date == DateHelpers.AdjustForUniformHolidayMondayObserved(confederateMemorialDayMississippi).Date;
        }

        private static bool RhodeIslandIndependenceDayCheck(DateTime timeNow)
        {
            DateTime rhodeIslandIndependenceDay = new DateTime(timeNow.Year, 5, 4);
            return timeNow.Date == rhodeIslandIndependenceDay.Date;
        }

        private static bool MemorialDayCheck(DateTime timeNow)
        {
            DateTime memorialDay = new DateTime(timeNow.Year, 5, 31);
            return timeNow.Date == DateHelpers.AdjustForUniformHolidayMondayObserved(memorialDay).Date;
        }

        private static bool ConfederateMemorialDayLouisianaCheck(DateTime timeNow)
        {
            DateTime confederateMemorialDayLouisiana = new DateTime(timeNow.Year, 6, 3);
            return timeNow.Date == confederateMemorialDayLouisiana.Date;
        }

        private static bool JeffersonDavisBirthdayCheck(DateTime timeNow)
        {
            DateTime jeffersonDavisBirthday = new DateTime(timeNow.Year, 6, 1);
            return timeNow.Date == DateHelpers.AdjustForUniformHolidayMondayObserved(jeffersonDavisBirthday).Date;
        }

        private static bool IndependenceDayCheck(DateTime timeNow)
        {
            DateTime independenceDay = new DateTime(timeNow.Year, 7, 4);
            return timeNow.Date == independenceDay.Date;
        }

        private static bool PioneerDayCheck(DateTime timeNow)
        {
            DateTime pioneerDay = new DateTime(timeNow.Year, 7, 24);
            return timeNow.Date == pioneerDay.Date;
        }

        private static bool VictoryDayCheck(DateTime timeNow)
        {
            DateTime victoryDay = new DateTime(timeNow.Year, 8, 12);
            return timeNow.Date == DateHelpers.AdjustForUniformHolidayMondayObserved(victoryDay).Date;
        }

        private static bool HueyPLongDayCheck(DateTime timeNow)
        {
            DateTime hueyPLongDay = new DateTime(timeNow.Year, 8, 30);
            return timeNow.Date == hueyPLongDay.Date;
        }

        private static bool LaborDayCheck(DateTime timeNow)
        {
            DateTime laborDay = new DateTime(timeNow.Year, 9, 1);
            return timeNow.Date == DateHelpers.AdjustForUniformHolidayMondayObserved(laborDay).Date;
        }

        private static bool ColumbusDayCheck(DateTime timeNow)
        {
            DateTime columbusDay = new DateTime(timeNow.Year, 10, 14);
            return timeNow.Date == DateHelpers.AdjustForUniformHolidayMondayObserved(columbusDay).Date;
        }

        private static bool VeteransDayCheck(DateTime timeNow)
        {
            DateTime veteransDay = new DateTime(timeNow.Year, 11, 11);
            return timeNow.Date == veteransDay.Date;
        }

        private static bool VeteransDayHolidayCheck(DateTime timeNow)
        {
            var veteransDay = new DateTime(timeNow.Year, 11, 11);
            return timeNow.Date == DateHelpers.AdjustForUniformHolidayMondayObserved(veteransDay).Date;            
        }

        private static bool ArmisticeDayCheck(DateTime timeNow)
        {
            var armisticeDay = new DateTime(timeNow.Year, 11, 11);
            return timeNow.Date == DateHelpers.AdjustForUniformHolidayMondayObserved(armisticeDay).Date;
        }

        private static bool ThanksgivingDayCheck(DateTime timeNow)
        {
            var thanksgiving = (from day in Enumerable.Range(1, 30)
                                where new DateTime(timeNow.Year, 11, day).DayOfWeek == DayOfWeek.Thursday
                                select day).ElementAt(3);
            DateTime thanksgivingDay = new DateTime(timeNow.Year, 11, thanksgiving);
            return timeNow.Date == thanksgivingDay.Date;
        }

        private static bool ChristmasDayCheck(DateTime timeNow)
        {
            DateTime christmasDay = new DateTime(timeNow.Year, 12, 25);
            return timeNow.Date == christmasDay.Date;
        }            
    }
}
