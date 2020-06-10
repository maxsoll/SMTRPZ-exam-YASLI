using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
   public class Parent : BaseEntityID<int>
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

    }
}
