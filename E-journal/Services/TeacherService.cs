using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_journal.Models;

namespace E_journal.Services
{
    public class TeacherService:ITeacherService
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

    }
}
