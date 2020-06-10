﻿using System;
using System.Collections.Generic;
using System.Text;
using DAL.Entities;

namespace DAL.Repositories
{
    public interface IRepositoryGroup
    {
        void Add(Group group);
        void Remove(Group id);
        List<Group> GetGroups();
        Group GetById(Group ID);

    }
}
