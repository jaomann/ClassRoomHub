using AutoMapper;
using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Core.Entities;
using ClassroomHub.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ClassroomHub.Web.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseServices _courseServices;
        private readonly IMapper _mapper;
        public CourseController(ICourseServices courseServices, IMapper mapper)
        {
            _courseServices = courseServices;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var courses = _mapper.Map<IEnumerable<CourseViewModel>>(_courseServices.GetAll());
            return View(courses);
        }
        [HttpPost]
        public IActionResult Create(CourseViewModel model)
        {
            _courseServices.Create(_mapper.Map<Course>(model));
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            var course = _courseServices.GetById(id);
            var courseViewModel = _mapper.Map<CourseViewModel>(course);
            return View(courseViewModel);
        }
        [HttpPost]
        public IActionResult Edit(CourseViewModel newCourse)
        {
            var courseEntity = _mapper.Map<Course>(newCourse);
            _courseServices.Update(courseEntity);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(Guid id)
        {
            _courseServices.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
