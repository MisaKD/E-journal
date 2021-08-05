using E_journal.Models;
using System.Collections.Generic;

namespace E_journal.Services
{
    public interface ICourseService
    {
        List<Course> Select();
    }
}
