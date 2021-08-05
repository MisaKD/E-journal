using E_journal.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace E_journal.Services
{
    public class GroupService : IGroupService
    {
        private EjournalContext _context;

        public GroupService(EjournalContext context)
        {
            _context = context;
        }
        public List<Group> Select()
        {
            var groupList = _context.Groups.Include(_ => _.Course).ToList();
            return groupList;
        }

        public Group SelectById(int Id)
        {
            var group = _context.Groups.Include(_ => _.Course).FirstOrDefault(_ => _.Id == Id);
            return group;
        }

        public void CreateGroup(Group model)
        {
            _context.Groups.Add(model);
            _context.SaveChanges();
        }

        public void EditGroup(Group model)
        {
            _context.Entry(model).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
