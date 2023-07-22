using System;
using System.ComponentModel.DataAnnotations;

namespace ClassRoomHub.Web.ViewModels
{
    public class TeacherViewModel
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Nome")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Sobrenome")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Especialização")]
        public string Specialization { get; set; }
        public string Email { get; set; }

        public Guid UserId { get; set; }
    }
}