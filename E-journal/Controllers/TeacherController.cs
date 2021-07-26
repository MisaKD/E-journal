using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_journal.Models;
using E_journal.Models.ViewModels;
using E_journal.Services;
using Microsoft.AspNetCore.Mvc;

namespace E_journal.Controllers
{
    public class TeacherController:Controller

    {
        private ITeacherService _teacherService;
        private string _editForm = "~/Views/Teacher/Edit.cshtml";

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
            return PartialView(_editForm, model);
        }

        [HttpPost]
        public IActionResult EditTeacher(Teacher model)
        {
            _teacherService.EditTeacher(model);
            return RedirectToAction("TeacherList");
        }

        [HttpGet]
        public IActionResult CreateTeacher()
        {
            var model = new TeacherViewModel();
            return PartialView(_editForm,model);
        }

        [HttpPost]
        public IActionResult CreateTeacher(Teacher model)
        {
            _teacherService.CreateTeacher(model);
            return RedirectToAction("TeacherList");
        }
    }
}
