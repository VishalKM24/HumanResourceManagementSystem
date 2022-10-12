using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HumanResourceManagement.Models.Entity
{
    public class Civil
    {

        [MaxLength(25)]
        public string Nationality { get; set; }
        [Key]

        [MaxLength(10)]
        public string PAN { get; set; }
    }
}