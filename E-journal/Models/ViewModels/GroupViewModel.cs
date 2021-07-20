using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_journal.Models.ViewModels
{
    public class GroupViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Curator { get; set; }
        public int CourseId { get; set; }
        public List<Group> GroupList { get; set; }

    }
}
