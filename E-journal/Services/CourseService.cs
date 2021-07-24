using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_journal.Models;

namespace E_journal.Services
{
    public class CourseService:ICourseService
    {
        public EjournalContext _context;

        public CourseService(EjournalContext context)
        {
            _context = context;
        }

        public List<Course> Select()
        {
            var coursesList = _context.Courses.ToList();
            return coursesList;
        }
    }
}
