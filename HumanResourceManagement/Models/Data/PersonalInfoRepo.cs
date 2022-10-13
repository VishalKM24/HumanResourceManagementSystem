using HumanResourceManagement.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HumanResourceManagement.Models.Data
{
    public class PersonalInfoRepo : IPersonalInfoRepo
    {
        private HumanResourceDbContext db = new HumanResourceDbContext();
        public void Create_Personal(PersonalInformation personalinfo)
        {
            db.PersonalInformations.Add(personalinfo);
            db.SaveChanges();
        }

        public void update_personal(PersonalInformation updatedInfo)
        {
            // var tempEdit = db.PersonalInformations.Find(personalinfo);
            db.Entry(updatedInfo).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void deleteEmployee(PersonalInformation person)
        {
            var dt = db.PersonalInformations.Find(person);
            if(dt != null)
                db.PersonalInformations.Remove(dt);
            db.SaveChanges();
        }

        public List<PersonalInformation> AllInfo()
        {
            return db.PersonalInformations.ToList();
        }

        public PersonalInformation getInfoById(int id)
        {
            var data = db.PersonalInformations.Find(id);

            if (data == null)
                return null;

            return data;
        }

        public void Update(PersonalInformation person)
        {
            db.Entry(person).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}