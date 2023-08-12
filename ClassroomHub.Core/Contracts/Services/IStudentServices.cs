using ClassroomHub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomHub.Core.Contracts.Services
{
    public interface IStudentServices : IBaseServices<Student>
    {
        IEnumerable<Student> GetFullStudents();
        Student GetStudentByName(string name);
    }
}
