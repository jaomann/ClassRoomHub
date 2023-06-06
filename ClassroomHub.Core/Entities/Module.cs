using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomHub.Core.Entities
{
    public class Module : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Hours { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public Guid TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public Guid CourseId { get; set; }
        public Course Course { get; set; }  
        public Guid ClassId { get; set; }
        public Class Class { get; set; }
        public Guid ActivityId { get; set; }
        public List<Activity> Activity { get; set; }

    }
}
