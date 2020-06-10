using System;
using System.Collections.Generic;
using System.Text;
using DAL.Entities;

namespace DAL.Repositories
{
    public interface IRepositoryParent
    {
        void Add(Parent group);
        void Remove(Parent id);
        List<Parent> GetGroups();
        Group GetById(Parent ID);
    }
}
