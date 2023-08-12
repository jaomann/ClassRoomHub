using ClassroomHub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomHub.Core.Contracts.Repositories
{
    public interface IStudentRepository : IBaseRepository<Student>
    {
        IEnumerable<Student> GetFullStudents();
        Student GetStudentByName(string name);
    }
}
