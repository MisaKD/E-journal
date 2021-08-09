using E_journal.Models;
using E_journal.Models.ViewModels;
using E_journal.Services;
using Microsoft.AspNetCore.Mvc;

namespace E_journal.Controllers
{
    public class TeacherController : Controller

    {
        private ITeacherService _teacherService;
        private string _editForm = "~/Views/Teacher/Edit.cshtml";
        private string _formErrorView = "~/Views/Home/FormError.cshtml";

        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }
        public IActionResult TeacherList()
        {
            var teachers = new TeacherViewModel()
            {
                Teachers = _teacherService.Select()
            };

            return View(teachers);
        }
        [HttpGet]
        public IActionResult EditTeacher(int Id)
        {
            var teacher = _teacherService.SelectById(Id);
            var model = new TeacherViewModel()
            {
                Id = teacher.Id,
                Name = teacher.Name,
                Discipline = teacher.Discipline
            };
            return View(_editForm, model);
        }

        [HttpPost]
        public IActionResult EditTeacher(TeacherViewModel model)
        {
            if (ModelState.IsValid)
            {
                _teacherService.EditTeacher(model);
                
            }
            //return View(_formErrorView);
            return RedirectToAction("TeacherList");
        }

        [HttpGet]
        public IActionResult CreateTeacher()
        {
            var model = new TeacherViewModel();
            return View(_editForm, model);
        }

        [HttpPost]
        public IActionResult CreateTeacher(TeacherViewModel model)
        {
            if (ModelState.IsValid)
            {
                _teacherService.CreateTeacher(model);
                
            }
            //return View(_formErrorView);
            return RedirectToAction("TeacherList");
        }
    }
}
