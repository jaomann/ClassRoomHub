using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomHub.Core.Entities
{
    public class Delivery : EntityBase
    {
        public DateTime SubmissionDate { get; set; }
        public Guid ActivityId { get; set; }
        public Activity Activity { get; set; }
        public Guid GradeId { get; set; }
        public Grade Grade { get; set; }
    }
}
