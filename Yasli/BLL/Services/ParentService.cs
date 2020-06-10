using System;
using System.Collections.Generic;
using System.Text;
using BLL.Interfaces;
using DAL.Entities;
using DAL.Repositories;
using BLL.DTO;

namespace BLL.Services
{
    public class ParentService : IParentInterface
    {
        private readonly IRepositoryParent _repository;

        public ParentService(/*ParentDTO parent,*/ IRepositoryParent parentrepossitory) {
            _repository = parentrepossitory;
        }
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
