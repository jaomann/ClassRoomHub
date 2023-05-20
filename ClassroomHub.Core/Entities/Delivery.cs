using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomHub.Core.Entities
{
    internal class Delivery
    {
        public DateTime SubmissionDate { get; set; }
        public Guid ActivityGuid { get; set; }
        public Activity Activity { get; set; }
        public Guid StudentGuid { get; set; }
        public Student student { get; set; }
    }
}
