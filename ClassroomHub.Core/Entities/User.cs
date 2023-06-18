using System;

namespace ClassroomHub.Core.Entities
{
    public class User : EntityBase
    {
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public string Password { get; set; }
        public Student Student { get; set; }
        public Guid StudentID { get; set; }
        public Teacher Teacher { get; set; }
        public Guid TeacherID { get; set; }
    }
}
