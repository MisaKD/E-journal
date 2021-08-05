using System.ComponentModel.DataAnnotations;

namespace E_journal.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Не указано имя")]
        public string Name { get; set; }
        public Group Group { get; set; }
        public int GroupId { get; set; }
        [Required(ErrorMessage = "Не указан номер телефона")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Не указан возраст")]
        public int Age { get; set; }
        public string PhotoName { get; set; }
        [Required(ErrorMessage = "Не указан адрес электронной почты")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
