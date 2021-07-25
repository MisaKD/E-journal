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
    public class GroupController : Controller
    {
        private IGroupService _groupService;
        private IStudentService _studentService;
        private ICourseService _courseService;
        private ITeacherService _teacherService;
        
        private string _editForm = "~/Views/Group/Edit.cshtml";

        public GroupController(IGroupService groupService, IStudentService studentService, ITeacherService teacherService, ICourseService courseService)
        {
            _groupService = groupService;
            _studentService = studentService;
            _teacherService = teacherService;
            _courseService = courseService;
        }


        public IActionResult GroupView(int Id)
        {
            var group = _groupService.SelectById(Id);
            var model = new GroupViewModel
            {
                Id = group.Id,
                Name = group.Name,
                Course = group.Course,
                Curator = group.Curator,
                Specialization = group.Specialization,
                Year = group.Year,
                StudentsList = _studentService.SelectByGroupId(Id)
            };
            return View(model);
        }
        [HttpGet]
        public IActionResult EditGroup(int Id)
        {
            var group = _groupService.SelectById(Id);
            var model = new GroupViewModel
            {
                Id = group.Id,
                Name = group.Name,
                Course = group.Course,
                Curator = group.Curator,
                Specialization = group.Specialization,
                Year = group.Year,
                TeachersList = _teacherService.Select(),
                CoursesList = _courseService.Select()
            };
            return PartialView(_editForm, model);
        }

        [HttpPost]
        public IActionResult EditGroup(Group model)
        {
            _groupService.EditGroup(model);
            return RedirectToAction("GroupView",new{model.Id});
        }

        [HttpGet]
        public IActionResult CreateGroup()
        {
            var model = new GroupViewModel
            {
                TeachersList = _teacherService.Select(),
                CoursesList = _courseService.Select()
            };
            return PartialView(_editForm,model);
        }

        [HttpPost]
        public IActionResult CreateGroup(Group model)
        {
            _groupService.CreateGroup(model);
            return RedirectToAction("Index","Home");
        }
        
    }

}
