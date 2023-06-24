using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Core.Entities;

namespace ClassroomHub.Services
{
    public class CourseService : BaseService<Course>, ICourseServices
    {
        public CourseService(ICourseRepository courseRepository) : base(courseRepository) { }
    }

}
