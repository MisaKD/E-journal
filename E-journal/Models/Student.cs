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
        [Phone]
        [RegularExpression(@"^((\+373|)[\- ]?)?\(?\d{3,5}\)?[\- ]?\d{1}[\- ]?\d{1}[\- ]?\d{1}[\- ]?\d{1}[\- ]?\d{1}(([\- ]?\d{1})?[\- ]?\d{1})?$", ErrorMessage = "Номер телефона должен иметь формат +373-(ххх)-x-xx-хx")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Не указан возраст")]
        public int Age { get; set; }
        public string PhotoName { get; set; }
        [Required(ErrorMessage = "Не указан адрес электронной почты")]
        [EmailAddress]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный адрес")]
        public string Email { get; set; }
    }
}
