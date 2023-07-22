using AutoMapper;
using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Core.Entities;
using ClassroomHub.Services;
using ClassroomHub.Web.ViewModels;
using ClassRoomHub.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace ClassRoomHub.Web.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeacherServices _teacherServices;
        private readonly IUserServices _userServices;
        private readonly IClassServices _classServices;
        private readonly IMapper _mapper;

        public TeacherController(ITeacherServices teacherServices, IUserServices userServices, IMapper mapper, IClassServices classServices)
        {
            _teacherServices = teacherServices;
            _userServices = userServices;
            _mapper = mapper;
            _classServices = classServices;
        }

        public IActionResult Index()
        {

            var users = _mapper.Map<IEnumerable<UserViewModel>>(_userServices.GetAll());
            ViewBag.Users = new SelectList(users, "Id", "Email");
            var teachers = _mapper.Map<IEnumerable<TeacherViewModel>>(_teacherServices.GetFullTeacher());
            return View(teachers);
        }
        public IActionResult Create(TeacherViewModel entity)
        {
            var teacher = _mapper.Map<Teacher>(entity);
            _teacherServices.Create(teacher);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(Guid id)
        {
            _teacherServices.Delete(id);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update(Guid id)
        {
            var usuarios = _mapper.Map<IEnumerable<UserViewModel>>(_userServices.GetAll());
            ViewBag.Users = new SelectList(usuarios, "Id", "Email");
            var teachers = _mapper.Map<TeacherViewModel>(_teacherServices.GetById(id));
            return View(teachers);
        }
        [HttpPost]
        public IActionResult Update(TeacherViewModel entity)
        {
            _teacherServices.Update(_mapper.Map<Teacher>(entity));
            return RedirectToAction(nameof(Index));
        }

    }
}

