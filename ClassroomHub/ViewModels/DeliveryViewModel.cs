using System;
using ClassroomHub.Core.Entities;

namespace ClassroomHub.Web.ViewModels
{
    public class DeliveryViewModel
    {
        public Guid Id { get; set; }
        public DateTime DueDate { get; set; }
        public Guid ActivityId { get; set; }
        public float Score { get; set; }
        public string Solution { get; set; }
        public string ModuleName { get; set; }
        public Guid StudentId { get; set; }
    }
}
