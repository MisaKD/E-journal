using E_journal.Models;
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
        public void CreateStudent(Student model, IFormFile uploadedFile)
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

            _context.Students.Add(model);
            _context.SaveChanges();

        }

        public void EditStudent(Student model, IFormFile uploadedFile)
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

            _context.Entry(model).State = EntityState.Modified;
            _context.SaveChanges();
        }


    }
}
