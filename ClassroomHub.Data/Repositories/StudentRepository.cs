using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomHub.Data.Repositories
{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        public StudentRepository(Context context) : base(context)
        {
        }

        public IEnumerable<Student> GetFullStudents()
        {
            return this.Get().Include(x => x.User);
        }

        public Student GetStudentByName(string name)
        {
            return Get().Where(x => x.Name.Contains(name)).FirstOrDefault();
        }
    }
}
