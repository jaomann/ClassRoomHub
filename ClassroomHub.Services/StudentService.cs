using System;
using System.Collections.Generic;
using System.Text;
using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Core.Entities;

namespace ClassroomHub.Services
{
    public class StudentService : BaseService<Student>, IStudentServices
    {
        public StudentService(IStudentRepository baseRepository) : base(baseRepository)
        {
            
        }
    }
}
