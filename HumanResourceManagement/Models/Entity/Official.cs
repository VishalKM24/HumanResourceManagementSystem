using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HumanResourceManagement.Models.Entity
{
    public class Official
    {
        [Key]

        public string MID { get; set; }

        public string Location { get; set; }

        [MaxLength(50)]
        public string Department { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }
    }
}