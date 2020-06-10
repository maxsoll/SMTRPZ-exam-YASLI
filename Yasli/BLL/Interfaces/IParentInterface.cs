using System;
using System.Collections.Generic;
using System.Text;
using DAL.Entities;

namespace BLL.Interfaces
{
    public interface IParentInterface
    {
        void Add(Parent group);
        void Remove(Parent id);
        List<Parent> GetGroups();
        Group GetById(Parent ID);
    }
}
