using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Services;
using BLL.Interfaces;
using DAL.Entities;

namespace Yasli.Controllers
{
    public class ChildrenController
    {
        private readonly IChildInterface _service;

        public ChildrenController(IChildInterface childservice)
        {
            _service = childservice;
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
}
