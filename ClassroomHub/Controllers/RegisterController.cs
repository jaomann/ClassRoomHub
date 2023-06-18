using AutoMapper;
using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Core.Entities;
using ClassroomHub.Web.ViewModels;
using ClassRoomHub.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ClassroomHub.Web.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IUserServices _userservices;
        public RegisterController(IUserRepository db, IMapper mapper, IUserServices userServices)
        {
            _mapper = mapper;
            _userservices = userServices;
        }
        
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(UserViewModel userV)
        {
            var user = _mapper.Map<User>(userV);
            _userservices.Create(user);
            return RedirectToAction("Index", "Login");
        }
    }
}
