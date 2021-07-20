using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_journal.Models;

namespace E_journal.Services
{
    public class GroupService: IGroupService
    {
        private EjournalContext _context;

        public GroupService(EjournalContext context)
        {
            _context = context;
        }
        public List<Group> Select()
        {
            var groupList = _context.Groups.ToList();
            return groupList;
        }
    }
}
