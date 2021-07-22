using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_journal.Models;

namespace E_journal.Services
{
    public class StudentService : IStudentService
    {
        private EjournalContext _context;

        public StudentService(EjournalContext context)
        {
            _context = context;
        }

        public List<Student> SelectByGroupId(int groupId)
        {
            var studentList = _context.Students.Where(_ => _.Group.Id == groupId).ToList();
            return studentList;

        }
    }
}
