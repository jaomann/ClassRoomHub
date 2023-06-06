using System;

namespace ClassroomHub.Core.Entities
{
    public class Grade : EntityBase
    {
        public int GradeValue { get; set; }
        public Guid DeliveryId { get; set; }
        public Delivery Delivery { get; set; }
    }
}
