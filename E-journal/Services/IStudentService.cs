using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_journal.Models;
using Microsoft.AspNetCore.Http;

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
