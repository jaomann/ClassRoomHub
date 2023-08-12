using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using ClassroomHub.Core.Entities;

namespace ClassRoomHub.Web.ViewModels
{
    public class ActivityViewModel
    {
        public Guid Id { get; set; }
        [Required]
        [DisplayName("Titulo")]
        public string Title { get; set; }
        [Required]
        [DisplayName("Descrição")]
        public string Description { get; set; }
        [Required]
        [DisplayName("Data de entrega")]
        public DateTime DueDate { get; set; }
        public int Score { get; set; }
        [DisplayName("Solução")]
        public string Solution { get; set; }
        public Module Module { get; set; }
        public Guid ModuleId { get; set; }

    }
}
