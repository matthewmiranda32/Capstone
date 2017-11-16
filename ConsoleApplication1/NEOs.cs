using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class NEOs
    {
        [Key]
        public string id { get; set; }
        [Display(Name = "Name")]
        public string objectName { get; set; }

        [Display(Name = "Size")]
        public string estimatedDiameter { get; set; }

        [Display(Name = "Closest Approach Distance")]
        public string closestApproachDistance { get; set; }

        [Display(Name = "Closest Approach Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public string closestApproachDate { get; set; }

        [Display(Name = "Object Type")]
        public string objectType { get; set; }

    }
}
