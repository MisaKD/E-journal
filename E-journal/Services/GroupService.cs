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

        public Group SelectById(int Id)
        {
            var group = _context.Groups.Find(Id);
            return group;
        }

        public void CreateGroup(Group model)
        {
            _context.Groups.Add(model);
            _context.SaveChanges();
            
        }

    }
}
