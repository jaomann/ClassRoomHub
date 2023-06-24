using AutoMapper;
using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Core.Entities;
using ClassroomHub.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ClassroomHub.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IUserServices _userservices;
        public LoginController(IUserServices userservices, IMapper mapper)
        {
            _mapper = mapper;
            _userservices = userservices;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login(UserViewModel userV)
        {
            var user = _mapper.Map<User>(userV);
            if (_userservices.Verify(user))
            {
                return RedirectToAction("Index", "Activity");
            }
            return Unauthorized();
        }
    }
}
