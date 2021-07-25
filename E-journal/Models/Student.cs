﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_journal.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Group Group { get; set; }
        public int GroupId { get; set; }        
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public string PhotoName { get; set; }
    }
}
