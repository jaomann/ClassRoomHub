using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomHub.Core.Entities
{
    public class Activity : EntityBase
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public int Score { get; set; }
        public string Solution { get; set; }
        public Guid ModuleId { get; set; }
        public Guid DeliveryId { get; set; }
        public IEnumerable<Delivery> deliveries { get; set; }

    }
}
