﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_journal.Models;

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