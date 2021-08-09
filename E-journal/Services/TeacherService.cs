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

        public void CreateTeacher(TeacherViewModel model)
        {
            var domainModel = new Teacher
            {
                Name = model.Name,
                Discipline=model.Discipline
            };
            _context.Teachers.Add(domainModel);
            _context.SaveChanges();
        }

        public void EditTeacher(TeacherViewModel model)
        {
            var domainModel = new Teacher
            {
                Id=model.Id,
                Name = model.Name,
                Discipline = model.Discipline
            };
            _context.Entry(domainModel).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
