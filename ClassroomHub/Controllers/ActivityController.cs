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
            var modules = _mapper.Map<IEnumerable<ModuleViewModel>>(_moduleServices.GetAll());
            ViewBag.Modules = new SelectList(modules, "Id", "Name");
            var atividade = _mapper.Map<ActivityViewModel>(_activityServices.GetById(id));
           return View(atividade);
        }
        [HttpPost]
        public IActionResult Details(ActivityViewModel solutioned)
        {
            var atividade = _mapper.Map<Activity>(solutioned);
           _activityServices.Update(atividade);
           return RedirectToAction(nameof(Index));
        }
        public IActionResult Correct()
        {
            var modules = _mapper.Map<IEnumerable<ModuleViewModel>>(_moduleServices.GetAll());
            ViewBag.Modules = new SelectList(modules, "Id", "Name");
            var atividades = _mapper.Map<IEnumerable<ActivityViewModel>>(_activityServices.GetAllDone());
            return View(atividades);
        }
        [HttpPost]
        public IActionResult Correct(Tuple<ActivityViewModel, int> entity)
        {
            
            var atividade = entity.Item1;
            var entrega = new DeliveryViewModel();
            entrega.Score = entity.Item2;
            entrega.ActivityId = atividade.Id;
            entrega.SubmissionDate = atividade.DueDate;
            _deliveryServices.Create(_mapper.Map<Delivery>(entrega));
           return RedirectToAction(nameof(Index));
        }
    }
}
