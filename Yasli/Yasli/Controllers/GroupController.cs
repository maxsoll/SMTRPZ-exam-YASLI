using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interfaces;
using DAL.Entities;

namespace Yasli.Controllers
{
    public class GroupController
    {
        private readonly IGroupInterface _service;

        public GroupController(IGroupInterface groupservice)
        {
            _service = groupservice;
        }


        public void Add(Group group)
        {
            throw new NotImplementedException();
        }

        public Group GetById(Group ID)
        {
            throw new NotImplementedException();
        }

        public List<Group> GetChildren()
        {
            throw new NotImplementedException();
        }

        }
    }
}
