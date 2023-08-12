using System;
using System.Diagnostics;

namespace ClassroomHub.Web.ViewModels
{
    public class DeliveryViewModel
    {
        
        public DateTime SubmissionDate { get; set; }
        public Guid ActivityId { get; set; }
        public Activity Activity { get; set; }
        public float Score { get; set; }
    }
}
