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
        private string _formErrorView = "~/Views/Home/FormError.cshtml";

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
            return View(_editForm, model);
        }

        [HttpPost]
        public IActionResult EditGroup(GroupViewModel model)
        {
            if (ModelState.IsValid)
            {
                var group = new Group
                {
                    Id = model.Id,
                    Name = model.Name,
                    Specialization = model.Specialization,
                    Year = model.Year,
                    Curator = model.Curator,
                    Course = model.Course,
                    CourseId = model.CourseId
                };

                _groupService.EditGroup(group);
                return RedirectToAction("GroupView", new { model.Id });
            }

            return View(_formErrorView);
        }

        [HttpGet]
        public IActionResult CreateGroup()
        {
            var model = new GroupViewModel
            {
                TeachersList = _teacherService.Select(),
                CoursesList = _courseService.Select()
            };
            return View(_editForm, model);
        }

        [HttpPost]
        public IActionResult CreateGroup(GroupViewModel model)
        {
            if (ModelState.IsValid)
            {
                var group = new Group
                {
                    Name = model.Name,
                    Specialization = model.Specialization,
                    Year = model.Year,
                    Curator = model.Curator,
                    Course = model.Course,
                    CourseId = model.CourseId
                };

                _groupService.CreateGroup(group);
                return RedirectToAction("Index", "Home");
            }
            return View(_formErrorView);

        }

    }

}
