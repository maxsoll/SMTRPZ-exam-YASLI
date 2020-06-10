using System;
using System.Collections.Generic;
using System.Text;
using DAL.Entities;

namespace DAL.Repositories
{
    class GroupRepository : IRepositoryGroup
    {
        readonly YasliDBContext _context;
        public GroupRepository(YasliDBContext context) => _context = context;

        public void Add(Group group)
        {
            throw new NotImplementedException();
        }

        public Group GetById(Group ID)
        {
            throw new NotImplementedException();
        }

        public List<Group> GetGroups()
        {
            throw new NotImplementedException();
        }

        public void Remove(Group id)
        {
            throw new NotImplementedException();
        }
    }
}
