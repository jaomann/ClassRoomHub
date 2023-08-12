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
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository baseRepository) : base(baseRepository)
        {
            _studentRepository = baseRepository;
        }

        public IEnumerable<Student> GetFullStudents()
        {
            return _studentRepository.GetFullStudents();
        }

        public Student GetStudentByName(string name)
        {
            return _studentRepository.GetStudentByName(name);
        }
    }
}
