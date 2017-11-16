namespace NearEarthObjectTracker.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using NearEarthObjectTracker.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<NearEarthObjectTracker.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NearEarthObjectTracker.Models.ApplicationDbContext context)
        {
            context.Meteor_Showers.AddOrUpdate(x => x.Id,
            new Meteor_Showers() { Id = 1, showerName = "Leonids", dateOfVisibility = "11/17-18/2017", moonPhase = "New" },
            new Meteor_Showers() { Id = 2, showerName = "Geminids", dateOfVisibility = "12/13-14/2017", moonPhase = "Waning Crescent" },
            new Meteor_Showers() { Id = 3, showerName = "Ursids", dateOfVisibility = "12/23-24/2017", moonPhase = "Waxing Crescent" },
            new Meteor_Showers() { Id = 4, showerName = "Quadrantids", dateOfVisibility = "1/3-4/2018", moonPhase = "Waning Gibbous" },
            new Meteor_Showers() { Id = 5, showerName = "Lyrids", dateOfVisibility = "4/22-23/2018", moonPhase = "First Quarter" },
            new Meteor_Showers() { Id = 6, showerName = "Eta Aquarids", dateOfVisibility = "5/10-11/2018", moonPhase = "Waning Crescent" },
            new Meteor_Showers() { Id = 7, showerName = "Perseids", dateOfVisibility = "8/12-13/2018", moonPhase = "Waxing Crescent" }
            );

            context.NearEarthObjects.AddOrUpdate(x => x.Id,
            new NearEarthObjects() { Id = 1, Asteroid_Name = "326354 (2000 SJ344)", closest_Approach_Earth_Date = "2017-11-13", Estimated_Diameter_Max_Kms = 0.1794898848, isAsteroidDangerous = "false", miss_Distance = 0.0732580144 },
            new NearEarthObjects() { Id = 2, Asteroid_Name = "(2014 HQ124)", closest_Approach_Earth_Date = "2017-11-13", Estimated_Diameter_Max_Kms = 0.9863702813, isAsteroidDangerous = "true", miss_Distance = 0.3978784409 },
            new NearEarthObjects() { Id = 3, Asteroid_Name = "(2015 OQ21)", closest_Approach_Earth_Date = "2017-11-13", Estimated_Diameter_Max_Kms = 0.0156329154, isAsteroidDangerous = "false", miss_Distance = 0.4451245002 },
            new NearEarthObjects() { Id = 4, Asteroid_Name = "(2017 VU)", closest_Approach_Earth_Date = "2017-11-13", Estimated_Diameter_Max_Kms = 0.1981709443, isAsteroidDangerous = "false", miss_Distance = 0.0985102729 },
            new NearEarthObjects() { Id = 5, Asteroid_Name = "303250 (2004 RU10)", closest_Approach_Earth_Date = "2017-11-14", Estimated_Diameter_Max_Kms = 1.3615700154, isAsteroidDangerous = "false", miss_Distance = 0.2524962936 },
            new NearEarthObjects() { Id = 6, Asteroid_Name = "(2004 FU4)", closest_Approach_Earth_Date = "2017-11-14", Estimated_Diameter_Max_Kms = 1.30028927, isAsteroidDangerous = "true", miss_Distance = 0.3010037879 },
            new NearEarthObjects() { Id = 7, Asteroid_Name = "(2010 MA)", closest_Approach_Earth_Date = "2017-11-14", Estimated_Diameter_Max_Kms = 0.0430566244, isAsteroidDangerous = "false", miss_Distance = 0.3525762524 },
            new NearEarthObjects() { Id = 8, Asteroid_Name = "455176 (1999 VF22)", closest_Approach_Earth_Date = "2017-11-14", Estimated_Diameter_Max_Kms = 0.4508582062, isAsteroidDangerous = "true", miss_Distance = 0.3372391512 },
            new NearEarthObjects() { Id = 9, Asteroid_Name = "(2016 RA34)", closest_Approach_Earth_Date = "2017-11-14", Estimated_Diameter_Max_Kms = 0.0748238376, isAsteroidDangerous = "false", miss_Distance = 0.2381675853 },
            new NearEarthObjects() { Id = 10, Asteroid_Name = "497117 (2004 FU4)", closest_Approach_Earth_Date = "2017-11-14", Estimated_Diameter_Max_Kms = 1.30028927, isAsteroidDangerous = "true", miss_Distance = 0.3010038493 },
            new NearEarthObjects() { Id = 11, Asteroid_Name = "(2017 UV4)", closest_Approach_Earth_Date = "2017-11-14", Estimated_Diameter_Max_Kms = 0.5453056265, isAsteroidDangerous = "false", miss_Distance = 0.2110980793 },
            new NearEarthObjects() { Id = 12, Asteroid_Name = "(2017 VM2)", closest_Approach_Earth_Date = "2017-11-15", Estimated_Diameter_Max_Kms = 0.1567617051, isAsteroidDangerous = "false", miss_Distance = 0.045891836 },
            new NearEarthObjects() { Id = 13, Asteroid_Name = "(2010 AO2)", closest_Approach_Earth_Date = "2017-11-15", Estimated_Diameter_Max_Kms = 0.1794898848, isAsteroidDangerous = "false", miss_Distance = 0.457104508 },
            new NearEarthObjects() { Id = 14, Asteroid_Name = "(2012 VJ77)", closest_Approach_Earth_Date = "2017-11-15", Estimated_Diameter_Max_Kms = 0.1714115092, isAsteroidDangerous = "false", miss_Distance = 0.2883118552 },
            new NearEarthObjects() { Id = 15, Asteroid_Name = "(2013 VK5)", closest_Approach_Earth_Date = "2017-11-15", Estimated_Diameter_Max_Kms = 0.4721064988, isAsteroidDangerous = "false", miss_Distance = 0.4375022886 },
            new NearEarthObjects() { Id = 16, Asteroid_Name = "(2015 UK52)", closest_Approach_Earth_Date = "2017-11-15", Estimated_Diameter_Max_Kms = 0.5675968529, isAsteroidDangerous = "true", miss_Distance = 0.1745595815 },
            new NearEarthObjects() { Id = 17, Asteroid_Name = "(2017 FN127)", closest_Approach_Earth_Date = "2017-11-15", Estimated_Diameter_Max_Kms = 0.0412515222, isAsteroidDangerous = "false", miss_Distance = 0.3354681506 },
            new NearEarthObjects() { Id = 18, Asteroid_Name = "(2017 FO127)", closest_Approach_Earth_Date = "2017-11-15", Estimated_Diameter_Max_Kms = 0.024447811, isAsteroidDangerous = "false", miss_Distance = 0.3512959785 },
            new NearEarthObjects() { Id = 19, Asteroid_Name = "(2017 UN44)", closest_Approach_Earth_Date = "2017-11-15", Estimated_Diameter_Max_Kms = 0.0578149266, isAsteroidDangerous = "false", miss_Distance = 0.1107303093 },
            new NearEarthObjects() { Id = 20, Asteroid_Name = "(2017 VS12)", closest_Approach_Earth_Date = "2017-11-15", Estimated_Diameter_Max_Kms = 0.1502588217, isAsteroidDangerous = "false", miss_Distance = 0.1969726663 },
            new NearEarthObjects() { Id = 21, Asteroid_Name = "(2017 VV12)", closest_Approach_Earth_Date = "2017-11-15", Estimated_Diameter_Max_Kms = 0.0152770668, isAsteroidDangerous = "false", miss_Distance = 0.0047759997 },
            new NearEarthObjects() { Id = 22, Asteroid_Name = "(1998 QP)", closest_Approach_Earth_Date = "2017-11-16", Estimated_Diameter_Max_Kms = 0.3420109247, isAsteroidDangerous = "true", miss_Distance = 0.2792524298 },
            new NearEarthObjects() { Id = 23, Asteroid_Name = "(2000 UO30)", closest_Approach_Earth_Date = "2017-11-16", Estimated_Diameter_Max_Kms = 0.0820427065, isAsteroidDangerous = "false", miss_Distance = 0.0743087793 },
            new NearEarthObjects() { Id = 24, Asteroid_Name = "(2005 WS3)", closest_Approach_Earth_Date = "2017-11-16", Estimated_Diameter_Max_Kms = 0.3420109247, isAsteroidDangerous = "false", miss_Distance = 0.3085758338 },
            new NearEarthObjects() { Id = 25, Asteroid_Name = "(2013 TK69)", closest_Approach_Earth_Date = "2017-11-16", Estimated_Diameter_Max_Kms = 0.1185877909, isAsteroidDangerous = "false", miss_Distance = 0.0828079722 },
            new NearEarthObjects() { Id = 26, Asteroid_Name = "(2015 NW9)", closest_Approach_Earth_Date = "2017-11-16", Estimated_Diameter_Max_Kms = 0.4721064988, isAsteroidDangerous = "false", miss_Distance = 0.3293648438 },
            new NearEarthObjects() { Id = 27, Asteroid_Name = "(2017 UY51)", closest_Approach_Earth_Date = "2017-11-16", Estimated_Diameter_Max_Kms = 0.1713325895, isAsteroidDangerous = "false", miss_Distance = 0.2507606472 },
            new NearEarthObjects() { Id = 28, Asteroid_Name = "(2017 VD2)", closest_Approach_Earth_Date = "2017-11-16", Estimated_Diameter_Max_Kms = 0.3415387454, isAsteroidDangerous = "false", miss_Distance = 0.099768723 },
            new NearEarthObjects() { Id = 29, Asteroid_Name = "(2015 YJ1)", closest_Approach_Earth_Date = "2017-11-17", Estimated_Diameter_Max_Kms = 0.0179489885, isAsteroidDangerous = "false", miss_Distance = 0.4055639998 },
            new NearEarthObjects() { Id = 30, Asteroid_Name = "136818 Selqet (1997 MW1)", closest_Approach_Earth_Date = "2017-11-17", Estimated_Diameter_Max_Kms = 0.9863702813, isAsteroidDangerous = "false", miss_Distance = 0.3248814966 },
            new NearEarthObjects() { Id = 31, Asteroid_Name = "444584 (2006 UK)", closest_Approach_Earth_Date = "2017-11-17", Estimated_Diameter_Max_Kms = 0.5420507863, isAsteroidDangerous = "true", miss_Distance = 0.0222605301 },
            new NearEarthObjects() { Id = 32, Asteroid_Name = "(2016 WG7)", closest_Approach_Earth_Date = "2017-11-17", Estimated_Diameter_Max_Kms = 0.0375007522, isAsteroidDangerous = "false", miss_Distance = 0.4177425751 },
            new NearEarthObjects() { Id = 33, Asteroid_Name = "(2011 EB7)", closest_Approach_Earth_Date = "2017-11-17", Estimated_Diameter_Max_Kms = 0.3420109247, isAsteroidDangerous = "false", miss_Distance = 0.1580090324 },
            new NearEarthObjects() { Id = 34, Asteroid_Name = "(2017 SO17)", closest_Approach_Earth_Date = "2017-11-17", Estimated_Diameter_Max_Kms = 0.9950387154, isAsteroidDangerous = "false", miss_Distance = 0.1548159698 },
            new NearEarthObjects() { Id = 35, Asteroid_Name = "(2017 SR12)", closest_Approach_Earth_Date = "2017-11-18", Estimated_Diameter_Max_Kms = 0.358129403, isAsteroidDangerous = "false", miss_Distance = 0.3690857091 },
            new NearEarthObjects() { Id = 36, Asteroid_Name = "162472 (2000 LL)", closest_Approach_Earth_Date = "2017-11-18", Estimated_Diameter_Max_Kms = 0.8995803882, isAsteroidDangerous = "false", miss_Distance = 0.317698747 },
            new NearEarthObjects() { Id = 37, Asteroid_Name = "323300 (2003 UD22)", closest_Approach_Earth_Date = "2017-11-18", Estimated_Diameter_Max_Kms = 0.7145621017, isAsteroidDangerous = "false", miss_Distance = 0.4514479132 },
            new NearEarthObjects() { Id = 38, Asteroid_Name = "(2014 HO2)", closest_Approach_Earth_Date = "2017-11-18", Estimated_Diameter_Max_Kms = 0.0375007522, isAsteroidDangerous = "false", miss_Distance = 0.1076624005 },
            new NearEarthObjects() { Id = 39, Asteroid_Name = "(2014 UZ175)", closest_Approach_Earth_Date = "2017-11-18", Estimated_Diameter_Max_Kms = 0.0156329154, isAsteroidDangerous = "false", miss_Distance = 0.3670027003 },
            new NearEarthObjects() { Id = 40, Asteroid_Name = "(2017 NH)", closest_Approach_Earth_Date = "2017-11-18", Estimated_Diameter_Max_Kms = 0.2910985075, isAsteroidDangerous = "true", miss_Distance = 0.3452340169 },
            new NearEarthObjects() { Id = 41, Asteroid_Name = "(2017 CW1)", closest_Approach_Earth_Date = "2017-11-18", Estimated_Diameter_Max_Kms = 0.3420109247, isAsteroidDangerous = "false", miss_Distance = 0.4465034875 },
            new NearEarthObjects() { Id = 42, Asteroid_Name = "(2017 VN2)", closest_Approach_Earth_Date = "2017-11-18", Estimated_Diameter_Max_Kms = 0.0196716133, isAsteroidDangerous = "false", miss_Distance = 0.0158270662 },
            new NearEarthObjects() { Id = 43, Asteroid_Name = "(2015 VF106)", closest_Approach_Earth_Date = "2017-11-19", Estimated_Diameter_Max_Kms = 0.0179489885, isAsteroidDangerous = "false", miss_Distance = 0.1335527079 },
            new NearEarthObjects() { Id = 44, Asteroid_Name = "437841 (1998 HD14)", closest_Approach_Earth_Date = "2017-11-19", Estimated_Diameter_Max_Kms = 0.358129403, isAsteroidDangerous = "true", miss_Distance = 0.3216415054 },
            new NearEarthObjects() { Id = 45, Asteroid_Name = "(2004 VA1)", closest_Approach_Earth_Date = "2017-11-19", Estimated_Diameter_Max_Kms = 0.4721064988, isAsteroidDangerous = "false", miss_Distance = 0.4747657973 },
            new NearEarthObjects() { Id = 46, Asteroid_Name = "(2014 GY44)", closest_Approach_Earth_Date = "2017-11-19", Estimated_Diameter_Max_Kms = 0.0494356193, isAsteroidDangerous = "false", miss_Distance = 0.2512871383 },
            new NearEarthObjects() { Id = 47, Asteroid_Name = "(2015 ET)", closest_Approach_Earth_Date = "2017-11-19", Estimated_Diameter_Max_Kms = 0.0271668934, isAsteroidDangerous = "false", miss_Distance = 0.1250499497 },
            new NearEarthObjects() { Id = 48, Asteroid_Name = "(2015 VP66)", closest_Approach_Earth_Date = "2017-11-19", Estimated_Diameter_Max_Kms = 0.2060819612, isAsteroidDangerous = "false", miss_Distance = 0.3992488345 },
            new NearEarthObjects() { Id = 49, Asteroid_Name = "(2016 RU33)", closest_Approach_Earth_Date = "2017-11-19", Estimated_Diameter_Max_Kms = 0.0187948982, isAsteroidDangerous = "false", miss_Distance = 0.1877356857 },
            new NearEarthObjects() { Id = 50, Asteroid_Name = "481025 (2004 VA1)", closest_Approach_Earth_Date = "2017-11-19", Estimated_Diameter_Max_Kms = 0.4508582062, isAsteroidDangerous = "false", miss_Distance = 0.4747666017 },
            new NearEarthObjects() { Id = 51, Asteroid_Name = "(2016 HJ19)", closest_Approach_Earth_Date = "2017-11-19", Estimated_Diameter_Max_Kms = 0.4305662442, isAsteroidDangerous = "false", miss_Distance = 0.3470845605 },
            new NearEarthObjects() { Id = 52, Asteroid_Name = "(2017 FR63)", closest_Approach_Earth_Date = "2017-11-19", Estimated_Diameter_Max_Kms = 0.0355009503, isAsteroidDangerous = "false", miss_Distance = 0.197502899 },
            new NearEarthObjects() { Id = 53, Asteroid_Name = "(2017 SJ20)", closest_Approach_Earth_Date = "2017-11-19", Estimated_Diameter_Max_Kms = 0.1969880943, isAsteroidDangerous = "false", miss_Distance = 0.1446019527 }
            );
        }
    }
}
