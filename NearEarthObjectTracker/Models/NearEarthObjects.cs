using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace NearEarthObjectTracker.Models
{
    public class NearEarthObjects
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Asteroid_Name { get; set; }

        [Display(Name = "Maximum Estimated Diameter in km")]
        public double Estimated_Diameter_Max_Kms { get; set; }
        [Display(Name = "Potentially Hazardous Object?")]
        public string isAsteroidDangerous { get; set; }
        [Display(Name = "Date of Closest Approach to Earth")]
        public string closest_Approach_Earth_Date { get; set; }
        [Display(Name = "Closest Approach Distance in AU")]
        public double miss_Distance { get; set; }
    }
}