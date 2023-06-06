using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ClassroomHub.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserServices _userservices;
        public UserController(IUserServices userServices)
        {
            this._userservices = userServices;
        }

        User user = new User()
        {
            Email = "joaoemanuel1234@gmail.com",
            Password = "password",
        };
        public IActionResult Index()
        {
            var user = _userservices.GetById(System.Guid.Parse("9ba37c04-9874-47e5-134c-08db6628d50c"));
            return View(user);
        }
    }
}
