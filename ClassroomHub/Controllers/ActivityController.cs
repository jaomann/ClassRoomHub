using ClassRoomHub.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassRoomHub.Web.Controllers
{
    public class ActivityController : Controller
    {
        List<ActivitytoStudentViewModel> students = new List<ActivitytoStudentViewModel>()
        {
            new ActivitytoStudentViewModel()
            {
               Title = "Injeção de Dependências",
               Description = "Crie um serviço de cadastro de produto utilizando a injeção de dependência",
               ScorePoints = 20,
               TeacherName = "Thiago",
               ModuleName = "C#",
               DueDate = new System.DateTime(2023, 05, 19)
            },
            new ActivitytoStudentViewModel()
            {
                Title = "Criação de classes",
                Description = "Desenvolva 2 classes relacionadas a modelagem de um banco de dados",
                ScorePoints = 05,
                TeacherName = "Thiago",
                ModuleName = "C#",
                DueDate = new System.DateTime(2023,05,17)
            }
        };
        public IActionResult Index()
        {
            ViewData["Teacher"] = students.FirstOrDefault()?.TeacherName ?? "Sem informações de professor.";
            ViewData["ModuleName"] = students.FirstOrDefault()?.ModuleName ?? "Sem informações de modulo.";

            return View(students);
        }
    }
}
