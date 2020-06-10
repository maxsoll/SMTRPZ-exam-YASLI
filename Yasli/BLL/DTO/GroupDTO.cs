﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTO
{
    public class GroupDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public List<ChildrenDTO> Childrens;
    }
}
