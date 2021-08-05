using System.Collections.Generic;

namespace E_journal.Models.ViewModels
{
    public class TeacherViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Discipline { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}
