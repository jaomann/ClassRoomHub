using AutoMapper;
using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Core.Entities;
using ClassroomHub.Web.ViewModels;
using ClassRoomHub.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace ClassroomHub.Web.Controllers
{
    public class ClassController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IClassServices _classServices;
        public ClassController(IMapper mapper, IClassServices classServices)
        {
            _mapper = mapper;
            _classServices = classServices;
        }
        public IActionResult Index()
        {
            var classes = _mapper.Map<IEnumerable<ClassViewModel>>(_classServices.GetAll());
            return View(classes);
        }
        [HttpPost]
        public IActionResult Create(ClassViewModel model)
        {
            _classServices.Create(_mapper.Map<Class>(model));
            return RedirectToAction(nameof(Index));
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
