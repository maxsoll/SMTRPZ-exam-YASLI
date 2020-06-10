using System;
using System.Collections.Generic;
using System.Text;


namespace DAL.Entities
{
    public class Child : BaseEntityID<int>
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public List<Parent> Parents { get; set; }

    }
}
