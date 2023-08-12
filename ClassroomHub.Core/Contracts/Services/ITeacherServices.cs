using ClassroomHub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomHub.Core.Contracts.Services
{
     public interface ITeacherServices : IBaseServices<Teacher>
    {
        IEnumerable<Teacher> GetFullTeacher();
        Teacher GetTeacherByName(string name);
    }
}
