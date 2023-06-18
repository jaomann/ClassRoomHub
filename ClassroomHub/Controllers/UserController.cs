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
        public IActionResult Index()
        {
            var users = _userservices.GetAll();
            return View(users);
        }
    }
}
