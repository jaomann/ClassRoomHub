using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomHub.Core.Entities
{
    internal class Score
    {
        public int Value { get; set; }
        public Guid DeliveryGuid { get; set; }
        public Delivery Delivery { get; set; }
    }
}
