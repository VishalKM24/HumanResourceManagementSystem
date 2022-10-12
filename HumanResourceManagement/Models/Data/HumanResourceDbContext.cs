using HumanResourceManagement.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HumanResourceManagement.Models.Data
{
    public class HumanResourceDbContext : DbContext
    {
        public HumanResourceDbContext() : base("name = DefaultConnection")
        {

        }

        public DbSet<PersonalInformation> PersonalInformations { get; set; }
    }
}