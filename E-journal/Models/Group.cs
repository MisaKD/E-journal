using System.ComponentModel.DataAnnotations;

namespace E_journal.Models
{
    public class Group
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Не введен номер группы")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Не введена специальность")]
        public string Specialization { get; set; }
        [Required(ErrorMessage = "Не введен год")]
        public int Year { get; set; }
        [Required(ErrorMessage = "Не введен куратор")]
        public string Curator { get; set; }
        public Course Course { get; set; }
        public int CourseId { get; set; }
    }
}
