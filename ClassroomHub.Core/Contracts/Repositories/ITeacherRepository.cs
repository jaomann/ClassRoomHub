using ClassroomHub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomHub.Core.Contracts.Repositories
{
    public interface ITeacherRepository : IBaseRepository<Teacher>
    {
        IEnumerable<Teacher> GetFullTeacher();
    }
}
