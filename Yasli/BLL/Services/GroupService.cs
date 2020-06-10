using System;
using System.Collections.Generic;
using System.Text;
using BLL.Interfaces;
using DAL.Entities;
using DAL.Repositories;

namespace BLL.Services
{
    public class GroupService : IGroupInterface
    {
        private readonly IRepositoryGroup _repository;

        public GroupService(/*GroupDTO group,*/ IRepositoryGroup grouprepository)
        {
            _repository = grouprepository;
        }

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
