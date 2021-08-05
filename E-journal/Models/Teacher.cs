using System.ComponentModel.DataAnnotations;

namespace E_journal.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Введите имя")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Введите предмет")]
        public string Discipline { get; set; }

    }
}
