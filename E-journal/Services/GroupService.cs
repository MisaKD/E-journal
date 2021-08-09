using E_journal.Models;
using E_journal.Models.ViewModels;
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

        public void CreateGroup(GroupViewModel model)
        {
            var domainModel = new Group
            {
               Name=model.Name,
               Specialization=model.Specialization,
               Year=model.Year,
               Curator=model.Curator,
               Course=model.Course,
               CourseId=model.CourseId
            };
            _context.Groups.Add(domainModel);
            _context.SaveChanges();
        }

        public void EditGroup(GroupViewModel model)
        {
            var domainModel = new Group
            {
                Id=model.Id,
                Name = model.Name,
                Specialization = model.Specialization,
                Year = model.Year,
                Curator = model.Curator,
                Course = model.Course,
                CourseId = model.CourseId
            };
            _context.Entry(domainModel).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
