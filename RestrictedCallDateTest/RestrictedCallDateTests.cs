using System;
using Xunit;
using RestrictedCallDates;
using System.Collections.Generic;

namespace RestrictedCallDatesTests
{
    public class TestRestrictedCallDates
    {
        // 2019 DNC Restricted Dates 
        [Fact]
        public void TestGetUniformHolidays()
        {
            Dictionary<string, DateTime> uniformHolidays = UniformHolidays.GetUniformHolidays(DateTime.UtcNow.Year);
            Assert.True(uniformHolidays.Count > 0);
        }

        [Fact]
        public void TestGetStaticHolidays()
        {
            Dictionary<string, DateTime> staticHolidays = StaticHolidays.GetStaticHolidays(DateTime.UtcNow.Year);
            Assert.True(staticHolidays.Count > 0);
        }

        [Fact]
        public void TestHandleNewYearsDay()
        {
            //NEW YEARS DAY - NATIONAL - Alabama, Louisiana, Mississippi, Rhode Island, Utah
            DateTime testTimeNow = new DateTime(DateTime.UtcNow.Year, 1, 1);
            Assert.True(RestrictedDates.IsDateRestricted(testTimeNow));
        }

        [Fact]
        public void TestHandleBattleOfNewOrleans()
        {
            //BATTLE OF NEW ORLEANS - LOUISIANA 
            DateTime testTimeNow = new DateTime(DateTime.UtcNow.Year, 1, 8);
            Assert.True(RestrictedDates.IsDateRestricted(testTimeNow));
        }

        [Fact]
        public void TestHandleMLKDay()
        {
            //MARTIN LUTHER KING JR DAY -- third monday in January - Alabama, Louisiana, Mississippi, Rhode Island, Utah, Arkansas
            DateTime testTimeNow = new DateTime(2019, 1, 21);
            Assert.True(RestrictedDates.IsDateRestricted(testTimeNow));
        }

        [Fact]
        public void TestHandleMardiGrasDay()
        {
            //MARDI GRAS DAY - Tuesday - Alabama, Louisiana 
            DateTime testTimeNow = new DateTime(2019, 3, 5);
            Assert.True(RestrictedDates.IsDateRestricted(testTimeNow));
        }

        [Fact]
        public void TestHandlePresidentsDay()
        {
            //PRESIDENT'S DAY -- third monday in February - Alabama, Louisiana, Mississippi, Rhode Island, Utah
            DateTime testTimeNow = new DateTime(2019, 2, 18);
            Assert.True(RestrictedDates.IsDateRestricted(testTimeNow));
        }

        [Fact]
        public void TestHandleGoodFriday()
        {
            //GOOD FRIDAY - Louisiana 
            DateTime testTimeNow = new DateTime(2019, 4, 19);
            Assert.True(RestrictedDates.IsDateRestricted(testTimeNow));
        }

        [Fact]
        public void TestHandleEasterSunday()
        {
            //EASTER SUNDAY - NATIONAL 
            DateTime testTimeNow = new DateTime(2019, 4, 21);
            Assert.True(RestrictedDates.IsDateRestricted(testTimeNow));
        }

        [Fact]
        public void TestHandleConfederateMemorialDayAL()
        {
            //CONFEDERATE MEMORIAL DAY - fourth Monday in April - ALABAMA
            DateTime testTimeNow = new DateTime(2019, 4, 22);
            Assert.True(RestrictedDates.IsDateRestricted(testTimeNow));
        }

        [Fact]
        public void TestHandleConfederateMemorialDayMS()
        {
            //CONFEDERATE MEMORIAL DAY - MISSISSIPPI
            DateTime testTimeNow = new DateTime(2019, 4, 29);
            Assert.True(RestrictedDates.IsDateRestricted(testTimeNow));
        }

        [Fact]
        public void TestHandleRhodeIslandIndependenceDay()
        {
            //RHODE ISLAND INDEPENDENCE DAY
            DateTime testTimeNow = new DateTime(DateTime.UtcNow.Year, 5, 4);
            Assert.True(RestrictedDates.IsDateRestricted(testTimeNow));
        }

        [Fact]
        public void TestHandleMemorialDay()
        {
            //MEMORIAL DAY  -- last monday in May - Alabama, Louisiana, Mississippi, Rhode Island, Utah
            DateTime testTimeNow = new DateTime(2019, 5, 27);
            Assert.True(RestrictedDates.IsDateRestricted(testTimeNow));
        }

        [Fact]
        public void TestConfederateMemorialDayLA()
        {
            //CONFEDERATE MEMORIAL DAY - LOUISIANA
            DateTime testTimeNow = new DateTime(DateTime.UtcNow.Year, 6, 3);
            Assert.True(RestrictedDates.IsDateRestricted(testTimeNow));
        }

        [Fact]
        public void TestJeffersonDavisBirthday()
        {
            //JEFFERSON DAVIS BIRTHDAY - ALABAMA
            DateTime testTimeNow = new DateTime(2019, 6, 3);
            Assert.True(RestrictedDates.IsDateRestricted(testTimeNow));
        }

        [Fact]
        public void TestIndependenceDay()
        {
            //INDEPENDENCE DAY - NATIONAL
            DateTime testTimeNow = new DateTime(DateTime.UtcNow.Year, 7, 4);
            Assert.True(RestrictedDates.IsDateRestricted(testTimeNow));
        }

        [Fact]
        public void TestPioneerDay()
        {
            //PIONEER DAY - UTAH 7/24
            DateTime testTimeNow = new DateTime(DateTime.UtcNow.Year, 7, 24);
            Assert.True(RestrictedDates.IsDateRestricted(testTimeNow));
        }

        [Fact]
        public void TestVictoryDay()
        {
            //VICTORY DAY - RHODE ISLAND
            DateTime testTimeNow = new DateTime(2019, 8, 12);
            Assert.True(RestrictedDates.IsDateRestricted(testTimeNow));
        }

        [Fact]
        public void TestHueyPLongDay()
        {
            //HUEY P LONG DAY - LOUISIANA
            DateTime testTimeNow = new DateTime(DateTime.UtcNow.Year, 8, 30);
            Assert.True(RestrictedDates.IsDateRestricted(testTimeNow));
        }

        [Fact]
        public void TestLaborDay()
        {
            //LABOR DAY -- 1st Monday in September 
            DateTime testTimeNow = new DateTime(2019, 9, 2);
            Assert.True(RestrictedDates.IsDateRestricted(testTimeNow));
        }

        [Fact]
        public void TestColumbusDay()
        {
            //COLUMBUS DAY - Alabama, Louisiana, Rhode Island, Utah
            DateTime testTimeNow = new DateTime(2019, 10, 14);
            Assert.True(RestrictedDates.IsDateRestricted(testTimeNow));
        }

        [Fact]
        public void TestVeteransDay()
        {
            //VETERAN'S DAY - Alabama, Louisiana, Rhode Island, Utah
            DateTime testTimeNow = new DateTime(DateTime.UtcNow.Year, 11, 11);
            Assert.True(RestrictedDates.IsDateRestricted(testTimeNow));
        }

        [Fact]
        public void TestVeteransDayHoliday()
        {
            //VETERAN'S DAY HOLIDAY - Alabama, Louisiana, Rhode Island, Utah
            //Monday
            DateTime testTimeNow = new DateTime(2018, 11, 12);
            Assert.True(RestrictedDates.IsDateRestricted(testTimeNow));
        }

        [Fact]
        public void TestArmisticeDay()
        {
            //ARMISTICE DAY - Mississippi
            DateTime testTimeNow = new DateTime(2019, 11, 11);
            Assert.True(RestrictedDates.IsDateRestricted(testTimeNow));
        }

        [Fact]
        public void TestThanksgivingDay()
        {
            //THANKSGIVING DAY - NATIONAL
            DateTime testTimeNow = new DateTime(2019, 11, 28);
            Assert.True(RestrictedDates.IsDateRestricted(testTimeNow));
        }

        [Fact]
        public void TestChristmasDay()
        {
            //CHRISTMAS DAY - NATIONAL
            DateTime testTimeNow = new DateTime(DateTime.UtcNow.Year, 12, 25);
            Assert.True(RestrictedDates.IsDateRestricted(testTimeNow));
        }
    }
}
