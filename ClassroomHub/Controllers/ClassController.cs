using AutoMapper;
using ClassroomHub.Core.ApplicationExeception;
using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Core.Entities;
using ClassroomHub.Web.ViewModels;
using ClassRoomHub.ViewModels;
using ClassRoomHub.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassroomHub.Web.Controllers
{
    public class ClassController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IClassServices _classServices;
        private readonly ICourseServices _courseServices;
        public ClassController(IMapper mapper, IClassServices classServices, ICourseServices courseServices)
        {
            _mapper = mapper;
            _classServices = classServices;
            _courseServices = courseServices;

        }
        public IActionResult Index()
        {
            var courses = _mapper.Map<List<CourseViewModel>>(_courseServices.GetAll());
            ViewBag.Courses = new SelectList(courses, "Id", "Name");
            return View(new List<ClassViewModel>());
        }

        [HttpPost]
        public IActionResult Index(Guid id)
        {
            var courses = _mapper.Map<List<CourseViewModel>>(_courseServices.GetAll());
            ViewBag.Courses = new SelectList(courses, "Id", "Name");
            var classs = _mapper.Map<IEnumerable<ClassViewModel>>(_classServices.GetAll().Where(x => x.CourseId.Equals(id)));
            return View(classs);
        }
        [HttpPost]
        public IActionResult Create(ClassViewModel model)
        {
            try
            {

            _classServices.Create(_mapper.Map<Class>(model));
            return RedirectToAction(nameof(Index));
            }
            catch (InvalidDateException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
        }
        public IActionResult Error(string message)
        {
            var errorViewModel = new ErrorViewModel() { Message = message };
            return View(errorViewModel);
        }
        public IActionResult Delete(Guid id)
        {
            _classServices.Delete(id);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            var classs = _classServices.GetById(id);
            var classViewModel = _mapper.Map<ClassViewModel>(classs);
   
            return View(classViewModel);
        }
        [HttpPost]
        public IActionResult Edit(ClassViewModel newClass)
        {
            var classEntity = _mapper.Map<Class>(newClass);
            _classServices.Update(classEntity);

            return RedirectToAction(nameof(Index));
        }
    }
}
