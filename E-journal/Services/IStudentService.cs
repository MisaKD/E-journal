﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_journal.Models;

namespace E_journal.Services
{
    public interface IStudentService
    {
        List<Student> SelectByGroupId(int groupId);
    }
}