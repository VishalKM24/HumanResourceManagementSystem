using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HumanResourceManagement.Models.Entity
{
    public class Education
    {
        public int EducationID { get; set; }

        public string Bachelor { get; set; }


        public int BMarks { get; set; }
        public string Masters { get; set; }
        public int MMarks { get; set; }
        [MaxLength(250)]
        public string Additional { get; set; }
    }
}