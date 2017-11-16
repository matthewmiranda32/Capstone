namespace NearEarthObjectTracker.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Meteor_Showers
    {
        public int Id { get; set; }

        public string showerName { get; set; }

        public string dateOfVisibility { get; set; }

        public string moonPhase { get; set; }
    }
}
