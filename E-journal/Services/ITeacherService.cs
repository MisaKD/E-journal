﻿using E_journal.Models;
using System.Collections.Generic;

namespace E_journal.Services
{
    public interface ITeacherService
    {
        List<Teacher> Select();
        Teacher SelectById(int Id);
        void CreateTeacher(Teacher model);
        void EditTeacher(Teacher model);


    }
}
