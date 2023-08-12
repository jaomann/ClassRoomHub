using Microsoft.AspNetCore.Cors;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ClassroomHub.Web.ViewModels
{
    public class ModuleViewModel
    {
        public Guid Id { get; set; }

        [DisplayName("Nome de modulo")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Name { get; set; }

        [DisplayName("Inicio do modulo")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public DateTime Start { get; set; }

        [DisplayName("Fim do modulo")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public DateTime End { get; set; }
        [DisplayName("Horas")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public int Hours { get; set; } 
        public Guid TeacherId { get; set; }
        public string TeacherName { get; set;}

    }
}
