using E_journal.Models;
using E_journal.Models.ViewModels;
using E_journal.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_journal.Controllers
{
    public class StudentController : Controller

    {
        private string _editForm = "~/Views/Student/Edit.cshtml";
        private string _formErrorView = "~/Views/Home/FormError.cshtml";
        private IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        [HttpGet]
        public IActionResult StudentView(int Id)
        {
            var student = _studentService.SelectById(Id);
            var model = new StudentViewModel()
            {
                Id = student.Id,
                Name = student.Name,
                Group = student.Group,
                PhoneNumber = student.PhoneNumber,
                Age = student.Age,
                PhotoName = student.PhotoName,
                Email = student.Email
            };
            return View(model);
        }
        [HttpGet]
        public IActionResult EditStudent(int Id)
        {
            var student = _studentService.SelectById(Id);
            var model = new StudentViewModel()
            {
                Id = student.Id,
                Name = student.Name,
                GroupId = student.GroupId,
                PhoneNumber = student.PhoneNumber,
                Age = student.Age,
                PhotoName = student.PhotoName,
                Email = student.Email
            };
            return View(_editForm, model);
        }

        [HttpPost]
        public IActionResult EditStudent(Student model, IFormFile uploadedFile)
        {
            if (ModelState.IsValid)
            {
                _studentService.EditStudent(model, uploadedFile);
                return RedirectToAction("StudentView", new { model.Id });
            }
            return View(_formErrorView);

        }

        [HttpGet]
        public IActionResult CreateStudent(int GroupId)
        {
            var model = new StudentViewModel()
            {
                GroupId = GroupId
            };
            return View(_editForm, model);
        }

        [HttpPost]
        public IActionResult CreateStudent(Student model, IFormFile uploadedFile)
        {
            if (ModelState.IsValid)
            {
                _studentService.CreateStudent(model, uploadedFile);
                return RedirectToAction("GroupView", "Group", new { Id = model.GroupId });
            }


            return View(_formErrorView);
        }
    }

}
