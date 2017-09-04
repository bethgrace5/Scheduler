using System.ComponentModel;

namespace scheduler.Infrastructure.Database.Seeds
{
    // Description
    internal enum HourChangeReasonEnum
    {
        [Description("No Reason Specified")] None,
        [Description("Holiday")] Holiday
    }

    // Description
    internal enum NotificationEnum
    {
        [Description("New Schedule Has Been Published")] NewSchedulePublished
    }

    // Description
    internal enum NotificationMediaEnum
    {
        [Description("Email")] Email,
        [Description("Text Message")] Text,
        [Description("Push Notification")] Push
    }

    // Description
    internal enum PermissionEnum
    {
        [Description("Manage Schedule")] ManageSchedules,
        [Description("Manage Employees")] ManageEmployees,
        [Description("Manage Users")] ManageUsers,
        [Description("Manage Business")] ManageBusiness,
        [Description("Manage Self")] ManageSelf
    }

    // Description
    internal enum RoleEnum
    {
        [Description("Administrator Role")] Administrator,
        [Description("Business Level Role")] Business,
        [Description("Location Level Role")] Location,
        [Description("Employee Level Role")] Employee
    }

    // Description
    internal enum StatusEnum
    {
        [Description("Active")] Active,
        [Description("Disabled")] Disabled
    }

    // Description, Country, Standard Time, Daylight Time, States
    internal enum TimeZoneEnum
    {
        [Description("Hawaii–Aleutian Time Zone,US,HAST (UTC−10:00),HADT (UTC−09:00),AK;HI")]
        HawaiiAleutianTimeZone,

        [Description("Alaska Time Zone,US,AKST (UTC−09:00),AKDT (UTC−08:00),AK")]
        AlaskaTimeZone,

        [Description("Pacific Time Zone,US,PST (UTC−08:00),PDT (UTC−07:00),CA;WA;OR;NV;ID")]
        PacificTimeZone,

        [Description("Mountain Time Zone,US,MST (UTC−07:00),MDT (UTC−06:00),AZ;CO;ID;KS;MT;NE;NV;NM;ND;OR;SD;TX;UT;WY")]
        MountainTimeZone,

        [Description("Central Time Zone,US,CST (UTC−06:00),CDT (UTC−05:00),AL;AR;FL;IL;IN;IA;KS;KY;LA;MI;MN;MS;MO;NE;ND;OK;SD;TN;TX;WI")]
        CentralTimeZone,

        [Description("Eastern Time Zone,US,EST (UTC−05:00),EDT (UTC−04:00),CT;FL;Washington DC;DE;GA;IN;KY;ME;MA;MI;NH;NJ;NY;NC;OH;PA;RI;SC;TN;VT;MD;VA;WV")]
        EasternTimeZone
    }

    // Description
    internal enum WeekdayEnum
    {
        [Description("Sunday")] Sunday,
        [Description("Monday")] Monday,
        [Description("Tuesday")] Tuesday,
        [Description("Wednesday")] Wednesday,
        [Description("Thursday")] Thursday,
        [Description("Friday")] Friday,
        [Description("Saturday")] Saturday
    }

    // Description, Code
    internal enum CountryEnum
    {
        [Description("United States of Americal,USA")] UnitedStates
    }

    // Description
    internal enum LanguageEnum
    {
        [Description("English")] English,
        [Description("Spanish")] Spanish
    }

    // Description, Code, Type
    internal enum UsStatesAndTerritoriesEnum
    {
        [Description("Alabama,AL,State")] Alabama,
        [Description("Alaska,AK,State")] Alaska,
        [Description("AmericanSamoa,AS,Territory")] AmericanSamoa,
        [Description("Arizona,AZ,State")] Arizona,
        [Description("Arkansas,AR,State")] Arkansas,
        [Description("California,CA,State")] California,
        [Description("Colorado,CO,State")] Colorado,
        [Description("Connecticut,CT,State")] Connecticut,
        [Description("District Of Columbia,Washington DC,Federal district of the United States")] DistrictOfColumbia,
        [Description("Delaware,DE,State")] Delaware,
        [Description("Florida,FL,State")] Florida,
        [Description("Georgia,GA,State")] Georgia,
        [Description("Guam,GU,Territory")] Guam,
        [Description("Hawaii,HI,State")] Hawaii,
        [Description("Idaho,ID,State")] Idaho,
        [Description("Illinois,IL,State")] Illinois,
        [Description("Indiana,IN,State")] Indiana,
        [Description("Iowa,IA,State")] Iowa,
        [Description("Kansas,KS,State")] Kansas,
        [Description("Kentucky,KY,State")] Kentucky,
        [Description("Louisiana,LA,State")] Louisiana,
        [Description("Maine,ME,State")] Maine,
        [Description("Maryland,MD,State")] Maryland,
        [Description("Massachusetts,MA,State")] Massachusetts,
        [Description("Michigan,MI,State")] Michigan,
        [Description("Minnesota,MN,State")] Minnesota,
        [Description("Mississippi,MS,State")] Mississippi,
        [Description("Missouri,MO,State")] Missouri,
        [Description("Montana,MT,State")] Montana,
        [Description("Nebraska,NE,State")] Nebraska,
        [Description("Nevada,NV,State")] Nevada,
        [Description("New Hampshire,NH,State")] NewHampshire,
        [Description("New Jersey,NJ,State")] NewJersey,
        [Description("New Mexico,NM,State")] NewMexico,
        [Description("New York,NY,State")] NewYork,
        [Description("North Carolina,NC,State")] NorthCarolina,
        [Description("North Marianas Islands,MP,Territory")] NorthMarianasIslands,
        [Description("North Dakota,ND,State")] NorthDakota,
        [Description("Ohio,OH,State")] Ohio,
        [Description("Oklahoma,OK,State")] Oklahoma,
        [Description("Oregon,OR,State")] Oregon,
        [Description("Pennsylvania,PA,State")] Pennsylvania,
        [Description("Puerto Rico,PR,Territory")] PuertoRico,
        [Description("Rhode Island,RI,State")] RhodeIsland,
        [Description("South Carolina,SC,State")] SouthCarolina,
        [Description("South Dakota,SD,State")] SouthDakota,
        [Description("Tennessee,TN,State")] Tennessee,
        [Description("Texas,TX,State")] Texas,
        [Description("Utah,UT,State")] Utah,
        [Description("Vermont,VT,State")] Vermont,
        [Description("Virginia,VA,State")] Virginia,
        [Description("U.S. Virgin Islands,VI,Territory")] USVirginIslands,
        [Description("Washington,WA,State")] Washington,
        [Description("West Virginia,WV,State")] WestVirginia,
        [Description("Wisconsin,WI,State")] Wisconsin,
        [Description("Wyoming,WY,State")] Wyoming
    }
}