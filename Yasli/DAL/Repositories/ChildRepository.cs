using System;
using System.Collections.Generic;
using System.Text;
using DAL.Entities;

namespace DAL.Repositories
{
    class ChildRepository : IRepositoryChild
    {
        readonly YasliDBContext _context;
        public ChildRepository(YasliDBContext context) => _context = context;

        public void Add(Child child)
        {
            throw new NotImplementedException();
        }

        public Child GetById(Child ID)
        {
            throw new NotImplementedException();
        }

        public List<Child> GetChildren()
        {
            throw new NotImplementedException();
        }

        public void Remove(Child id)
        {
            throw new NotImplementedException();
        }
    }
}
