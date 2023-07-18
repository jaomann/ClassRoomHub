using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace ClassRoomHub.Web.ViewModels
{
    public class StudentViewModel
    {
        public Guid Id { get; set; }
        [DisplayName("Nome")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Name { get; set; }
        [DisplayName("Sobrenome")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Surname { get; set; }

        [Display(Name = "Nascimento")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public DateTime Birthday { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public Guid ClassID { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public Guid UserID { get; set; }
    }
}
