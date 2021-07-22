using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_journal.Models.ViewModels;
using E_journal.Services;
using Microsoft.AspNetCore.Mvc;

namespace E_journal.Controllers
{
    public class GroupController:Controller
    {
        private IGroupService _groupService;
        private IStudentService _studentService;

        public GroupController(IGroupService groupService,IStudentService studentService)
        {
            _groupService = groupService;
            _studentService = studentService;
        }


        public IActionResult GroupView(int Id)
        {
            var group = _groupService.SelectById(Id);
            var model = new GroupViewModel
            {
                Id = group.Id,
                Name = group.Name,
                CourseId = group.Course.Id,
                Curator = group.Curator,
                Students = _studentService.SelectByGroupId(Id)
            };
            return View(model);
            
        }
    }
}
