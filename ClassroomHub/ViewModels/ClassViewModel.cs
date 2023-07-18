using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ClassRoomHub.Web.ViewModels
{
    public class ClassViewModel
    {
        public Guid Id { get; set; }
        [DisplayName("Nome da turma")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        [MaxLength(20)]
        public string Name { get; set; }
        [DisplayName("Inicio")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public DateTime Start { get; set; }
        [DisplayName("Fim")]
        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "Sem data de término", DataFormatString = "{0:D}")]
        public DateTime End { get; set; }
        [Display(Name="Curso")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public Guid CourseId { get; set; }
    }
}
