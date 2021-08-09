using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace E_journal.Models.ViewModels
{
    public class GroupViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Не введен номер группы")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Не введен куратор")]
        public string Curator { get; set; }
        public int CourseId { get; set; }
        [Required(ErrorMessage = "Не введена специальность")]
        public string Specialization { get; set; }
        [Required(ErrorMessage = "Не введен год")]
        public int Year { get; set; }
        public Course Course { get; set; }
        public List<Group> GroupList { get; set; }
        public List<Student> StudentsList { get; set; }
        public List<Teacher> TeachersList { get; set; }
        public List<Course> CoursesList { get; set; }

    }
}
