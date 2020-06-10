using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interfaces;
using DAL.Entities;

namespace Yasli.Controllers
{
    public class ParrentController
    {
        private readonly IParentInterface _service;

        public ParrentController(IParentInterface parentservice)
        {
            _service = parentservice;
        }

        public void Add(Parent group)
        {
            throw new NotImplementedException();
        }

        public Parent GetById(Parent ID)
        {
            throw new NotImplementedException();
        }

        public List<Child> GetChildren()
        {
            throw new NotImplementedException();
        }

    }
}
}
