using ClassRoomHub.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Cryptography.Xml;

namespace ClassRoomHub.Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly List<StudentViewModel> studentsVW = new List<StudentViewModel>()
        {
            new StudentViewModel
            {
            Name = "Thiago",
            Surname = "Ramos",
            Email = "thiaguinplenodaamb@gmail.com"
            },
            new StudentViewModel
            {
            Name = "Danilo",
            Surname = "Ramos",
            Email = "thiaguinplenodaamb@gmail.com"
            },
            new StudentViewModel
            {
            Name = "Veronica",
            Surname = "Devstar",
            Email = "veronica@gmail.com"
            }

        };
        public IActionResult Index()
        {
            return View(studentsVW);
        }
    }
}
