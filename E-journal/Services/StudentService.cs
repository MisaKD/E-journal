using E_journal.Models;
using E_journal.Models.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace E_journal.Services
{
    public class StudentService : IStudentService
    {
        private EjournalContext _context;
        IWebHostEnvironment EjEnvironment;

        public StudentService(EjournalContext context, IWebHostEnvironment appEnvironment)
        {
            EjEnvironment = appEnvironment;
            _context = context;
        }

        public Student SelectById(int Id)
        {
            var student = _context.Students.Include(_ => _.Group).FirstOrDefault(_ => _.Id == Id);
            return student;
        }

        public List<Student> SelectByGroupId(int groupId)
        {
            var studentList = _context.Students.Where(_ => _.Group.Id == groupId).ToList();
            return studentList;

        }
        public void CreateStudent(StudentViewModel model, IFormFile uploadedFile)
        {
            
            if (uploadedFile != null)
            {
                string path = "/Student/Photo/" + uploadedFile.FileName;
                using (var fileStream = new FileStream(EjEnvironment.WebRootPath + path, FileMode.Create))
                {
                    uploadedFile.CopyTo(fileStream);
                }

                model.PhotoName = uploadedFile.FileName;
            }
            var domainModel = new Student
            {
                Name = model.Name,
                Group = model.Group,
                GroupId = model.GroupId,
                PhoneNumber = model.PhoneNumber,
                Age = model.Age,
                PhotoName = model.PhotoName,
                Email = model.Email
            };
            _context.Students.Add(domainModel);
            _context.SaveChanges();

        }

        public void EditStudent(StudentViewModel model, IFormFile uploadedFile)
        {
            if (uploadedFile != null)
            {
                string path = "/Student/Photo/" + uploadedFile.FileName;
                using (var fileStream = new FileStream(EjEnvironment.WebRootPath + path, FileMode.Create))
                {
                    uploadedFile.CopyTo(fileStream);
                }

                model.PhotoName = uploadedFile.FileName;
            }
            var domainModel = new Student
            {
                Id=model.Id,
                Name = model.Name,
                Group = model.Group,
                GroupId = model.GroupId,
                PhoneNumber = model.PhoneNumber,
                Age = model.Age,
                PhotoName = model.PhotoName,
                Email = model.Email
            };
            _context.Entry(domainModel).State = EntityState.Modified;
            _context.SaveChanges();
        }


    }
}
