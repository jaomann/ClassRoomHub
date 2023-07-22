using AutoMapper;
using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Core.Entities;
using ClassroomHub.Services;
using ClassroomHub.Web.ViewModels;
using ClassRoomHub.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace ClassRoomHub.Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentServices _studentServices;
        private readonly IClassServices _classServices;
        private readonly IUserServices _userServices;
        private readonly IMapper _mapper;
        public StudentController(IStudentServices studentServices, IMapper mapper, IClassServices classServices, IUserServices userServices)
        {
            _mapper = mapper;
            _studentServices = studentServices;
            _classServices = classServices;
            _userServices = userServices;

        }
        public IActionResult Index()
        {
            var usuarios = _mapper.Map<IEnumerable<UserViewModel>>(_userServices.GetAll());
            ViewBag.Users = new SelectList(usuarios, "Id", "Email");
            var classes = _mapper.Map<IEnumerable<ClassViewModel>>(_classServices.GetAll());
            ViewBag.Turmas = new SelectList(classes, "Id", "Name");
            return View(new List<StudentViewModel>());
        }
        [HttpPost]
        public IActionResult Index(Guid id)
        {
            var usuarios = _mapper.Map<IEnumerable<UserViewModel>>(_userServices.GetAll());
            ViewBag.Users = new SelectList(usuarios, "Id", "Email");
            var classes = _mapper.Map<IEnumerable<ClassViewModel>>(_classServices.GetAll());
            ViewBag.Turmas = new SelectList(classes, "Id", "Name");
            var studentVM = _mapper.Map<IEnumerable<StudentViewModel>>(_studentServices.GetAll());
            return View(studentVM);
        }
        public IActionResult Create(StudentViewModel entity)
        {
            var student = _mapper.Map<Student>(entity);
            _studentServices.Create(student);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(Guid id)
        {
            _studentServices.Delete(id);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update(Guid id)
        {
            var usuarios = _mapper.Map<IEnumerable<UserViewModel>>(_userServices.GetAll());
            ViewBag.Users = new SelectList(usuarios, "Id", "Email");
            var classes = _mapper.Map<IEnumerable<ClassViewModel>>(_classServices.GetAll());
            ViewBag.Turmas = new SelectList(classes, "Id", "Name");
            var student = _studentServices.GetById(id);
            var entity = _mapper.Map<StudentViewModel>(student);
            return View(entity);
        }
        [HttpPost]
        public IActionResult Update(StudentViewModel student)
        {
            var entity = _mapper.Map<Student>(student);
            _studentServices.Update(entity);
            return RedirectToAction(nameof(Index));
        }
    }
}
