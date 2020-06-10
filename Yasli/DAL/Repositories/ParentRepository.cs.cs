using System;
using System.Collections.Generic;
using System.Text;
using DAL.Entities;

namespace DAL.Repositories
{
    class ParentRepository : IRepositoryParent
    {
        readonly YasliDBContext _context;
        public ParentRepository(YasliDBContext context) => _context = context;

        public void Add(Parent group)
        {
            throw new NotImplementedException();
        }

        public Group GetById(Parent ID)
        {
            throw new NotImplementedException();
        }

        public List<Parent> GetGroups()
        {
            throw new NotImplementedException();
        }

        public void Remove(Parent id)
        {
            throw new NotImplementedException();
        }
    }
}
