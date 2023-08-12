using AutoMapper;
using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Core.Entities;
using ClassroomHub.Web.ViewModels;
using ClassRoomHub.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace ClassroomHub.Web.Controllers
{
    public class ModuleController : Controller
    {
        private readonly IModuleServices _moduleServices;
        private readonly ITeacherServices _teacherServices;
        private readonly IMapper _mapper;
        public ModuleController(IModuleServices moduleServices, IMapper mapper, ITeacherServices teacherServices)
        {
            _teacherServices = teacherServices;
            _moduleServices = moduleServices;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            ViewBag.Teachers = new SelectList(_mapper.Map<IEnumerable<TeacherViewModel>>(_teacherServices.GetFullTeacher()), "Id", "Name");
            var modules = _mapper.Map<IEnumerable<ModuleViewModel>>(_moduleServices.GetAll());
            return View(modules);
        }
        public IActionResult Create(ModuleViewModel entity)
        {
            _moduleServices.Create(_mapper.Map<Module>(entity));
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(Guid id)
        {
            _moduleServices.Delete(id);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update(Guid id)
        {
            ViewBag.Teachers = new SelectList(_mapper.Map<IEnumerable<TeacherViewModel>>(_teacherServices.GetFullTeacher()), "Id", "Name");
            var modules = _mapper.Map<ModuleViewModel>(_moduleServices.GetById(id));
            return View(modules);
        }
        [HttpPost]
        public IActionResult Update(ModuleViewModel entity)
        {
            _moduleServices.Update(_mapper.Map<Module>(entity));
            return RedirectToAction(nameof(Index));
        }
    }
}
