using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace E_journal.Models.ViewModels
{
    public class TeacherViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Введите имя")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Введите предмет")]
        public string Discipline { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}
