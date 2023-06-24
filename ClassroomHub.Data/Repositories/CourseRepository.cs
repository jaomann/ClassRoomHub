using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomHub.Data.Repositories
{
    public class CourseRepository : BaseRepository<Course>, ICourseRepository
    {
        private readonly Context _context;
        public CourseRepository(Context context) : base(context)
        {
        }

        public Course GetByCourseName(string courseName)
        {
            throw new NotImplementedException();
        }
    }
}
