using AutoMapper;
using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Core.Entities;
using ClassroomHub.Web.ViewModels;
using ClassRoomHub.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace ClassRoomHub.Web.Controllers
{
    public class ActivityController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IStudentServices _studentServices;
        private readonly ITeacherServices _teacherServices;
        private readonly IActivityServices _activityServices;
        private readonly IModuleServices _moduleServices;
        private readonly IDeliveryServices _deliveryServices;
        public ActivityController(IDeliveryServices deliveryServices,IModuleServices moduleServices, IMapper mapper, IStudentServices studentServices, ITeacherServices teacherServices, IActivityServices activityServices)
        {
            _activityServices = activityServices;
            _studentServices = studentServices;
            _mapper = mapper;
            _teacherServices = teacherServices;
            _moduleServices = moduleServices;
            _deliveryServices = deliveryServices;
        }
        public IActionResult Index()
        {
            var teachers = _mapper.Map<IEnumerable<TeacherViewModel>>(_teacherServices.GetFullTeacher());
            var students = _mapper.Map<IEnumerable<StudentViewModel>>(_studentServices.GetFullStudents());
            ViewBag.Teachers = new SelectList(teachers, "Id", "Name");
            ViewBag.Students = new SelectList(students, "Id", "Name");
            return View(new ActivityCompairVM());
        }
        public IActionResult studentArea(ActivityCompairVM entity)
        {
            ViewData["Student"] = _mapper.Map<Student>(_studentServices.GetStudentByName(entity.StudentName));
            var activities = _mapper.Map<IEnumerable<ActivityViewModel>>(_activityServices.GetAll());
            return View(activities);
        }
        public IActionResult teacherArea(ActivityCompairVM entity)
        {
            var modules = _moduleServices.GetAll();
            ViewBag.Modules = new SelectList(modules, "Id", "Name");
            ViewData["Teacher"] = _mapper.Map<TeacherViewModel>(_teacherServices.GetTeacherByName(entity.TeacherName));
            var activities = _mapper.Map<IEnumerable<ActivityViewModel>>(_activityServices.GetAll()); ;
            return View(activities);
        }
        public IActionResult Create(ActivityViewModel entity)
        {
            
            var atividade = _mapper.Map<Activity>(entity);
            _activityServices.Create(atividade);
            return RedirectToAction(nameof(teacherArea));
        }
        public IActionResult Details(Guid id)
        {
            var students = _mapper.Map<IEnumerable<StudentViewModel>>(_studentServices.GetFullStudents());
            ViewBag.Students = new SelectList(students, "Id", "Name");
            var atividade = _mapper.Map<ActivityViewModel>(_activityServices.GetById(id));
            TempData["Atividade"] = atividade;
            
           return View(new DeliveryViewModel());
        }
        [HttpPost]
        public IActionResult Details(DeliveryViewModel solutioned)
        {
            solutioned.DueDate = DateTime.Now.Date;
            _deliveryServices.Create(_mapper.Map<Delivery>(solutioned));
           return RedirectToAction(nameof(studentArea));
        }
        public IActionResult Correct()
        {
            var modules = _mapper.Map<IEnumerable<ModuleViewModel>>(_moduleServices.GetAll());
            ViewBag.Modules = new SelectList(modules, "Id", "Name");
            var entregas = _mapper.Map<IEnumerable<DeliveryViewModel>>(_deliveryServices.GetAllDone());
            return View(entregas);
        }
        [HttpPost]
        public IActionResult Correct(DeliveryViewModel entity)
        {
            _deliveryServices.Update(_mapper.Map<Delivery>(entity));
           return RedirectToAction(nameof(Index));
        }
    }
}
