Restricted Call Dates
===============
Nuget: Install-Package RestrictedCallDate [![Nuget](https://img.shields.io/nuget/v/RestrictedCallDate.svg) ](https://www.nuget.org/packages/RestrictedCallDate/)

Nuget package created for Contact Center TCPA & DNC Compliance. Calls from contact centers to certain states on these dates could result in a potential state violation. 

```C#
//Returns a dictionary of each holiday and date of 2019 uniform holidays
Dictionary<string, DateTime> uniformHolidays = UniformHolidays.GetUniformHolidays(2019);

//Returns a dictionary of each holiday and date of 2019 static holidays
Dictionary<string, DateTime> staticHolidays = StaticHolidays.GetStaticHolidays(2019);

//Returns true or false if current date falls on any restricted call date in library
//MARTIN LUTHER KING JR DAY -- third monday in January - Alabama, Louisiana, Mississippi, Rhode Island, Utah, Arkansas
DateTime timeNow = new DateTime(2019, 1, 21);
RestrictedDates.IsDateRestricted(testTimeNow)
```

Current Holidays and Affected States

```
NEW YEARS - NATIONAL - Alabama, Louisiana, Mississippi, Rhode Island, Utah
BATTLE OF NEW ORLEANS - Louisiana
MARTIN LUTHER KING JR DAY -- third monday in January - Alabama, Louisiana, Mississippi, Rhode Island, Utah, Arkansas
MARDI GRAS DAY - Tuesday - Alabama, Louisiana
PRESIDENT'S DAY -- third monday in February - Alabama, Louisiana, Mississippi, Rhode Island, Utah
GOOD FRIDAY - Louisiana
EASTER SUNDAY - NATIONAL - Louisiana
CONFEDERATE MEMORIAL DAY - fourth Monday in April - ALABAMA
CONFEDERATE MEMORIAL DAY - MISSISSIPPI
RHODE ISLAND INDEPENDENCE DAY
MEMORIAL DAY  -- last monday in May - Alabama, Louisiana, Mississippi, Rhode Island, Utah
CONFEDERATE MEMORIAL DAY - LOUISIANA
JEFFERSON DAVIS BIRTHDAY - ALABAMA
INDEPENCENCE DAY - NATIONAL - Alabama, Louisiana, Mississippi, Rhode Island, Utah
PIONEER DAY - UTAH
VICTORY DAY - RHODE ISLAND
HUEY P LONG DAY - LOUISIANA
LABOR DAY -- 1st Monday in September
COLUMBUS DAY - Alabama, Louisiana, Rhode Island, Utah
VETERAN'S DAY - Alabama, Louisiana, Rhode Island, Utah
VETERAN'S DAY HOLIDAY MONDAY OBSERVED - Alabama, Louisiana, Rhode Island, Utah
ARMISTICE DAY - Mississippi
THANKSGIVING DAY - 4th Thursday in November - NATIONAL - Alabama, Louisiana, Mississippi, Rhode Island, Utah
CHRISTMAS DAY - NATIONAL - Alabama, Louisiana, Mississippi, Rhode Island, Utah
```
