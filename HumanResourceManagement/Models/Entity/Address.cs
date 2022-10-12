using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HumanResourceManagement.Models.Entity
{
    public class Address
    {
        public string stree1 { get; set; }
        public string stree2 { get; set; }
        public string locality { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string mobileNo { get; set; }
        public string alternativeNo { get; set; }
        [EmailAddress]
        [Key]
        public string emailId { get; set; }

        [EmailAddress]
        public string alternativeEmail { get; set; }
    }
}