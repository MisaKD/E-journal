using E_journal.Models;
using E_journal.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace E_journal.Services
{
    public interface IStudentService
    {
        List<Student> SelectByGroupId(int groupId);
        Student SelectById(int Id);
        void CreateStudent(Student model, IFormFile uploadedFile);
        void EditStudent(Student model, IFormFile uploadedFile);

    }
}
