using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomHub.Core.Entities
{
    public class Delivery : EntityBase
    {
        public DateTime DueDate { get; set; }
        public Guid ActivityId { get; set; }
        public Activity Activity { get; set; }
        public float Score { get; set; }
        public string Solution { get; set; }
        public string ModuleName { get; set; }
        public Guid StudentId { get; set; }
        public Student Student { get; set; }
    }
}
