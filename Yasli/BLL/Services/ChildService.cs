using System;
using System.Collections.Generic;
using System.Text;
using BLL.Interfaces;
using DAL.Entities;
using DAL.Repositories;

namespace BLL.Services
{
    public class ChildService : IChildInterface
    {
        private readonly IRepositoryChild _repository;

        public ChildService(/*ChildDTO child,*/ IRepositoryChild childrepository)
        {
            _repository = childrepository;
        }
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
