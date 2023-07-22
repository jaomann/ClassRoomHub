using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Core.Entities;
using System.Collections.Generic;

namespace ClassroomHub.Services
{
    public class TeacherService : BaseService<Teacher>, ITeacherServices
    {
        private readonly ITeacherRepository _teacherRepository;
        public TeacherService(ITeacherRepository teacherRepository) : base(teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        public IEnumerable<Teacher> GetFullTeacher()
        {
            return _teacherRepository.GetFullTeacher();
        }
    }
}
