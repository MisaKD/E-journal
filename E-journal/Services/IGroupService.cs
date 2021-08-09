using E_journal.Models;
using E_journal.Models.ViewModels;
using System.Collections.Generic;

namespace E_journal.Services
{
    public interface IGroupService
    {
        List<Group> Select();
        Group SelectById(int Id);
        void CreateGroup(GroupViewModel model);
        void EditGroup(GroupViewModel model);

    }
}
