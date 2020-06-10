using System;
using System.Collections.Generic;
using System.Text;
using DAL.Entities;

namespace DAL.Repositories
{
    public interface IRepositoryChild
    {
        void Add(Child child);
        void Remove(Child id);
        List<Child> GetChildren();
        Child GetById(Child ID);
    }
}
