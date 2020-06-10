using System;
using System.Collections.Generic;
using System.Text;
using DAL.Entities;

namespace BLL.Interfaces
{
    public interface IChildInterface
    {
        void Add(Child child);
        void Remove(Child id);
        List<Child> GetChildren();
        Child GetById(Child ID);
    }
}
