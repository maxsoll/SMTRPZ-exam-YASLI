using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Group : BaseEntityID<int>
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public List<Child> Childrens { get; set; }
    }
}
