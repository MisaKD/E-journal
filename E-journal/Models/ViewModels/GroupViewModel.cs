using System.Collections.Generic;

namespace E_journal.Models.ViewModels
{
    public class GroupViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Curator { get; set; }
        public int CourseId { get; set; }
        public string Specialization { get; set; }
        public int Year { get; set; }
        public Course Course { get; set; }
        public List<Group> GroupList { get; set; }
        public List<Student> StudentsList { get; set; }
        public List<Teacher> TeachersList { get; set; }
        public List<Course> CoursesList { get; set; }

    }
}
