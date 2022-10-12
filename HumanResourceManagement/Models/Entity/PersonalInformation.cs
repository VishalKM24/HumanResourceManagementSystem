using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HumanResourceManagement.Models.Entity
{
    public class PersonalInformation
    {
        [Key]
        public int PersonalID { get; set; }
        [Required]
        [MaxLength(15)]
        public string firstName { get; set; }
        public string middleName { get; set; }
        
        [Required]
        [MaxLength(15)]
        public string lastName { get; set; }
        
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        public int age { get; set; }
        
        [Required]
        public string gender { get; set; }

        virtual public Address Address { get; set; }
        virtual public Education Education { get; set; }
        virtual public Civil Civil { get; set; }
        virtual public Official official { get; set; }
        
    }
}