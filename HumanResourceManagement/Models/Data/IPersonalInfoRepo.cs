using HumanResourceManagement.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourceManagement.Models.Data
{
    public interface IPersonalInfoRepo
    {
        void Create_Personal(PersonalInformation personalinfo);
        void update_personal(PersonalInformation updatedInfo);
        void deleteEmployee(PersonalInformation person);
        List<PersonalInformation> AllInfo();
        PersonalInformation getInfoById(int id);

        void Update(PersonalInformation person);
    }
}
