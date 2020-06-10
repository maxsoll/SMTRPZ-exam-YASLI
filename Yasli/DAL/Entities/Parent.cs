using System;
using System.Collections.Generic;
using System.Text;
using DAL.Entities.Enum;

namespace DAL.Entities
{
   public class Parent : BaseEntityID<int>
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public TypeOfParent TypofParent { get; set; }
    
    }
}
