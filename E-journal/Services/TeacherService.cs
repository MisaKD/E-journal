using E_journal.Models;
using E_journal.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace E_journal.Services
{
    public class TeacherService : ITeacherService
    {
        public EjournalContext _context;

        public TeacherService(EjournalContext context)
        {
            _context = context;
        }

        public List<Teacher> Select()
        {
            var teacherList = _context.Teachers.ToList();
            return teacherList;
        }

        public Teacher SelectById(int Id)
        {
            var teacher = _context.Teachers.FirstOrDefault(_ => _.Id == Id);
            return teacher;
        }

        public void CreateTeacher(Teacher model)
        {
           
            _context.Teachers.Add(model);
            _context.SaveChanges();
        }

        public void EditTeacher(Teacher model)
        {
            _context.Entry(model).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
